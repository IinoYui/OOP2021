using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            var inputToday = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value);
            DayOfWeek dayOfWeek = today.DayOfWeek;

            string dow = "";
            //曜日
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日です＾W＾";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日です >m<";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日です o_o";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日です p_p";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日です =o=";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日です OwO";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日です＾W＾";
                    break;
            }
             tbOutput.Text = "今日は" + dow;
            
            

            //閏年判定
            var isLeapYear = DateTime.IsLeapYear((int)nudYear.Value);
            if (isLeapYear)
                tbLeapYear.Text = "閏年です";
            else
                tbLeapYear.Text = "閏年ではありません";


            //日数を求める
            TimeSpan diff = today.Date - inputToday.Date;
            tbOutput.Text = diff.Days + "日間";


            tbOutput.Text = GetAge(dtpDateTime.Value, today).ToString();
        
        }
            //年齢を求める
            public int GetAge(DateTime birthday, DateTime targetDay) {
                var age = targetDay.Year - birthday.Year;
                if (targetDay < birthday.AddYears(age)) {
                    age--;
                }
                return age;
            }

    }
}
