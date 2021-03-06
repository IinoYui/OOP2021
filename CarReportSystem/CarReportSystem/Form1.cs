using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class FormMain : System.Windows.Forms.Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public FormMain() {
            InitializeComponent();
            dgvRegistDate.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();  //アプリケーション終了
        }

        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //追加ボタン
        private void btDateAdd_Click(object sender, EventArgs e) {

            if(cbAuther.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力されていません");
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuther.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.ValueMember,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };

            listCarReport.Add(carReport);  //1レコード追加

            setCbAuthor(cbAuther.Text);
            setCbCarName(cbCarName.Text);
        }

        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string auther) {
            if (cbAuther.Items.Contains(auther)) {
                cbAuther.Items.Add(auther);
            }
        }

        //コンボボックスに車名をセットする
        private void setCbCarName(string carname) {
            if (cbCarName.Items.Contains(cbAuther)) {
                cbCarName.Items.Add(carname);
            }
        }

        private void dgvRegistDate_MouseClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;
        
            //選択された行のデータの取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            //取得しているデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuther.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }
        

        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外車:
                    rbImport.Checked = true;
                    break;
                default:  //その他
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btDateDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt( dgvRegistDate.CurrentRow.Index);
        }

        private void btDateCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistDate.CurrentRow.Index].UpDate(dtpDate.Value, cbAuther.Text, 
                                    selectedGroup(),cbCarName.Text,
                                    tbReport.Text,pbPicture.Image);

            dgvRegistDate.Refresh();   //コントロールの強制再評価
        }

        private void btSave_Click(object sender, EventArgs e) {
            if(sfdFileSave.ShowDialog() == DialogResult.OK) {
                var bf = new BinaryFormatter();
                using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                    bf.Serialize(fs, listCarReport);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if(ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistDate.DataSource = null;
                        dgvRegistDate.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                //読み込んだデータを各コンボボックスに登録する
                foreach(var item in listCarReport) {
                    setCbAuthor(item.Auther);
                    setCbCarName(item.CarName);
                }

                /*　データグリッドビューから取得
                for(int i = 0; i < length; i++) {
                    setCbAuthor(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                    setCbCarName(dgvRegidtData.Rows[i].Cells[3].Value.ToString());
                }*/
            }
        }

        private void FormMain_Load(object sender, EventArgs e) {
            dgvRegistDate.Columns[5].Visible = false;
        }
    }
}

