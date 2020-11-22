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

namespace Uppgift3
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

        private void knapp1_Click(object sender, RoutedEventArgs e)
        {
            if (knapp1.Content == "Oklickad")
            {
                knapp1.Content = "Klickad";
            }
            else { knapp1.Content = "Oklickad"; }
        }

        private void knapp2_Click(object sender, RoutedEventArgs e)
        {
            if (knapp2.Content == "Oklickad")
            {
                knapp2.Content = "klickad";
            }
            else { knapp2.Content = "Oklickad"; }
        }
    }
}
