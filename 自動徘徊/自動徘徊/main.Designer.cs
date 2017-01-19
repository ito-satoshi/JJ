namespace 自動徘徊
{
    partial class main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdOpenDlg1 = new System.Windows.Forms.Button();
            this.cmdOpenDlg2 = new System.Windows.Forms.Button();
            this.cmdOpenDlg3 = new System.Windows.Forms.Button();
            this.cmdOpenDlg4 = new System.Windows.Forms.Button();
            this.cmdOpenDlg5 = new System.Windows.Forms.Button();
            this.urlchangecombo = new System.Windows.Forms.ComboBox();
            this.alreadyreadradio = new System.Windows.Forms.RadioButton();
            this.unreadradio = new System.Windows.Forms.RadioButton();
            this.bothradio = new System.Windows.Forms.RadioButton();
            this.wordtext = new System.Windows.Forms.TextBox();
            this.datecombo = new System.Windows.Forms.ComboBox();
            this.redisplaybutton = new System.Windows.Forms.Button();
            this.wordlabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.app_exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdOpenDlg1
            // 
            this.cmdOpenDlg1.Location = new System.Drawing.Point(39, 38);
            this.cmdOpenDlg1.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOpenDlg1.Name = "cmdOpenDlg1";
            this.cmdOpenDlg1.Size = new System.Drawing.Size(190, 62);
            this.cmdOpenDlg1.TabIndex = 0;
            this.cmdOpenDlg1.Text = "URL変更・登録(&U)";
            this.cmdOpenDlg1.UseVisualStyleBackColor = true;
            this.cmdOpenDlg1.Click += new System.EventHandler(this.cmdOpenDlg1_Click);
            // 
            // cmdOpenDlg2
            // 
            this.cmdOpenDlg2.Location = new System.Drawing.Point(262, 38);
            this.cmdOpenDlg2.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOpenDlg2.Name = "cmdOpenDlg2";
            this.cmdOpenDlg2.Size = new System.Drawing.Size(199, 62);
            this.cmdOpenDlg2.TabIndex = 1;
            this.cmdOpenDlg2.Tag = "";
            this.cmdOpenDlg2.Text = "サービスの再起動(&S)";
            this.cmdOpenDlg2.UseVisualStyleBackColor = true;
            this.cmdOpenDlg2.Click += new System.EventHandler(this.cmdOpenDlg2_Click);
            // 
            // cmdOpenDlg3
            // 
            this.cmdOpenDlg3.Location = new System.Drawing.Point(505, 38);
            this.cmdOpenDlg3.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOpenDlg3.Name = "cmdOpenDlg3";
            this.cmdOpenDlg3.Size = new System.Drawing.Size(208, 62);
            this.cmdOpenDlg3.TabIndex = 2;
            this.cmdOpenDlg3.Text = "ヘルプ(&H)";
            this.cmdOpenDlg3.UseVisualStyleBackColor = true;
            this.cmdOpenDlg3.Click += new System.EventHandler(this.cmdOpenDlg3_Click);
            // 
            // cmdOpenDlg4
            // 
            this.cmdOpenDlg4.Location = new System.Drawing.Point(740, 38);
            this.cmdOpenDlg4.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOpenDlg4.Name = "cmdOpenDlg4";
            this.cmdOpenDlg4.Size = new System.Drawing.Size(209, 62);
            this.cmdOpenDlg4.TabIndex = 3;
            this.cmdOpenDlg4.Text = "制限解除(&R)";
            this.cmdOpenDlg4.UseVisualStyleBackColor = true;
            this.cmdOpenDlg4.Click += new System.EventHandler(this.cmdOpenDlg4_Click);
            // 
            // cmdOpenDlg5
            // 
            this.cmdOpenDlg5.Location = new System.Drawing.Point(980, 38);
            this.cmdOpenDlg5.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOpenDlg5.Name = "cmdOpenDlg5";
            this.cmdOpenDlg5.Size = new System.Drawing.Size(189, 62);
            this.cmdOpenDlg5.TabIndex = 4;
            this.cmdOpenDlg5.Text = "記事の取得間隔(&T)";
            this.cmdOpenDlg5.UseVisualStyleBackColor = true;
            this.cmdOpenDlg5.Click += new System.EventHandler(this.cmdOpenDlg5_Click);
            // 
            // urlchangecombo
            // 
            this.urlchangecombo.FormattingEnabled = true;
            this.urlchangecombo.Location = new System.Drawing.Point(39, 164);
            this.urlchangecombo.Margin = new System.Windows.Forms.Padding(2);
            this.urlchangecombo.Name = "urlchangecombo";
            this.urlchangecombo.Size = new System.Drawing.Size(353, 26);
            this.urlchangecombo.TabIndex = 5;
            this.urlchangecombo.Text = "　　　　　　　　　　　URL";
            this.urlchangecombo.SelectedIndexChanged += new System.EventHandler(this.urlchangecombo_SelectedIndexChanged);
            // 
            // alreadyreadradio
            // 
            this.alreadyreadradio.AutoSize = true;
            this.alreadyreadradio.Location = new System.Drawing.Point(461, 169);
            this.alreadyreadradio.Margin = new System.Windows.Forms.Padding(2);
            this.alreadyreadradio.Name = "alreadyreadradio";
            this.alreadyreadradio.Size = new System.Drawing.Size(69, 22);
            this.alreadyreadradio.TabIndex = 6;
            this.alreadyreadradio.TabStop = true;
            this.alreadyreadradio.Text = "既読";
            this.alreadyreadradio.UseVisualStyleBackColor = true;
            // 
            // unreadradio
            // 
            this.unreadradio.AutoSize = true;
            this.unreadradio.Location = new System.Drawing.Point(536, 169);
            this.unreadradio.Margin = new System.Windows.Forms.Padding(2);
            this.unreadradio.Name = "unreadradio";
            this.unreadradio.Size = new System.Drawing.Size(69, 22);
            this.unreadradio.TabIndex = 7;
            this.unreadradio.TabStop = true;
            this.unreadradio.Text = "未読";
            this.unreadradio.UseVisualStyleBackColor = true;
            this.unreadradio.CheckedChanged += new System.EventHandler(this.unread_CheckedChanged);
            // 
            // bothradio
            // 
            this.bothradio.AutoSize = true;
            this.bothradio.Location = new System.Drawing.Point(611, 169);
            this.bothradio.Margin = new System.Windows.Forms.Padding(2);
            this.bothradio.Name = "bothradio";
            this.bothradio.Size = new System.Drawing.Size(69, 22);
            this.bothradio.TabIndex = 8;
            this.bothradio.TabStop = true;
            this.bothradio.Text = "両方";
            this.bothradio.UseVisualStyleBackColor = true;
            // 
            // wordtext
            // 
            this.wordtext.Location = new System.Drawing.Point(788, 168);
            this.wordtext.Margin = new System.Windows.Forms.Padding(2);
            this.wordtext.Name = "wordtext";
            this.wordtext.Size = new System.Drawing.Size(148, 25);
            this.wordtext.TabIndex = 9;
            // 
            // datecombo
            // 
            this.datecombo.FormattingEnabled = true;
            this.datecombo.Location = new System.Drawing.Point(1028, 164);
            this.datecombo.Margin = new System.Windows.Forms.Padding(2);
            this.datecombo.Name = "datecombo";
            this.datecombo.Size = new System.Drawing.Size(190, 26);
            this.datecombo.TabIndex = 10;
            // 
            // redisplaybutton
            // 
            this.redisplaybutton.Location = new System.Drawing.Point(1248, 160);
            this.redisplaybutton.Margin = new System.Windows.Forms.Padding(2);
            this.redisplaybutton.Name = "redisplaybutton";
            this.redisplaybutton.Size = new System.Drawing.Size(122, 35);
            this.redisplaybutton.TabIndex = 11;
            this.redisplaybutton.Text = "再表示";
            this.redisplaybutton.UseVisualStyleBackColor = true;
            // 
            // wordlabel
            // 
            this.wordlabel.AutoSize = true;
            this.wordlabel.Location = new System.Drawing.Point(738, 170);
            this.wordlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wordlabel.Name = "wordlabel";
            this.wordlabel.Size = new System.Drawing.Size(44, 18);
            this.wordlabel.TabIndex = 12;
            this.wordlabel.Text = "単語";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(978, 170);
            this.datelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(44, 18);
            this.datelabel.TabIndex = 13;
            this.datelabel.Text = "日付";
            // 
            // app_exit
            // 
            this.app_exit.Location = new System.Drawing.Point(1206, 38);
            this.app_exit.Margin = new System.Windows.Forms.Padding(2);
            this.app_exit.Name = "app_exit";
            this.app_exit.Size = new System.Drawing.Size(182, 62);
            this.app_exit.TabIndex = 14;
            this.app_exit.Text = "アプリの終了(&X)";
            this.app_exit.UseVisualStyleBackColor = true;
            this.app_exit.Click += new System.EventHandler(this.app_exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBox1.Location = new System.Drawing.Point(39, 253);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(395, 149);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(505, 253);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(395, 149);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(972, 253);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(396, 149);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(39, 455);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(395, 149);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(505, 455);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(395, 149);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(972, 455);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(396, 149);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(39, 654);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(395, 149);
            this.textBox7.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(505, 654);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(395, 149);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(972, 654);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(396, 149);
            this.textBox9.TabIndex = 23;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 857);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.app_exit);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.wordlabel);
            this.Controls.Add(this.redisplaybutton);
            this.Controls.Add(this.datecombo);
            this.Controls.Add(this.wordtext);
            this.Controls.Add(this.bothradio);
            this.Controls.Add(this.unreadradio);
            this.Controls.Add(this.alreadyreadradio);
            this.Controls.Add(this.urlchangecombo);
            this.Controls.Add(this.cmdOpenDlg5);
            this.Controls.Add(this.cmdOpenDlg4);
            this.Controls.Add(this.cmdOpenDlg3);
            this.Controls.Add(this.cmdOpenDlg2);
            this.Controls.Add(this.cmdOpenDlg1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "自動徘徊";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOpenDlg1;
        private System.Windows.Forms.Button cmdOpenDlg2;
        private System.Windows.Forms.Button cmdOpenDlg3;
        private System.Windows.Forms.Button cmdOpenDlg4;
        private System.Windows.Forms.Button cmdOpenDlg5;
        private System.Windows.Forms.ComboBox urlchangecombo;
        private System.Windows.Forms.RadioButton alreadyreadradio;
        private System.Windows.Forms.RadioButton unreadradio;
        private System.Windows.Forms.RadioButton bothradio;
        private System.Windows.Forms.TextBox wordtext;
        private System.Windows.Forms.ComboBox datecombo;
        private System.Windows.Forms.Button redisplaybutton;
        private System.Windows.Forms.Label wordlabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Button app_exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}

