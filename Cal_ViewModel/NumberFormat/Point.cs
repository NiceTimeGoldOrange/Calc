using Cal_ViewModel.IJudge;
using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.NumberFormat
{/// <summary>
/// 小数点
/// </summary>
    class Point : IJudegForPoint
    {
        public string IsPoint()
        {
            // 新输入的操作数
            if (Loading.isNewNum)
            {
                Loading.belowText = "";
                Loading.isNewNum = false;
            }

            //下部文本框中为0
            if (Loading.belowText.Contains("."))
            {
                return Loading.belowText;
            }
            else
            {
                if (Loading.belowText == "")
                {
                   Loading.belowText = "0." + Loading.belowText;
                }
                else
                {
                    Loading.belowText = Loading.belowText + ".";
                }
                return Loading.belowText;
            }
        }
    }
}
