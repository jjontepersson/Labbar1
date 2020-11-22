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

namespace Uppgift13
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

            int lettercount = 0;
       
       
        private void countBtn_Click(object sender, RoutedEventArgs e)
        {
            
            char textbox = Convert.ToChar(searchTxt.Text);
            char[] text = new char[txtBox.Text.Length];
            text = txtBox.Text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == textbox)
                {
                    lettercount++;
                }
            }
                resultLbl.Content = $" Hittade bokstaven {textbox} {lettercount} gånger i texten";
             lettercount = 0;
        }
    }
}
