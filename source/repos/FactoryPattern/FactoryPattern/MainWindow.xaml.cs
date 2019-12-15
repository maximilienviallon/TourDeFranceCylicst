﻿using FactoryPattern.Model;
using FactoryPattern.ViewModel;
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

namespace FactoryPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        List<Folder> dataList = new List<Folder>();
        DataFetcherFolder dff = new DataFetcherFolder();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
               dataList = dff.fetchFolder();
               ListView1.ItemsSource = dataList;
        }
    }
}
