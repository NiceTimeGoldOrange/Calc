﻿using Cal_ViewModel;
using CalculatorPro.View;
using MahApps.Metro.Controls;
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

namespace CalculatorPro
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new CalViewModel();
            this.SizeChanged += new System.Windows.SizeChangedEventHandler(MainWindow_Resize);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void TitleMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void HisDisplay_Click(object sender, RoutedEventArgs e)
        {

            this.hisFlyout.Visibility = Visibility.Visible;
            this.hisFlyout.Height = this.OutGrid.ActualHeight;
            //判读用户控件是否打开
            if (!this.hisFlyout.IsOpen)
            {
                this.hisFlyout.IsOpen = true;

            }
        }

        private void MemDisplay_Click(object sender, RoutedEventArgs e)
        {
            this.memFlyout.Visibility = Visibility.Visible;
            this.memFlyout.Height = this.OutGrid.ActualHeight;
            //判读用户控件是否打开
            if (!this.memFlyout.IsOpen)
            {
                this.memFlyout.IsOpen = true;

            }
        }
        MaxUniform mu = new MaxUniform();
        private void Max_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {   //窗口还原
                this.WindowState = WindowState.Normal;
                this.Max.Content = "☐";
                OutGrid.Children.Remove(mu);
                uniformNum.Visibility = Visibility.Visible;
                
            }
            else
            {   //窗口最大化
                this.WindowState = WindowState.Maximized;
                this.Max.Content = "❐";
                uniformNum.Visibility = Visibility.Collapsed;
                OutGrid.Children.Add(mu);
                
            }
        }
        private void Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
            
        }


        HisAndMemDis ham = new HisAndMemDis();
        ColumnDefinition col = new ColumnDefinition();
        bool flag = false;
        
        private void MainWindow_Resize(object sender, System.EventArgs e)
        { 
            
            if ( Window.ActualWidth > 563 && !flag)
            {
                //添加新定义的一行
                AllGrid.ColumnDefinitions.Add(col);
                //将自定义标题栏与用户控件合并行
                TitleBar.SetValue(Grid.ColumnSpanProperty, 3);
                AllGrid.Children.Add(ham);
                ham.SetValue(Grid.RowProperty, 1);
                ham.SetValue(Grid.RowSpanProperty, 6);
                ham.SetValue(Grid.ColumnProperty, 2);
                col.Width = new GridLength(248.6);
                //col.MinWidth = 248.6;
                //col.MaxWidth = 330;
                btnM.Visibility = Visibility.Hidden;
                btnHis.Visibility = Visibility.Collapsed; 
                flag = true;
                uniformMem.Columns = 5;
            }
            if ( flag && Window.ActualWidth < 563)
            {
                AllGrid.ColumnDefinitions.RemoveAt(2);
                AllGrid.Children.Remove(ham);
                btnM.Visibility = Visibility.Visible;
                btnHis.Visibility = Visibility.Visible;
                uniformMem.Columns = 6;
                flag = false;
            }
            

        }
        int i = 0;
        private void MS_Click(object sender, RoutedEventArgs e)
        {
            i += 1;
            btnMc.Opacity = 1;
            btnMc.IsEnabled = true;
            btnM.Opacity = 1;
            btnM.IsEnabled = true;
            btnMr.Opacity = 1;
            btnMr.IsEnabled = true;
            MemControl mc = new MemControl();
            mc.Margin = new Thickness(-5);
            mc.txtMem.Text = txtBox.Text;
            if (i == 1)
            {
                ham.lstBoxMem.Items.RemoveAt(0);
            }
            ham.lstBoxMem.Items.Insert(0, mc);
            
            
         }
        //字体效果
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = txtBox.GetLineText(0);
            if (str.Length > 13 && str.Length<21)
            {
                txtBox.FontSize -= 3;
            }else if (str.Length <= 13)
            {
                txtBox.FontSize = 45;
            }
            
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
