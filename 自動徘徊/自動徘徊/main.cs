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

namespace 自動徘徊
{
    public partial class main : Form
    {
        private TextBox[] textBoxes;
        MySqlConnection con = new MySqlConnection("server=localhost;user=fsst;password=2455;database=jjdb;");
        int j = new int();

        public main()
        {
            InitializeComponent();

        }

        private void unread_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
            textBoxes = new TextBox[]
              {textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8,
                textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15};
            con.Open();
            var command = new MySqlCommand("select acquisition_date, url, main_text,alreadyread_flag from news_info;", con);
            var reader = command.ExecuteReader();
            while (reader.Read() && j != 15)
            {
                textBoxes[j].Text = Convert.ToDateTime(reader["acquisition_date"]).ToString("yyyy/MM/dd");    //日付
                if (Convert.ToBoolean(reader["alreadyread_flag"]) == true)                                    //既読未読
                {
                    textBoxes[j].Text += "\t 既読\r\n";
                }
                else
                {
                    textBoxes[j].Text += "\t 未読\r\n";
                }
                textBoxes[j].Text += $"{reader["url"]}\r\n";                                                 //URL
                textBoxes[j].Text += $"\r\n{reader["main_text"]}";                                           //本文
                j += 1;
            }
        }

        private void urlchangecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdOpenDlg2_Click(object sender, EventArgs e)
        {

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
    }
}
