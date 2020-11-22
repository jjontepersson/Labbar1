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

namespace Uppgift9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool adultCheck = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void radioBtn1_Checked(object sender, RoutedEventArgs e)
        {
            adultCheck = true;
        }
        private void radioBtn2_Checked(object sender, RoutedEventArgs e)
        {
            adultCheck = false;
        }

        private void kontrolleraKnapp_Click(object sender, RoutedEventArgs e)
        {
            int åldersBox = int.Parse(ålderBox.Text);
            if (adultCheck == true)
            {
                if (åldersBox <= 7)
                {
                    labelText.Content = $"Hej {namnBox.Text} du är {ålderBox.Text} år och får se filmer som är barnvänliga oavsett om du har vuxen med eller ej";
                }
                else if (åldersBox >= 7 && åldersBox <= 11)
                {
                    labelText.Content = $"Hej {namnBox.Text} du är {ålderBox.Text} år och får se filmer med åldersgräns 11 år eftersom du har med en vuxen";
                }
                else if (åldersBox >= 11 && åldersBox <= 15)
                {
                    labelText.Content = $"Hej {namnBox.Text} du är {ålderBox.Text} år och får se filmer med åldersgräns 15 år även om du har med en vuxen";
                }
                else if (åldersBox >= 15)
                {
                    labelText.Content = $"Hej {namnBox.Text} du är {ålderBox.Text} år och får se alla filmer, du behöver inte ha med en vuxen för någon film";
                }
                else
                {
                    return;
                }
                
            }
            else if (adultCheck == false)
            {
                if (åldersBox <= 7)
                {
                    labelText.Content = $"Hej {namnBox.Text} du är {ålderBox.Text} år och får se filmer som är barnvänliga filmer och du har ingen vuxen med dig";
                }
                else if (åldersBox >= 7 && åldersBox <= 11)
                {
                    labelText.Content = $"Hej {namnBox.Text} du är {ålderBox.Text} år och får se filmer med åldersgräns 7 år eftersom du inte har med dig en vuxen";
                }
                else if (åldersBox >= 11 && åldersBox <= 15)
                {
                    labelText.Content = $"Hej {namnBox.Text} du är {ålderBox.Text} år och får se filmer med åldersgräns 15 år och har ingen vuxen med dig";
                }
                else if (åldersBox >= 15)
                {
                    labelText.Content = $"Hej {namnBox.Text} du är {ålderBox.Text} år och får se alla filmer";
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }


        }
    }
}
