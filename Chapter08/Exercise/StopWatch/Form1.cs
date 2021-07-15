using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {

        //時間計測のストップウィッチオブジェクト
        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            ldTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");

        }

        private void Tm_Tick(object sender, EventArgs e) {
            ldTimerDisp.Text = DateTime.Today.ToString();

        }
        
        private void Startbt_Click(object sender, EventArgs e) {
            sw.Start();   //ストップウォッチスタート
            tmdisp.Start();  //画面更新用のタイマースタート
        }

        private void Resetbt_Click(object sender, EventArgs e) {
            sw.Reset();  //画面更新用のタイマーリセット
            ldTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");

        }

        private void Stopbt_Click(object sender, EventArgs e) {
            sw.Stop();   //ストップウォッチストップ
            tmdisp.Stop();  //画面更新用のタイマーストップ
        }

        private void Lapbt_Click(object sender, EventArgs e) {
            ldLapDisp.Items.Insert(0, ldTimerDisp.Text);
        }

        private void tmdisp_Tick(object sender, EventArgs e) {
            ldTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");

        }
    }
}
