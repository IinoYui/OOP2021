﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202113DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personDataGridView.Columns[0].Visible = false;
            personDataGridView.Columns[1].HeaderText = "名前";
            personDataGridView.Columns[2].HeaderText = "誕生日";
            personDataGridView.Columns[3].HeaderText = "電話番号";
            personDataGridView.Columns[4].HeaderText = "備考";

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202113DataSet.Person' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.personTableAdapter.Fill(this.infosys202113DataSet.Person);
        }

        private void btNameFilet_Click(object sender, EventArgs e)
        {
            this.personTableAdapter.FillByName(this.infosys202113DataSet.Person, tbNameSearch.Text);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            personDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            personDataGridView.CurrentRow.Cells[2].Value = dtpDate.Value;
            personDataGridView.CurrentRow.Cells[3].Value = tbTelephone.Text;
            personDataGridView.CurrentRow.Cells[4].Value = tbMemo.Text;


            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202113DataSet);
        }

        private void personDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //０件なら処理をしない
            if (personDataGridView.Rows.Count != 0)
            {
                tbName.Text = personDataGridView.CurrentRow.Cells[1].Value.ToString();  //名前
                dtpDate.Value = (DateTime)personDataGridView.CurrentRow.Cells[2].Value;  //誕生日
                tbTelephone.Text = personDataGridView.CurrentRow.Cells[3].Value.ToString();  //電話番号
                tbMemo.Text = personDataGridView.CurrentRow.Cells[4].Value.ToString();  //備考
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //this.personTableAdapter.FillByName(this.infosys202113DataSet.Person, dateTimePicker1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.personTableAdapter.FillByBirthday(this.infosys202113DataSet.Person, dateTimePicker1.Text);
        }
    }
}
