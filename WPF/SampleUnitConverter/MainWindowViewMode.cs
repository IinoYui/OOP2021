using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter
{
    public class MainWindowViewMode : ViewMode
    {
        private double metricValue;
        private double imperialValue;

        //▲ボタンで呼ばれるコマンド【ヤード単位からメートル単位】
        public ICommand ImperiaUnitToMetrix { get; private set; }
        //▼ボタンで呼ばれるコマンド【メートル単位からヤード単位】
        public ICommand MetricToImperialUnit { get; private set; }

        //上のComboBoxで選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }
        //下のComboBoxで選択されている値
        public ImperialUnit CurrentImperialUnit { get; set; }

        public double MetricValue
        {
            get { return this.metricValue; }
            set
            {
                this.metricValue = value;
                this.OnPropertyChanged();  //Viewへ通知
            }
        }

        public double ImperialValue
        {
            get { return this.metricValue; }
            set
            {
                this.metricValue = value;
                this.OnPropertyChanged();  //Viewへ通知
            }
        }

        //コンストラクタ
        public MainWindowViewMode()
        {
            this.CurrentImperialUnit = ImperialUnit.Units.First();  //メートル単位
            this.CurrentImperialUnit = ImperialUnit.Units.First();  //ヤード単位

            this.MetricToImperialUnit = 
                new DelegateCommand(
                () => this.imperialValue = 
                this.CurrentImperialUnit.FromMetricUnit(this.CurrentMetricUnit, this.MetricValue));
        }
    }
}
