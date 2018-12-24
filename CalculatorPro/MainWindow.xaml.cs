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

        private void MainWindow_Resize(object sender, System.EventArgs e)
        {
            Button btnHis = new Button();
            Button btnMem = new Button();
            if (AllGrid.ColumnDefinitions.Count < 2 && Window.ActualWidth > 563 )
            {       
                    btnHis.Name = "_btnHis";
                    btnMem.Name = "_btnMem";
                    btnHis.Content = "历史记录";
                    btnMem.Content = "内存";
                    btnHis.Width = 65;
                    btnMem.Width = 34.5;
                    btnHis.Margin = new Thickness(25, 8, 166, 0);
                    btnMem.Margin = new Thickness(111, 8, 105, 0);
                    btnHis.Style = FindResource("btnHisAndMem") as Style;
                    btnMem.Style = FindResource("btnHisAndMem") as Style;
                    AllGrid.ColumnDefinitions.Add(new ColumnDefinition());
                    Grid.SetColumnSpan(TitleBar, 2);
                    AllGrid.Children.Add(btnHis);
                    AllGrid.Children.Add(btnMem);
                    btnHis.SetValue(Grid.ColumnProperty, 1);
                    btnHis.SetValue(Grid.RowProperty, 1);
                    btnMem.SetValue(Grid.ColumnProperty, 1);
                    btnMem.SetValue(Grid.RowProperty, 1);
                
            }
            if (Window.ActualWidth < 563)
            {
                AllGrid.Children.Remove(btnHis);
                AllGrid.Children.Remove(btnMem);
                AllGrid.ColumnDefinitions.Clear();
            }

        }



    }
}
