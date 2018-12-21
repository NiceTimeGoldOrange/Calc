using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace CalculatorPro.View
{/// <summary>
/// 关闭
/// </summary>
    public class Close :MainWindow,IAnimation
    {
        public void ShowAnimation()
        {
            this.Close();
        }
        
    }
}
