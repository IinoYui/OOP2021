using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            switch (HyouziBox.Text)
            {
                case "前橋":
                    num = 4210;
                    break;
                case "みなかみ":
                    num = 4220;
                    break;
                case "宇都宮":
                    num = 4110;
                    break;
                case "水戸":
                    num = 4010;
                    break;
            }

            var results = GetWeatherReportFromYahoo(num);
            foreach (var s in results)
            {
                Tiiki.Text += s + "\r\n";
            }
        }

        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
            using (var wc = new WebClient())
            {

            }
        }

    }
}
