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
        //private bool limit_flag = true;        ///リミットフラグくん
        public bool limit_flag = true;
        public int count = 3;                  ///作った本人がよくわからないcountくん
        List<string> listPKey = new List<string>(); /// listPKey = listProdKeyくん　ﾌﾟﾛﾀﾞｸﾄｷｰの正解群みたいなｻﾑｼﾝｸﾞ
        const string syamei = "SOFTWARE\\Loitering_Bashou\\JidouHaikai";


        ///string[] a; 


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
            var command = new MySqlCommand("select acquisition_date, url_id, main_text,alreadyread_flag from news_info;", con);
            var reader = command.ExecuteReader();
            while (reader.Read() && j != 9)
            {
                textBoxes[j].Text = $"{reader["acquisition_date"]}{reader["alreadyread_flag"]} \r\n{reader["url_id"]} \r\n{reader["main_text"]}";
                j += 1;
            }
            reader.Close();
            listPKey.Add("5555555555555555555555555");
            //if (Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\_Loitering_Bashou\\JidouHaikai", false) ==)
            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(syamei, false);
            if (regkey == null) return;
            int intValue = (int)regkey.GetValue("int");
            regkey.Close();
            if(intValue == 1)
            {
                limit_flag = false;
                cmdOpenDlg4.Enabled = false;
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
            dlg.ShowDialog(this);
        }

        private void cmdOpenDlg3_Click(object sender, EventArgs e)
        {
            Help dlg = new Help();
            dlg.ShowDialog();
        }

        private void cmdOpenDlg4_Click(object sender, EventArgs e)
        {
            //if (dlg.ShowDialog() == DialogResult.OK)
            //   limit_flag = true;
            KeepOut dlg = new KeepOut();
            DialogResult dr = dlg.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                limit_flag = false;
                Microsoft.Win32.RegistryKey regkey= Microsoft.Win32.Registry.LocalMachine.CreateSubKey(syamei);
                regkey.SetValue("int",1);
                cmdOpenDlg4.Enabled = false;
            }
        }

        private void cmdOpenDlg5_Click(object sender, EventArgs e)
        {
            Time dlg = new Time();
            dlg.ShowDialog(this);
        }
        
        public bool Getlimit_flag()
        {
            return limit_flag;
        }
        public int GetURLCount()
        {
            if (limit_flag == true)
            {
                return count;
            }
            else
            {
                return -1;
            }
            
        }
        public bool IsContainPKey(string PK)
        {
            for (int i = 0; i < listPKey.Count; i++)
            {
                if(PK == listPKey[i])
                {
                    return true;
                }
            }
 
            return false;


        }


        public MySqlConnection GetConnection()
        {
            return con;
        }
    }
}