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
                this.textBoxes = new TextBox[]
                {this.textBox1, this.textBox2, this.textBox3, this.textBox4, this.textBox5, this.textBox6, this.textBox7, this.textBox8, this.textBox9};
                con.Open();
            var command = new MySqlCommand("select acquisition_date, url, main_text,alreadyread_flag from news_info;", con);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBoxes[j].Text = $"{reader["acquisition_date"]}{reader["alreadyread_flag"]} \r\n{reader["url"]} \r\n{reader["main_text"]}";
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
