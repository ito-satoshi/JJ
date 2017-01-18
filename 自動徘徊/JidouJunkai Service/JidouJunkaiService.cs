using System;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Timers;
using MySql.Data.MySqlClient;
using System.Net.Http;

namespace JidouJunkai_Service
{
    public partial class JidouJunkaiService : ServiceBase
    {
        static MySqlConnection con = new MySqlConnection("server=localhost;user=fsst;password=2455;database=jjdb;");
        static string text;
        static string[] url;
        static int j;
        static Timer timer;
        public JidouJunkaiService()
        {
            InitializeComponent();
        }

        public static void OnElapsed_TimersTimer(object sender, ElapsedEventArgs e)
        {
            News_check();
        }

        public static void News_check()
        {
            for (int t = 1; j + 1 > t; t++)
            {
                var command = new MySqlCommand($"select main_text from news_info where url_id = {t} order by acquisition_date desc limit 1;", con);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    text = $"{reader["main_text"]}";
                }
                reader.Close();
                Uri webUri = new Uri(url[t - 1]);
                Task<string> webTask = GetWebPageAsync(webUri);
                webTask.Wait();
                string result = webTask.Result;
                if (result != null)
                {
                    result = result.Replace("\"", "\\\"");
                    result = result.Replace("\'", "\\\'");
                    if (result != text)
                    {
                        DateTime dt = DateTime.Now;
                        string date = dt.ToString("yyyy-MM-dd-hh-mm-ss");
                        command = new MySqlCommand($"insert into news_info (acquisition_date,url_id,main_text,alreadyread_flag) values ('{date}','{t}','{result}',0);", con);
                        command.ExecuteNonQuery();
                        Console.WriteLine($"{date}");
                        Console.WriteLine("更新しました");
                    }
                    else
                    {
                        Console.WriteLine("最新の状態です");
                    }
                }
            }

        }

        static async Task<string> GetWebPageAsync(Uri uri)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add(
                    "User-Agent",
                    "Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko");
                client.DefaultRequestHeaders.Add("Accept-Language", "ja-JP");
                client.Timeout = TimeSpan.FromSeconds(10.0);

                try
                {
                    return await client.GetStringAsync(uri);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\n例外発生");
                    Exception ex = e;
                    while (ex != null)
                    {
                        Console.WriteLine("例外メッセージ: {0} ", ex.Message);
                        ex = ex.InnerException;
                    }
                }
                catch (TaskCanceledException e)
                {
                    Console.WriteLine("\nタイムアウト");
                    Console.WriteLine("例外メッセージ: {0} ", e.Message);
                }
                return null;
            }
        }

        public static void Run()
        {
            News_check();
            var command = new MySqlCommand("select acquisition_interval from acquisition_interval;", con);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                timer = new Timer(int.Parse(reader["acquisition_interval"].ToString()));
            }
            timer.Elapsed += OnElapsed_TimersTimer;
            reader.Close();
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        protected override void OnStart(string[] args)
        {
            time.Enabled = true;
            con.Open();
            var command = new MySqlCommand("select count(*) from url where delete_flag = 0;", con);
            object o = command.ExecuteScalar();
            Array.Resize(ref url, int.Parse(o.ToString()));
            command = new MySqlCommand("select url from url where delete_flag = 0;", con);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                url[j] = $"{reader["url"]}";
                j += 1;
            }
            reader.Close();
            Run();
            timer.Stop();
            timer.Dispose();
        }


        protected override void OnStop()
        {
            time.Enabled = false;
        }
    }
}
