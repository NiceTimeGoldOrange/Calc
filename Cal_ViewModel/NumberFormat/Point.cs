using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.NumberFormat
{/// <summary>
/// 小数点
/// </summary>
    class Point
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
            if (Loading.belowText == "0")
            {
                return "0." + Loading.belowText;
            }

            // 不为0
            else
            {
                // 包含小数点
                if (Loading.belowText.Contains("."))
                {
                    return Loading.belowText;

                }
                // 不含小数点
                else
                {
                    return Loading.belowText + ".";
                }
            }
        }
    }
}
