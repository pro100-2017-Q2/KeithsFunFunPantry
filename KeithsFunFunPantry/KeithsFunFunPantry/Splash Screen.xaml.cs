﻿using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace KeithsFunFunPantry
{
    /// <summary>
    /// Interaction logic for Splash_Screen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        MainWindow m = new MainWindow();
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Move(Object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m.Show();
            this.Close();
        }
    }
}