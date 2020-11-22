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

namespace Uppgift5
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
            int nummer1 = int.Parse(txt1.Text);
            int nummer2 = int.Parse(txt2.Text);
            int Summa = nummer1 + nummer2;
            txt3.Text = Convert.ToString(Summa);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
        }
    }
}
