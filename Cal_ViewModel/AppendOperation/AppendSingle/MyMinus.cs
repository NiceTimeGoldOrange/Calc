using Cal_ViewModel.ChangeFactory;
using Cal_ViewModel.Operation.Monocular;
using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.AppendOperation.AppendSingle
{/// <summary>
/// 正负号 其运算直接在belowText中进行
/// </summary>
    class MyMinus
    {
        public static void Myminus(string opt)
        {
            Minus minus = new Minus();
            AppendSign sign = new AppendSign();

            if (Loading.isSingleOper)
            {
                if (!Loading.isSingleOper)
                {
                    Loading.topText += "negate(" + CalViewModel._disPlayBigText + ")";
                    Loading.belowText = minus.MyMinus(CalViewModel._disPlayBigText);
                    Loading.isSingleOper = true;
                }
                else
                {
                    int num = Loading.topText.LastIndexOf(Loading.currentOperator) + 1;
                    string str = Loading.topText.Substring(num, Loading.topText.Length - num);
                    if( str == "")
                    {
                        str = Loading.topText.Substring(0, num) + "negate(" + str + ")";
                        Loading.belowText = minus.MyMinus(Loading.belowText);
                    }
                }
            }
            else
            {
                if (Loading.belowText == "")
                {
                    if (!Loading.isSingleOper)
                    {
                        Loading.topText = "negate(" + "0" + ")";
                        Loading.belowText = "0";
                        Loading.isSingleOper = true;
                    }
                }
                else if (Loading.isSingleOper == true && Loading.belowText == "0")
                {
                    Loading.topText = "negate(" + Loading.topText + ")";
                    Loading.belowText = "0";
                }
                else
                {
                    if (Loading.belowText == "0")
                    {
                        Loading.belowText = minus.MyMinus(Loading.belowText);
                        Loading.belowText = sign.GetStatus();
                    }
                    else
                    {
                        Loading.belowText = minus.MyMinus(Loading.belowText);
                    }
                }
            }
        }
    }
}
