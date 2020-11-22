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

namespace Uppgift10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
   
    {
        public MainWindow()
        {
            InitializeComponent();
            gissaKnapp.IsEnabled = false;
        }
        int gissningar = 0;
        Random random = new Random();
        int randomNumber;
        
       
        public void slumpaKnapp_Click(object sender, RoutedEventArgs e)
        {

            
            randomNumber = random.Next(1001);
            gissaKnapp.IsEnabled = true;
        }

        private void gissaKnapp_Click(object sender, RoutedEventArgs e)
        {

            int guess = int.Parse(gissaBox.Text);
            gissningar++;
            if (guess == randomNumber)
            {
                label1.Content = ($"Grattis din jävel dina antal gissningar är {gissningar}");
            }
            else if (guess < randomNumber - 100)
            {
                label1.Content = ("Du har gissat på ett alldeles för lågt nummer, fortsätt gissa");
            }
            else if (guess > randomNumber + 100)
            {
                label1.Content = ("Du har gissat på ett alldeles för högt nummer, fortsätt gissa");
            }
            else if (guess < randomNumber)
            {
                label1.Content = ("Börjar närma dig men du är fortfarande för lågt");
            }
            else if (guess > randomNumber)
            {
                label1.Content = ("Börjar närma dig men du är fortfarande för högt");
            }

            
           
        }
    }
}
