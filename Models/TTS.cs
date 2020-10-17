using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Net.Http;
using HtmlAgilityPack;
using System.IO;
using Fizzler.Systems.HtmlAgilityPack;

namespace AV.Models
{
    public class TTS
    {
        public Action<string> Downloaded;
        public Action<string> Converted;
        public static int Rate=0;
        public static int Volume = 100;
        public static HttpClient _client = new HttpClient();
        public static InstalledVoice Voice;
        public readonly string Base;
        public readonly string Path;
        public readonly string Selector;
        private readonly string[] _tags = { "p", "h1", "h2", "h3", "blockquote", "strong" };
        public TTS(string path, string selector, string baseUrl)
        {
            Path = path;
            Selector = selector;
            Base = baseUrl + "/wp-json/wp/v2/pages/?link=";
        }

        public static IEnumerable<InstalledVoice> GetVoices()
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                // show installed voices
                foreach (var v in synthesizer.GetInstalledVoices())
                {
                    yield return v;
                }

            }
        }
        public static async void TestVoice(InstalledVoice voice)
        {
            voice.Enabled = true;
            
            await Task.Run(()=> { 
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                    // show installed voices
                synthesizer.Rate = Rate;
                synthesizer.Volume = Volume;
                synthesizer.SelectVoice(voice.VoiceInfo.Name);
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.Speak($"Hello, my name is {voice.VoiceInfo.Name}.");
            }
            });
        }

        public async Task DownloadContent(List<string> links)
        {
            try
            {
                if (Directory.Exists(Path))
                    Directory.Delete(Path, true);
                
            }
            catch
            {

            }
            Directory.CreateDirectory(Path);
            int count = links.Count, current=0;
            foreach (var link in links)
            {
                var resp = await _client.GetStringAsync(link);

                //string text = Encoding.UTF8.GetString(resp);

                //Page page = Newtonsoft.Json.JsonConvert.DeserializeObject<Page>(text);

                HtmlDocument document = new HtmlDocument();

                document.LoadHtml(resp);

                var elem = document.DocumentNode.QuerySelector(Selector);

                string res = "";

                var coll = elem.SelectNodes("*");

                foreach(var el in coll)
                {
                    string cl = el.Name;
                    if (_tags.Contains(cl))
                    {
                        if(cl.Contains("h"))
                            res += el.InnerText + " . ";
                        else
                            res += el.InnerText+" ";
                    }
                }

                File.WriteAllText(Path+link.Split(new string[] { "/"},StringSplitOptions.RemoveEmptyEntries).Last()+".txt",res);
                current++;
                Downloaded(Math.Round((double)(current /count*100), 0) + "%");
            }
        }
        public async Task<List<FileInfo>> ConvertToText()
        {
            List<FileInfo> files =new DirectoryInfo(Path).GetFiles().ToList();
            int count = files.Count, current = 0;
            await Task.Run(()=> { 
            foreach(var fl in files)
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                if(Voice!=null)
                    synthesizer.SelectVoice(Voice.VoiceInfo.Name);

                synthesizer.SetOutputToWaveFile(fl.FullName+".wav");
                synthesizer.Speak(File.ReadAllText(fl.FullName));
                        current++;
                        Converted(Math.Round((double)(current / count * 100), 0)+"%");
                    }
            });
            return files;
        }
    }
}
