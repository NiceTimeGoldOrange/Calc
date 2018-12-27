using Cal_ViewModel.OperatorModel;
using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.AppendOperation.AppendSingle
{/// <summary>
/// 平方
/// </summary>
    class MySquare
    {
        public static void MySqr(string opt)
        {
            Square square = new Square();
            // 1.计算器初始化状态
            if ("".Equals(Loading.belowText))
            {
                Loading.topText += "sqr（" + "0" + ")";
                Loading.belowText = square.MySquare("0");
                Loading.isSingleOper = true;
            }
            // 2.底部不为空  是否进行过单目运算 
            else if (!Loading.isSingleOper)
            {
                Loading.topText += "sqr(" + Loading.belowText + ")";
                Loading.belowText = square.MySquare(Loading.belowText);
                Loading.isSingleOper = true;
            }
            else
            {
                // 上一个结果是空值
                if ("".Equals(Loading.lastOperator))
                {
                    Loading.topText = "sqr(" + Loading.topText + ")";
                    Loading.belowText = square.MySquare(Loading.belowText);
                }
                else
                {
                    if (Loading.topText.LastIndexOf(Loading.currentOperator) == Loading.topText.Length - 1)
                    {
                        Loading.topText += "sqr(" + Loading.lastResult + ")";
                        Loading.belowText = square.MySquare(Loading.lastResult);
                    }
                    else
                    {
                        int num = Loading.topText.LastIndexOf(Loading.lastOperator) + 1;
                        string str = Loading.topText.Substring(num, Loading.topText.Length - num);
                        Loading.topText = Loading.topText.Substring(0, num) + ("sqr(" + str + ")");
                        Loading.belowText = square.MySquare(Loading.belowText);
                    }
                }
            }
        }
    }
}
