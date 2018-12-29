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

namespace CalculatorPro
{
    /// <summary>
    /// MemControl.xaml 的交互逻辑
    /// </summary>
    public partial class MemControl : UserControl
    {
        public MemControl()
        {
            InitializeComponent();
        }

        private void TemplateGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            btnDock.Visibility = Visibility.Visible;
        }

        private void TemplateGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            btnDock.Visibility = Visibility.Hidden;
        }
    }
}
