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

namespace WpfApp1
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

        private void Btn_Test_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello github!");
            //12：20
        }

        private void btn_Test1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("笔记本！");
            //最新14：33
        }

        private void Btn_Test2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("我来自笔记本！20200317，14：55");
        }
    }
}
