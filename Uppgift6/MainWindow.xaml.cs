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

namespace Uppgift6
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = double.Parse(txt1.Text);
            double tal2 = double.Parse(txt2.Text);
            double summabox = (tal1 + tal2);
            txt3.Text = Convert.ToString(summabox);
            resultatLbl.Content = ("Summa");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double tal1 = double.Parse(txt1.Text);
            double tal2 = double.Parse(txt2.Text);
            double summabox = (tal1 - tal2);
            txt3.Text = Convert.ToString(summabox);
            resultatLbl.Content = ("Differens");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double tal1 = double.Parse(txt1.Text);
            double tal2 = double.Parse(txt2.Text);
            double summabox = (tal1 * tal2);
            txt3.Text = Convert.ToString(summabox);
            resultatLbl.Content = ("Produkt");
        }

        private void divKnp_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = double.Parse(txt1.Text);
            double tal2 = double.Parse(txt2.Text);
            double summabox = (tal1 / tal2);
            txt3.Text = Convert.ToString(summabox);
            resultatLbl.Content = ("Kvot");
        }

        private void rensaKnp_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            resultatLbl.Content = ("Resultat");
        }
    }
}
