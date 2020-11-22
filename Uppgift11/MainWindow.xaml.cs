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

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void startaBtn_Click(object sender, RoutedEventArgs e)
        {
            int antalförsök = int.Parse(antalTxt.Text);
            int rätt = 0;
            int fel = 0;
            int luck = Convert.ToInt32(progressBar.Value);
            for (int i = 0; i < antalförsök; i++)
            {
                int random1 = random.Next(1, 101);
                if (random1 > luck)
                {
                    rätt++;
                }
                else
                {
                    fel++;
                }
            }
            rättLbl.Content = rätt;
            felLbl.Content = fel;
        }

        private void mindreBtn_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value -= 5;
            procentLbl1.Content = ($"{progressBar.Value} %");
            procentLbl2.Content = ($"{progressBar.Value} %");
        }

        private void merBtn_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value += 5;
            procentLbl1.Content = ($"{progressBar.Value} %");
            procentLbl2.Content = ($"{progressBar.Value} %");
        }
    }
}