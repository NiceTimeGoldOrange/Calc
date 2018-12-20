using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CalculatorPro.View
{/// <summary>
/// 还原
/// </summary>
    public class ShowRestore : MainWindow,IAnimation
    {
        public void ShowAnimation()
        {
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.hisFlyout.Visibility = Visibility.Visible;
            this.hisFlyout.Height = this.OutGrid.ActualHeight;
            if (!this.hisFlyout.IsOpen)
            {
                this.hisFlyout.IsOpen = true;

            }
        }
    }
}
