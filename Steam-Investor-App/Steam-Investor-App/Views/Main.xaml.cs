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
using DocumentFormat.OpenXml.Drawing.Charts;
using LiveCharts;
using LiveCharts.Wpf;
using Steam_Investor_App.Windows;

namespace Steam_Investor_App.Views
{
    /// <summary>
    /// Interaktionslogik für UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
           //this.pieChart();
            
            this.CartesianMonth();

        }
        //Cartesian chart

        

        public void CartesianMonth()
        {
            SeriesCollectionMonth = new SeriesCollection
            {
                new LineSeries
                {

                    Title="Profit", Values = new ChartValues<double>{ 232, 400, 600,500,300,234,232, 400, 600, 500, 300, 234, -232, 400, 600, 500, 300, 234, 232, 400, 600, 500, 300, 234, 232, 400, 600, 500, 300, 234, 232 }
                }

            };

            
            
            DataContext = this;
        }
        public Func<double, string> yFormatterMonth { get; set; }
        public SeriesCollection SeriesCollectionMonth { get; set; }
        public string[] Labels { get; set; }
        



        private void PieChart_DataClick(object sender, ChartPoint chartPoint)
        {

        }

        AddItem additem = null;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (additem == null)
            {
                AddItem additem = new AddItem();
                additem.Show();
            }
            else
            {
                additem.Activate();                
            }
            
        }
    }
}
