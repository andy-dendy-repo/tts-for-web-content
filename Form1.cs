using AV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV
{
    public partial class AV : Form
    {
        class Voice
        {
            public InstalledVoice InVoice;
            public override string ToString()
            {
                return InVoice.VoiceInfo.Name;
            }
        }
        public AV()
        {
            InitializeComponent();
            lb_iv.DataSource = TTS.GetVoices().Select(x=>new Voice() {InVoice=x }).ToList();
        }
        public void Converted(string info)
        {
            lb_dw.Invoke(new MethodInvoker(()=> { lb_dw.Text = info; }));
        }
        public void Downloaded(string info)
        {
            lb_cv.Invoke(new MethodInvoker(() => { lb_cv.Text = info; }));
        }
        private async void bt_convert_Click(object sender, EventArgs e)
        {
            lb_cv.Text = "_";
            lb_dw.Text = "_";
            TTS srv = null;
            List<string> links=null;
            tb_links.Invoke(new MethodInvoker(()=> { 
                links = tb_links.Text.Split('\n').Select(x=>x.Replace("\r",string.Empty)).ToList();
                srv = new TTS(tb_path.Text, tb_selector.Text, tb_base.Text);
            }));
            srv.Converted = Converted;
            srv.Downloaded = Downloaded;

            await srv.DownloadContent(links);
            lb_res.DataSource = null;
            lb_res.DataSource= await srv.ConvertToText();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_iv.DataSource = TTS.GetVoices().Select(x => new Voice() { InVoice = x }).ToList();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            var voice = lb_iv.SelectedItem as Voice;
            if (voice != null)
                TTS.Voice=voice.InVoice;

            TTS.Rate = int.Parse(tb_speed.Text);
            TTS.Volume = int.Parse(tb_volume.Text);
        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            TTS.Rate = int.Parse(tb_speed.Text);
            TTS.Volume = int.Parse(tb_volume.Text);
            var voice = lb_iv.SelectedItem as Voice;
            if (voice != null)
                TTS.TestVoice(voice.InVoice);
        }

        private void lb_res_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lb_res_DoubleClick(object sender, EventArgs e)
        {
            var fl = lb_res.SelectedItem as FileInfo;
            if (fl != null)
                Process.Start("wmplayer.exe", fl.FullName + ".wav");
        }

        private void lb_res_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(new DataObject(DataFormats.FileDrop, new string[] { (lb_res.SelectedItem as FileInfo).FullName+".wav" }), DragDropEffects.Move);
            }
        }
    }
}
