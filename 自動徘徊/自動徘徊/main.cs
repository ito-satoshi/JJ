using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.ServiceProcess;

namespace 自動徘徊
{
    public partial class main : Form
    {
        private TextBox[] textBoxes;
        MySqlConnection con = new MySqlConnection("server=localhost;user=fsst;password=2455;database=jjdb;");
        Match title1;
        Match title2;
        int title3;
        string title;
        int p = 1;
        int max;
        int page;
        string[] ids = new string[15];
        int idx;
        int dts;

        public main()
        {
            InitializeComponent();
            textBox2.Enter += new EventHandler(textBox1_Enter);
            textBox3.Enter += new EventHandler(textBox1_Enter);
            textBox4.Enter += new EventHandler(textBox1_Enter);
            textBox5.Enter += new EventHandler(textBox1_Enter);
            textBox6.Enter += new EventHandler(textBox1_Enter);
            textBox7.Enter += new EventHandler(textBox1_Enter);
            textBox8.Enter += new EventHandler(textBox1_Enter);
            textBox9.Enter += new EventHandler(textBox1_Enter);
            textBox10.Enter += new EventHandler(textBox1_Enter);
            textBox11.Enter += new EventHandler(textBox1_Enter);
            textBox12.Enter += new EventHandler(textBox1_Enter);
            textBox13.Enter += new EventHandler(textBox1_Enter);
            textBox14.Enter += new EventHandler(textBox1_Enter);
            textBox15.Enter += new EventHandler(textBox1_Enter);
            pageBar.Scroll += new EventHandler(pageBar_ScrollChanged);
        }

        private void unread_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            backButton.Enabled = false;
            firstpageButton.Enabled = false;
            AutoScroll = true;
            textBoxes = new TextBox[]
              {textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8,
                textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15};
            page = 0;
            con.Open();
            Text_display(page);
            var command = new MySqlCommand("select count(*) from news_info;", con);
            object o = command.ExecuteScalar();
            if (int.Parse(o.ToString()) > 15)
            {
                max = Page_check();
            }
            else
            {
                nextButton.Enabled = false;
                lastpageButton.Enabled = false;
            }
            pageBar.TickFrequency = 1;
            pageBar.Minimum = 1;
            pageBar.Maximum = max;
        }

        private void pageBar_ScrollChanged(object sender, EventArgs e)
        {
            int check = pageBar.Value;
            if (check > p)
            {
                while (check != p)
                {
                    Next_page();
                }
            }
            else
            {
                while (check != p)
                {
                    Back_page();
                }
            }
        }

        public void Next_page()
        {
            backButton.Enabled = true;
            firstpageButton.Enabled = true;
            max = Page_check();
            int j = 0;
            p += 1;
            while (j != 15)
            {
                textBoxes[j].Text = "";
                j += 1;
            }
            page = (p - 1) * 15;
            Text_display(page);
            pageBar.Value = p;
            if (p == max)
            {
                nextButton.Enabled = false;
                lastpageButton.Enabled = false;
            }
        }

        public void Back_page()
        {
            nextButton.Enabled = true;
            lastpageButton.Enabled = true;
            max = Page_check();
            int j = 0;
            p -= 1;
            while (j != 15)
            {
                textBoxes[j].Text = "";
                j += 1;
            }
            page = (p - 1) * 15;
            Text_display(page);
            pageBar.Value = p;
            if (p == 1)
            {
                backButton.Enabled = false;
                firstpageButton.Enabled = false;
            }
        }

