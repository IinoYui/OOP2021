using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class ConfigForm : Form
    {

        //設定情報
        private Settings settings = Settings.getInstance();

        public ConfigForm()
        {
            InitializeComponent();
        }

        //デフォルトボタン
        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text = settings.sHost();//ホスト
            tbPass.Text = settings.sPass();//パスワード
            tbPort.Text = settings.sPort(); //ポート
            tbUserName.Text = settings.sMailAddr();//ユーザー名
            cbSsl.Checked = settings.bSsl(); //SSL
            tbSender.Text = settings.sMailAddr();//送信元

            //tbUserName.Text = settings.sUserName();
        }

        //キャンセルボタン
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //OKボタン
        private void btOk_Click(object sender, EventArgs e)
        {
            this.btApply_Click(sender, e);
            this.Close();
        }

        //適用ボタン
        private void btApply_Click(object sender, EventArgs e)
        {
            try
            {
                settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //SettingRegist();//送信データ登録
        }
    

        //送信データ登録
        private void SettingRegist()
        {
            
        }

        //設定画面をロードすると一度だけ実行されるイベントハンドラ
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAddr;
        }
    }
}
