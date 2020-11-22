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

namespace Uppgift14
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
            if (LetterLooker() == false)
            {
                MessageBox.Show("Gör om gör rätt, bara siffror!!! ");
            }
            else
            {
                int birthyear = int.Parse(txtYear.Text);
                MessageBox.Show($"Du är {YearsOld(birthyear)} år gammal");
            }

        }
        public int YearsOld( int birthyear)
        {
            int  date = DateTime.Now.Year;
            int age = date - birthyear;
            return age;
        }
        public bool  LetterLooker()
        {
            char[] text = new char[txtYear.Text.Length];
            text = txtYear.Text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {      
            if ( char.IsLetter(text[i]))
            {
                return false;
            }
       
            }
                return true;
        }
    }
}