        public void Text_display(int page)
        {
            var command = new MySqlCommand($"select news_info.id,acquisition_date,url.url,main_text,alreadyread_flag from news_info inner join url on news_info.url_id = url.id order by acquisition_date desc limit {page}, 15;", con);
            var reader = command.ExecuteReader();
            int j = 0;
            while (reader.Read())
            {
                textBoxes[j].Text = Convert.ToDateTime(reader["acquisition_date"]).ToString("yyyy/MM/dd");
                ids[j] = $"{reader["id"]}";
                if (Convert.ToBoolean(reader["alreadyread_flag"]) == true)
                {
                    textBoxes[j].Text += "\t 既読\r\n";
                }
                else
                {
                    textBoxes[j].Text += "\t 未読\r\n";
                }
                textBoxes[j].Text += $"{reader["url"]}\r\n";
                Regex reg1 = new Regex("<title>", RegexOptions.IgnoreCase);
                title1 = reg1.Match(reader["main_text"].ToString());
                if (title1.Success == true)
                {
                    Regex reg2 = new Regex("</title>", RegexOptions.IgnoreCase);
                    title2 = reg2.Match(reader["main_text"].ToString());
                    title3 = title2.Index - title1.Index;
                    title = reader["main_text"].ToString().Substring(title1.Index + 7, title3 - 7);
                    textBoxes[j].Text += $"{title}";
                }
                else
                {
                    textBoxes[j].Text += "タイトルが見つかりませんでした。";
                }
                j += 1;
            }
            reader.Close();
            command = new MySqlCommand("select acquisition_date,url.url from news_info inner join url on news_info.url_id = url.id;", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                idx = urlchangecombo.Items.IndexOf(reader["url"]);
                if (idx == -1)
                {
                    urlchangecombo.Items.Add(reader["url"]);
                }
                dts = datecombo.Items.IndexOf(reader["acquisition_date"]);
                if (dts == -1)
                {
                    datecombo.Items.Add(reader["acquisition_date"]);
                }
            }
            reader.Close();
        }

        public int Page_check()
        {
            var command = new MySqlCommand("select count(*) from news_info;", con);
            object o = command.ExecuteScalar();
            int r;
            r = (int.Parse(o.ToString())) % 15;
            if (r == 0)
            {
                max = (int.Parse(o.ToString())) / 15;
            }
            else
            {
                max = ((int.Parse(o.ToString())) / 15) + 1;
            }
            return max;
        }

