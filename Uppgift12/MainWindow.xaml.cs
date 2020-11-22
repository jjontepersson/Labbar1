using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] numarray;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void okBtn_Click(object sender, RoutedEventArgs e)
        {
            double num;
            num = double.Parse(mataBox.Text);
            listaNr.Items.Add(num);
            numarray = new double[listaNr.Items.Count];
            for (int x = 0; x < listaNr.Items.Count; x++) 
            {
                num = double.Parse(listaNr.Items[x].ToString());
                numarray[x] = num;
            }
            double sum, avarage;
            sum = 0;
            if (numarray.Length == 5)
            {
                for (int x = 0; x < numarray.Length; x++)
                {
                    sum = sum + numarray[x];
                    avarage = sum / numarray.Length;
                    medelTxt.Text = avarage.ToString();
                }
                okBtn.IsEnabled = false;
            }
        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {
            mataBox.Text = null;
            medelTxt.Text = null;
            listaNr.Items.Clear();
            numarray1();
            mataBox.Focus();

        }
        public void numarray1()
        {
            Array.Clear(numarray, 0, numarray.Length);
        }
    }
}
