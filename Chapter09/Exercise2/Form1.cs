using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//問題9.2
namespace Exercise2 {
    public partial class Form1 : Form {
        private string inputPath = "";   //変換ファイル（読み込むファイル）
        private string outputPath = "";   //変換先ファイル

        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
                inputPath = ofdOpenFile.FileName;
            }
        }

        //変換したファイルの保存先を指定
        private void btChange_Click(object sender, EventArgs e) {
            if(sfdSaveFile.ShowDialog() == DialogResult.OK) {
                outputPath = sfdSaveFile.FileName;
            }
        }

        //行番号を追加する処理
        private void btPlus_Click(object sender, EventArgs e) {
            var line = File.ReadLines(inputPath).Select((s, ix) => String.Format("{0,4}:{1}", ix + 1, s)).ToArray();
            File.WriteAllLines(outputPath, line);

        }
    }
}
