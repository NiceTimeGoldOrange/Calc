using Cal_ViewModel.Operation.Monocular;
using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.AppendOperation.AppendSingle
{
    class MyInverse
    {
        public static void MyInve(string opt)
        {
            Inverse inverse = new Inverse();
            // 1.初始化状态
            if ("".Equals(Loading.belowText))
            {
                Loading.topText += "1/(" + 0 + ")";
                Loading.belowText = "除数不能为零";
            }
            else if (!Loading.isSingleOper)
            {
                Loading.topText += "1/(" + Loading.belowText + ")";
                Loading.belowText = inverse.MyInverse(Loading.belowText);
                Loading.isSingleOper = true;
            }
            else
            {
                if ("".Equals(Loading.lastResult))
                {
                    Loading.topText = "1/(" + Loading.topText + ")";
                    Loading.belowText = inverse.MyInverse(Loading.belowText);
                }
                else
                {
                    if(Loading.topText.LastIndexOf(Loading.currentOperator).Equals(Loading.topText.Length - 1))
                    {
                        Loading.topText += "1/(" + Loading.lastResult + ")";
                        Loading.belowText = inverse.MyInverse(Loading.belowText);
                    }
                    else
                    {
                        int num = Loading.topText.LastIndexOf(Loading.currentOperator) + 1;
                        String str = Loading.topText.Substring(num, Loading.topText.Length - num);
                        Loading.topText = Loading.topText.Substring(0, num) + "1/(" + str + ")";
                        Loading.belowText = inverse.MyInverse(Loading.belowText);
                    }
                }
            }
        }
    }
}
