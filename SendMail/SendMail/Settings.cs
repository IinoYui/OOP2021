using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    class Settings
    {
        private static Settings instance = null;

        public int Port { get; set; }   //ポート番号
        public string Host { get; set; }   //ホスト名
        public string MailAddr { get; set; }   //メールアドレス
        public string Pass { get; set; }   //パスワード
        public bool Ssl { get; set; }   //SSL

        //コンストラクタ
        private Settings()
        {
        
        }

        //インストラクタの取得
        public static Settings getInstance()
        {
            try
            {
                if (instance == null)
                {
                    instance = new Settings();


                    //XMLファイルを読み込み（逆シリアル化）【P303参照】
                    using (var reader = XmlReader.Create("mailsetting.xml"))
                    {
                        var serializer = new DataContractSerializer(typeof(Settings));
                        var readSettings = serializer.ReadObject(reader) as Settings;

                        instance.Host = readSettings.Host;
                        instance.Port = readSettings.Port;
                        instance.MailAddr = readSettings.MailAddr;
                        instance.Pass = readSettings.Pass;
                        instance.Ssl = readSettings.Ssl;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return instance;
        }

        //送信データ登録 (インターフェース)
        public void setSendConfig(string host, int port, string mailaddr, string pass, bool ssl)
        {
            Host = host;
            Pass = pass;
            MailAddr = mailaddr;
            Port = port;
            Ssl = ssl;

            //XMLファイルへ書き出し（シリアル化）【P302参照】
            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("mailsetting.xml", xws))
            {
                var serializer = new DataContractSerializer(this.GetType());
                serializer.WriteObject(writer, this);
            }
            
        }

        //初期値
        public string sHost()
        {
            return "smtp.gmail.com";
        }

        public string sPort()
        {
            return 587.ToString();
        }

        public string sMailAddr()
        {
            return "ojsinfosys@gmail.com";
        }

        public string sPass()
        {
            return "😀😀😀😀😀😀😀😀😀😀😀";
        }

        public bool bSsl()
        {
            return true;
        }

    }
}
