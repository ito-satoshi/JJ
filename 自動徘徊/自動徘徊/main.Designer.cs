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
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.firstpageButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastpageButton = new System.Windows.Forms.Button();
            this.pageBar = new System.Windows.Forms.TrackBar();
            this.backButton = new System.Windows.Forms.Button();
            this.pagenumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBar)).BeginInit();
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
            this.urlchangecombo.Location = new System.Drawing.Point(39, 169);
            this.urlchangecombo.Margin = new System.Windows.Forms.Padding(2);
            this.urlchangecombo.Name = "urlchangecombo";
            this.urlchangecombo.Size = new System.Drawing.Size(353, 26);
            this.urlchangecombo.TabIndex = 5;
            this.urlchangecombo.Text = "　　　　　　　　　　　URL";
            this.urlchangecombo.SelectedIndexChanged += new System.EventHandler(this.urlchangecombo_SelectedIndexChanged);
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
            this.redisplaybutton.Text = "検索";
            this.redisplaybutton.UseVisualStyleBackColor = true;
            this.redisplaybutton.Click += new System.EventHandler(this.redisplaybutton_Click);
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
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBox1.Location = new System.Drawing.Point(39, 253);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(395, 149);
            this.textBox1.TabIndex = 15;
            this.textBox1.Tag = "0";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.Location = new System.Drawing.Point(505, 253);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(395, 149);
            this.textBox2.TabIndex = 16;
            this.textBox2.Tag = "1";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox3.Location = new System.Drawing.Point(972, 253);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(396, 149);
            this.textBox3.TabIndex = 17;
            this.textBox3.Tag = "2";
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox4.Location = new System.Drawing.Point(39, 455);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(395, 149);
            this.textBox4.TabIndex = 18;
            this.textBox4.Tag = "3";
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox5.Location = new System.Drawing.Point(505, 455);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(395, 149);
            this.textBox5.TabIndex = 19;
            this.textBox5.Tag = "4";
            // 
            // textBox6
            // 
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox6.Location = new System.Drawing.Point(972, 455);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(396, 149);
            this.textBox6.TabIndex = 20;
            this.textBox6.Tag = "5";
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox7.Location = new System.Drawing.Point(39, 668);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(395, 149);
            this.textBox7.TabIndex = 21;
            this.textBox7.Tag = "6";
            // 
            // textBox8
            // 
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox8.Location = new System.Drawing.Point(505, 668);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(395, 149);
            this.textBox8.TabIndex = 22;
            this.textBox8.Tag = "7";
            // 
            // textBox9
            // 
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox9.Location = new System.Drawing.Point(972, 668);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(396, 149);
            this.textBox9.TabIndex = 23;
            this.textBox9.Tag = "8";
            // 
            // textBox10
            // 
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox10.Location = new System.Drawing.Point(39, 877);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(395, 149);
            this.textBox10.TabIndex = 24;
            this.textBox10.Tag = "9";
            // 
            // textBox11
            // 
            this.textBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox11.Location = new System.Drawing.Point(505, 877);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(395, 149);
            this.textBox11.TabIndex = 25;
            this.textBox11.Tag = "10";
            // 
            // textBox12
            // 
            this.textBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox12.Location = new System.Drawing.Point(972, 877);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(396, 149);
            this.textBox12.TabIndex = 26;
            this.textBox12.Tag = "11";
            // 
            // textBox13
            // 
            this.textBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox13.Location = new System.Drawing.Point(39, 1078);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(395, 149);
            this.textBox13.TabIndex = 27;
            this.textBox13.Tag = "12";
            // 
            // textBox14
            // 
            this.textBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox14.Location = new System.Drawing.Point(505, 1078);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(395, 149);
            this.textBox14.TabIndex = 28;
            this.textBox14.Tag = "13";
            // 
            // textBox15
            // 
            this.textBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox15.Location = new System.Drawing.Point(972, 1078);
            this.textBox15.Margin = new System.Windows.Forms.Padding(2);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(396, 149);
            this.textBox15.TabIndex = 29;
            this.textBox15.Tag = "14";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(479, 169);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 22);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "既読";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(554, 170);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 22);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "未読";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(629, 170);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 22);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "両方";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // firstpageButton
            // 
            this.firstpageButton.Location = new System.Drawing.Point(39, 1272);
            this.firstpageButton.Margin = new System.Windows.Forms.Padding(2);
            this.firstpageButton.Name = "firstpageButton";
            this.firstpageButton.Size = new System.Drawing.Size(142, 49);
            this.firstpageButton.TabIndex = 33;
            this.firstpageButton.Text = "最初のページ";
            this.firstpageButton.UseVisualStyleBackColor = true;
            this.firstpageButton.Click += new System.EventHandler(this.firstpageButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(1121, 1272);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(82, 49);
            this.nextButton.TabIndex = 35;
            this.nextButton.Text = "次へ";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastpageButton
            // 
            this.lastpageButton.Location = new System.Drawing.Point(1231, 1272);
            this.lastpageButton.Margin = new System.Windows.Forms.Padding(2);
            this.lastpageButton.Name = "lastpageButton";
            this.lastpageButton.Size = new System.Drawing.Size(139, 49);
            this.lastpageButton.TabIndex = 36;
            this.lastpageButton.Text = "最後のページ";
            this.lastpageButton.UseVisualStyleBackColor = true;
            this.lastpageButton.Click += new System.EventHandler(this.lastpageButton_Click);
            // 
            // pageBar
            // 
            this.pageBar.Location = new System.Drawing.Point(332, 1262);
            this.pageBar.Margin = new System.Windows.Forms.Padding(2);
            this.pageBar.Name = "pageBar";
            this.pageBar.Size = new System.Drawing.Size(766, 69);
            this.pageBar.TabIndex = 37;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(216, 1272);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 49);
            this.backButton.TabIndex = 38;
            this.backButton.Text = "前へ";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pagenumber
            // 
            this.pagenumber.AutoSize = true;
            this.pagenumber.Location = new System.Drawing.Point(611, 1303);
            this.pagenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pagenumber.Name = "pagenumber";
            this.pagenumber.Size = new System.Drawing.Size(0, 18);
            this.pagenumber.TabIndex = 39;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 1254);
            this.Controls.Add(this.pagenumber);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pageBar);
            this.Controls.Add(this.lastpageButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.firstpageButton);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
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
            this.Controls.Add(this.urlchangecombo);
            this.Controls.Add(this.cmdOpenDlg5);
            this.Controls.Add(this.cmdOpenDlg4);
            this.Controls.Add(this.cmdOpenDlg3);
            this.Controls.Add(this.cmdOpenDlg2);
            this.Controls.Add(this.cmdOpenDlg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "自動徘徊";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageBar)).EndInit();
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
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button firstpageButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastpageButton;
        private System.Windows.Forms.TrackBar pageBar;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label pagenumber;
    }
}

