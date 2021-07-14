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

namespace Steam_Investor_App.Views
{
    /// <summary>
    /// Interaktionslogik für help.xaml
    /// </summary>
    public partial class help : UserControl
    {
        public help()
        {
            InitializeComponent();
        }

        private void Discord_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/eWvVkaS");
        }

        private void Github_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Shynex/Steam-Investor");
        }

        private void Steam_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/id/Shynex/");
        }
    }
}
