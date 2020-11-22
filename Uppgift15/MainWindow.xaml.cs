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

namespace Uppgift15
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
       
        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            rotLbl.Content = Convert(txtGrund.Text);
            antalLbl.Content = VowelsCounter(txtGrund.Text);
        }
       
        public int VowelsCounter(string vowelsCount)
        {
            int vowelsCounter = 0;
            foreach (char b in vowelsCount)
               
                if (isVowel(b))
                {
                    vowelsCounter++;
                }
            return vowelsCounter;
        }
        
        public string Convert(string letters)
        {
            string newText = "";
            foreach (char b in letters)
            {
                if (isVowel(b))
                {
                    if(Char.IsUpper(b))
                    {
                        newText += "Ö";
                    }
                    else
                    {
                      newText += "ö";
                    }
                }
                else
                {
                    newText += b.ToString();
                }
            }
            return newText;
        }
       
        public bool isVowel(char letters)
        {
            char[] letter = new char[]
            {
                'a','e','i','o','u','y','å','ä','ö','A','E','I','O','U','Y','Å','Ä','Ö'
            };
            for (int i = 0; i < letter.Length; i++) ;
            if (letter.Contains(letters))
            {
                return true;
            }
            return false;
        }

    
    }
}
