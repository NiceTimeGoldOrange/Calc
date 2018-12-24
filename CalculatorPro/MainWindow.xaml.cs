using Cal_ViewModel;
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
        private void Max_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {   //窗口还原
                this.WindowState = WindowState.Normal;
                this.Max.Content = "☐";
            }
            else
            {   //窗口最大化
                this.WindowState = WindowState.Maximized;
                this.Max.Content = "❐";
            }
        }
        private void Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }



    }
}
