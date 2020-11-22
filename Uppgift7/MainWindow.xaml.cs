﻿using System;
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

namespace Uppgift7
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
            double tal1 = double.Parse(tal1Box.Text);
            double tal2 = double.Parse(tal2Box.Text);

            double summa = Math.Floor(tal1 / tal2);
            double rest = tal1 % tal2;
            heltalBox.Text = Convert.ToString(summa);
            restBox.Text = Convert.ToString(rest);
        }
    }
}