        private void urlchangecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdOpenDlg2_Click(object sender, EventArgs e)
        {
            using (ServiceController sc = new ServiceController("JidouJunkaiService"))
            {
                sc.Refresh();
                if (sc.Status == ServiceControllerStatus.Running)
                {
                    sc.Stop();
                }
                if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    sc.Start();
                }
                page = 0;
                Redisplay();
            }
        }

        private void app_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            con.Close();
        }

        private void cmdOpenDlg1_Click(object sender, EventArgs e)
        {
            DialogURL dlg = new DialogURL();
            dlg.ShowDialog();
        }

        private void cmdOpenDlg3_Click(object sender, EventArgs e)
        {
            Help dlg = new Help();
            dlg.ShowDialog();
        }

        private void cmdOpenDlg4_Click(object sender, EventArgs e)
        {
            KeepOut dlg = new KeepOut();
            dlg.ShowDialog();
        }

        private void cmdOpenDlg5_Click(object sender, EventArgs e)
        {
            Time dlg = new Time();
            dlg.ShowDialog();
        }

        public MySqlConnection GetConnection()
        {
            return con;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            int t;
            t = int.Parse(((TextBox)sender).Tag.ToString());
            if (textBoxes[t].Text != "")
            {
                詳細画面 dlg = new 詳細画面(t, ids[t]);
                dlg.ShowDialog(this);
                ActiveControl = null;
            }
            else
            {
                t = 15;
                詳細画面 dlg = new 詳細画面(t, ids[0]);
                dlg.ShowDialog(this);
                ActiveControl = null;
            }
            Redisplay();
        }

        public void Redisplay ()
        {
            int j = 0;
            while (j != 15)
            {
                textBoxes[j].Text = "";
                j += 1;
            }
            j = 0;
            string a = urlchangecombo.Text;
            string b = datecombo.Text;
            string c = wordtext.Text;
            string url = "";
            string date = "";
            string word = "";
            string where = "";
            string d = "";
            string g = "";
            string f = "";
            if (a != "")
            {
                if (a != "　　　　　　　　　　　URL")
                {
                    url = $" url = '{a}'";
                }
            }
            if (b != "")
            {
                date = $" acquisition_date = '{b}'";
            }
            if (c != "")
            {
                word = $" main_text like '%{c}%'";
            }
            string read = "";
            if (radioButton1.Checked == true)
            {
                read = " alreadyread_flag = 1";
            }
            if (radioButton2.Checked == true)
            {
                read = " alreadyread_flag = 0";
            }
            if (radioButton3.Checked == true)
            {
                read = "";
            }
            if (url != "" || date != "" || word != "" || read != "")
            {
                where = "where";
            }
            if (date != "")
            {
                if (url != "")
                {
                    d = "and";
                }
            }
            if (word != "")
            {
                if (url != "")
                {
                    g = "and";
                }
                if (date != "")
                {
                    g = "and";
                }
            }
            if (read != "")
            {
                if (url != "")
                {
                    f = "and";
                }
                if (date != "")
                {
                    f = "and";
                }
                if (word != "")
                {
                    f = "and";
                }
            }
            var command = new MySqlCommand($"select news_info.id,acquisition_date,url.url,main_text,alreadyread_flag from news_info inner join url on news_info.url_id = url.id {where} {url} {d} {date} {g} {word} {f} {read} order by acquisition_date desc;", con);
            var reader = command.ExecuteReader();
            while (reader.Read() && j != 15)
            {
                textBoxes[j].Text = Convert.ToDateTime(reader["acquisition_date"]).ToString("yyyy/MM/dd");
                ids[j] = $"{reader["id"]}";
                if (Convert.ToBoolean(reader["alreadyread_flag"]) == true)
                {
                    textBoxes[j].Text += "\t 既読\r\n";
                }
                else
                {
                    textBoxes[j].Text += "\t 未読\r\n";
                }
                textBoxes[j].Text += $"{reader["url"]}\r\n";
                Regex reg1 = new Regex("<title>", RegexOptions.IgnoreCase);
                title1 = reg1.Match(reader["main_text"].ToString());
                if (title1.Success == true)
                {
                    Regex reg2 = new Regex("</title>", RegexOptions.IgnoreCase);
                    title2 = reg2.Match(reader["main_text"].ToString());
                    title3 = title2.Index - title1.Index;
                    title = reader["main_text"].ToString().Substring(title1.Index + 7, title3 - 7);
                    textBoxes[j].Text += $"{title}";
                }
                else
                {
                    textBoxes[j].Text += "タイトルが見つかりませんでした。";
                }
                j += 1;
            }
            url = ""; word = ""; date = ""; read = ""; a = ""; b = ""; c = ""; where = ""; d = ""; g = ""; f = "";
            reader.Close();
        }

        private void redisplaybutton_Click(object sender, EventArgs e)
        {
            Redisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            Next_page();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Back_page();
        }

        private void lastpageButton_Click(object sender, EventArgs e)
        {
            backButton.Enabled = true;
            firstpageButton.Enabled = true;
            max = Page_check();
            int j = 0;
            while (j != 15)
            {
                textBoxes[j].Text = "";
                j += 1;
            }
            p = max;
            page = (p - 1) * 15;
            Text_display(page);
            pageBar.Value = max;
            nextButton.Enabled = false;
            lastpageButton.Enabled = false;
        }

        private void firstpageButton_Click(object sender, EventArgs e)
        {

            nextButton.Enabled = true;
            lastpageButton.Enabled = true;
            max = Page_check();
            int j = 0;
            while (j != 15)
            {
                textBoxes[j].Text = "";
                j += 1;
            }
            p = 1;
            page = (p - 1) * 15;
            Text_display(page);
            pageBar.Value = p;
            backButton.Enabled = false;
            firstpageButton.Enabled = false;
        }

    }
}