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
using System.Windows.Shapes;

namespace CalculatorPro.TestDemo
{
    /// <summary>
    /// Test.xaml 的交互逻辑
    /// </summary>
    public partial class Test : MetroWindow
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                this.hisFlyout.Visibility = Visibility.Visible;
                this.hisFlyout.Height = this.TestGrid.ActualHeight;
                if (!this.hisFlyout.IsOpen)
                {
                    this.hisFlyout.IsOpen = true;

                }
            
        }
    }
}
