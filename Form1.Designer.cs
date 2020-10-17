namespace AV
{
    partial class AV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_links = new System.Windows.Forms.TextBox();
            this.bt_convert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_iv = new System.Windows.Forms.ListBox();
            this.bt_test = new System.Windows.Forms.Button();
            this.bt_select = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_selector = new System.Windows.Forms.TextBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_dw = new System.Windows.Forms.Label();
            this.lb_cv = new System.Windows.Forms.Label();
            this.tb_speed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_volume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_base = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lb_res = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_base);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tb_volume);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tb_speed);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_path);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tb_selector);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.bt_select);
            this.tabPage1.Controls.Add(this.bt_test);
            this.tabPage1.Controls.Add(this.lb_iv);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_cv);
            this.tabPage2.Controls.Add(this.lb_dw);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bt_convert);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tb_links);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Converter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "По ссылке(ам) на страницу:";
            // 
            // tb_links
            // 
            this.tb_links.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_links.Location = new System.Drawing.Point(245, 3);
            this.tb_links.Multiline = true;
            this.tb_links.Name = "tb_links";
            this.tb_links.Size = new System.Drawing.Size(642, 531);
            this.tb_links.TabIndex = 2;
            // 
            // bt_convert
            // 
            this.bt_convert.Location = new System.Drawing.Point(12, 455);
            this.bt_convert.Name = "bt_convert";
            this.bt_convert.Size = new System.Drawing.Size(212, 76);
            this.bt_convert.TabIndex = 4;
            this.bt_convert.Text = "Convert";
            this.bt_convert.UseVisualStyleBackColor = true;
            this.bt_convert.Click += new System.EventHandler(this.bt_convert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Downloaded:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Converted:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 71);
            this.button2.TabIndex = 0;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_iv
            // 
            this.lb_iv.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_iv.FormattingEnabled = true;
            this.lb_iv.ItemHeight = 20;
            this.lb_iv.Location = new System.Drawing.Point(399, 3);
            this.lb_iv.Name = "lb_iv";
            this.lb_iv.Size = new System.Drawing.Size(488, 531);
            this.lb_iv.TabIndex = 1;
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(115, 353);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(165, 71);
            this.bt_test.TabIndex = 2;
            this.bt_test.Text = "Test play";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(115, 259);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(165, 71);
            this.bt_select.TabIndex = 3;
            this.bt_select.Text = "Select";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selector:";
            // 
            // tb_selector
            // 
            this.tb_selector.Location = new System.Drawing.Point(97, 15);
            this.tb_selector.Name = "tb_selector";
            this.tb_selector.Size = new System.Drawing.Size(281, 26);
            this.tb_selector.TabIndex = 5;
            this.tb_selector.Text = "div.main_blog_text";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(97, 47);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(281, 26);
            this.tb_path.TabIndex = 7;
            this.tb_path.Text = "dir/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Path:";
            // 
            // lb_dw
            // 
            this.lb_dw.AutoSize = true;
            this.lb_dw.Location = new System.Drawing.Point(127, 116);
            this.lb_dw.Name = "lb_dw";
            this.lb_dw.Size = new System.Drawing.Size(18, 20);
            this.lb_dw.TabIndex = 8;
            this.lb_dw.Text = "_";
            // 
            // lb_cv
            // 
            this.lb_cv.AutoSize = true;
            this.lb_cv.Location = new System.Drawing.Point(127, 155);
            this.lb_cv.Name = "lb_cv";
            this.lb_cv.Size = new System.Drawing.Size(18, 20);
            this.lb_cv.TabIndex = 9;
            this.lb_cv.Text = "_";
            // 
            // tb_speed
            // 
            this.tb_speed.Location = new System.Drawing.Point(151, 125);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(227, 26);
            this.tb_speed.TabIndex = 9;
            this.tb_speed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Быстрота речи:";
            // 
            // tb_volume
            // 
            this.tb_volume.Location = new System.Drawing.Point(151, 194);
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(227, 26);
            this.tb_volume.TabIndex = 11;
            this.tb_volume.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Громкость речи:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "(-10 - 10)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "(0 - 100)";
            // 
            // tb_base
            // 
            this.tb_base.Enabled = false;
            this.tb_base.Location = new System.Drawing.Point(97, 79);
            this.tb_base.Name = "tb_base";
            this.tb_base.Size = new System.Drawing.Size(281, 26);
            this.tb_base.TabIndex = 15;
            this.tb_base.Text = "https://primetexasmovers.com/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Base:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lb_res);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(890, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Results";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lb_res
            // 
            this.lb_res.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_res.FormattingEnabled = true;
            this.lb_res.ItemHeight = 20;
            this.lb_res.Location = new System.Drawing.Point(0, 0);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(890, 537);
            this.lb_res.TabIndex = 0;
            this.lb_res.SelectedIndexChanged += new System.EventHandler(this.lb_res_SelectedIndexChanged);
            this.lb_res.DoubleClick += new System.EventHandler(this.lb_res_DoubleClick);
            this.lb_res.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_res_MouseMove);
            // 
            // AV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "AV";
            this.Text = "AV";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_links;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_selector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.ListBox lb_iv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_convert;
        private System.Windows.Forms.Label lb_cv;
        private System.Windows.Forms.Label lb_dw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_volume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_base;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lb_res;
    }
}

