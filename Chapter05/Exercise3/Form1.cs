using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            inputStrDate.Text = "a";
        }
 
        //空白が何文字あるかカウントする
        private void button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(c => c == ' ');
            textBoxSpaceCount.Text = count.ToString();
        }

        //文字列の"big"という文字を"SMALL"に変換する
        private void button5_3__2_Click(object sender, EventArgs e) {
            var target = inputStrText.Text;
            var replaced = target.Replace("big", "SMALL");

            textBoxWordChange.Text = replaced.ToString();
        }

        //単語がいくつあるかカウントする
        private void button5_3_3_Click(object sender, EventArgs e) {
            textBoxWordCount.Text = inputStrText.Text.Split(' ').Length.ToString();
        }

        //４文字以下の単語を列挙する
        private void button5_3_4_Click(object sender, EventArgs e) {
            var Words = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach(var word in Words) {
                textBoxWordCount4.Text += word + " ";
            }
        }
        
        //たぶん連結させる
        private void button5_3_5_Click(object sender, EventArgs e) {
            var array = inputStrText.Text.Split(' ').ToArray();
            if (array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach(var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                textBoxWordRenketu.Text = sb.ToString();

            }
        }

        //文字列から出力を得るコンソールアプリケーションを作成する
        private void button5_4_Click(object sender, EventArgs e) {
            //Novelist = 谷崎潤一郎;
            //BestWork = 春琴炒；
            //Born ＝1886;
            foreach(var pair in inputStrDate.Text.Split(';')) {
                var array = pair.Split('=');
                outputStrDate.Text += ToJapanese(array[0]) + ":" + array[1] + "\n";
            }
        }


        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家 ";
                    
                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}
