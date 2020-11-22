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

namespace Uppgift8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void konverteraBox_Click(object sender, RoutedEventArgs e)
        {
            double galleoner = double.Parse(gall.Text);
            double siklar = double.Parse(sik.Text);
            double knutingar = double.Parse(knut.Text);
            double resultat = (62.02 * galleoner) + (62.02 / 17 * siklar) + (62.02 / 493 * knutingar);
            labelKonvert.Content = Convert.ToString(Math.Round(resultat));
        }
    }
}
