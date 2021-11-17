using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int rand = 0;
        public MainWindow()
        {
            InitializeComponent();
            random(1, 26);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = e.Source as Button;
            bt.Background = Brushes.Aquamarine;

            var count = int.Parse(((Button)sender).Content.ToString());

            if (count < rand)
            {
                //大きい場合
                this.comment.Text = "もっと大きいよ😀";
            }
            else if (count > rand)
            {
                //小さい場合
                this.comment.Text = "もっと小さいよ😖";
            }
            else if (count == rand)
            {
                //値が一緒の場合
                this.comment.Text = "せーかい";
            }
        }
        
        public void random(int min, int max)
        {
            Random r1 = new System.Random();
            rand = r1.Next(min, max);
        }
    

    }
}
