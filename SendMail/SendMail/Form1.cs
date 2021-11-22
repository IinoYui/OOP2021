using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class Form1 : Form
    {
        //設定画面
        private ConfigForm configform = new ConfigForm();

        //設定情報
        private Settings settings = Settings.getInstance();

        public Form1()
        {
            //configform.ShowDialog();
            InitializeComponent();
        }

        //送信ボタン
        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress("ojsinfosys01@gmail.com");
                //宛先（Tb）
                mailMessage.To.Add(tbTo.Text);

                //CcBccは入力されていなかった時のプログラムを書く(if文を使う)
                if(tbCc.Text != "")
                {
                    mailMessage.To.Add(tbCc.Text);
                }

                if(tbBcc.Text != "")
                {
                    mailMessage.To.Add(tbBcc.Text);
                }


                //件名(タイトル)
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;


                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential("ojsinfosys01@gmail.com", "Infosys2021");

                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;

                //送信完了時に呼ばれるイベントハンドラの登録
                smtpClient.SendCompleted += SmtpClient_SendCompleted;

                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("送信完了");
            }
        }

        //設定ボタン
        private void btConfig_Click(object sender, EventArgs e)
        {
            new ConfigForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //XMLファイルを読み込み（逆シリアル化）【P303参照】
            //using (var reader = XmlReader.Create("mailsetting.xml"))
            //{
            //    var serializer = new DataContractSerializer(typeof(Settings));
            //    var readSettings = serializer.ReadObject(reader) as Settings;

            //    settings.Host = readSettings.Host;
            //    settings.Port = readSettings.Port;
            //    settings.MailAddr = readSettings.MailAddr;
            //    settings.Pass = readSettings.Pass;
            //    settings.Ssl = readSettings.Ssl;
            //}
        }
    }
}


