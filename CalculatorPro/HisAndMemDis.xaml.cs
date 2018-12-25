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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorPro
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class HisAndMemDis : UserControl
    {
        public HisAndMemDis()
        {
            InitializeComponent();
        }

        DoubleAnimation lstBoxShow = new DoubleAnimation();
        private void BtnHisRec_Click(object sender, RoutedEventArgs e)
        {
            if(lstHis.Visibility == Visibility.Collapsed && ImgHis.Visibility==Visibility.Hidden)
            {   
                lstHis.Visibility = Visibility.Visible;
                lstMem.Visibility = Visibility.Collapsed;
                ImgHis.Visibility = Visibility.Visible;
                ImgMem.Visibility = Visibility.Hidden;
                lstBoxShow.From = 0;
                lstBoxShow.To = 1;                
                lstBoxShow.Duration = TimeSpan.FromSeconds(0.3);
                lstHis.BeginAnimation(Border.OpacityProperty, lstBoxShow);
                ImgHis.BeginAnimation(Grid.OpacityProperty, lstBoxShow);
            }
        }
        private void BtnMemRec_Click(object sender, RoutedEventArgs e)
        {
            if (lstMem.Visibility == Visibility.Collapsed && ImgMem.Visibility == Visibility.Hidden)
            {
                lstMem.Visibility = Visibility.Visible;
                lstHis.Visibility = Visibility.Collapsed;
                ImgMem.Visibility = Visibility.Visible;
                ImgHis.Visibility = Visibility.Hidden;
                lstBoxShow.From = 0;
                lstBoxShow.To = 1;
                lstBoxShow.Duration = TimeSpan.FromSeconds(0.3);
                lstMem.BeginAnimation(Border.OpacityProperty, lstBoxShow);
                ImgMem.BeginAnimation(Grid.OpacityProperty, lstBoxShow);
            }
        }
    }
}
