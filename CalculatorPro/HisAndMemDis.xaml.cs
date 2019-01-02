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
        private static int count = 0;
        private static int itemCount = 0;
        public HisAndMemDis()
        {
            InitializeComponent();
            lstBoxMem.ItemContainerGenerator.StatusChanged += Items_CollectionChanged;
            //lstBoxHis.ItemContainerGenerator.StatusChanged += HisItems_CollectionChanged;
        }

        //private void HisItems_CollectionChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

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
                lstBoxShow.Duration = TimeSpan.FromSeconds(0.4);
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
                lstBoxShow.Duration = TimeSpan.FromSeconds(0.4);
                lstMem.BeginAnimation(Border.OpacityProperty, lstBoxShow);
                ImgMem.BeginAnimation(Grid.OpacityProperty, lstBoxShow);
            }
        }
        private void Items_CollectionChanged(object sender, EventArgs e)
        {   
            if (itemCount != lstBoxMem.Items.Count)
            {
                count++;
                if (count %2 == 0)
                {
                    ListBoxItem firstItem =(ListBoxItem) lstBoxMem.ItemContainerGenerator.ContainerFromIndex(0)  ;
                    firstItem.Opacity = 0;
                    if (count == 4)
                    {
                        DoubleAnimation heightAnimation = new DoubleAnimation();
                        heightAnimation.From = 0;
                        heightAnimation.To = firstItem.ActualHeight;
                        heightAnimation.Duration = TimeSpan.FromSeconds(0);
                        heightAnimation.BeginTime = TimeSpan.FromSeconds(0.3);
                        firstItem.BeginAnimation(HeightProperty, heightAnimation);
                        DoubleAnimation opacityAnimation = new DoubleAnimation();
                        opacityAnimation.From = 0;
                        opacityAnimation.To = 1;
                        opacityAnimation.Duration = TimeSpan.FromSeconds(0.3);
                        opacityAnimation.BeginTime = TimeSpan.FromSeconds(0.3);
                        firstItem.BeginAnimation(OpacityProperty, opacityAnimation);
                        ThicknessAnimation marginAnimation = new ThicknessAnimation();
                        marginAnimation.From = new Thickness(-5, 0, 5, 0);
                        marginAnimation.To = new Thickness(-5, 0, 0, 0);
                        marginAnimation.Duration = TimeSpan.FromSeconds(0.3);
                        marginAnimation.BeginTime = TimeSpan.FromSeconds(0.3);
                        firstItem.BeginAnimation(MarginProperty, marginAnimation);
                        itemCount = lstBoxMem.Items.Count;
                        count = 0;
                    }
                }
            }

        }  
        
    }
}
