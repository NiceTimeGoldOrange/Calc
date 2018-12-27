using Cal_ViewModel.OperatorModel;
using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.AppendOperation.AppendSingle
{/// <summary>
/// 开方
/// </summary>
    class MyEvolution
    {
        public static void MyEvo(string opt)
        {
            Evolution evolution = new Evolution();
            if (opt == "√")
            {
                // 1.计算器初始化状态
                if ("".Equals(Loading.belowText))
                {
                    Loading.topText += "√(" + "0" + ")";
                    Loading.belowText = evolution.GetResult("0");
                    Loading.isSingleOper = true;
                }
                // 2.有输入数值
                else if (!Loading.isSingleOper)
                {
                    Loading.topText += "√(" + Loading.belowText + ")";
                    Loading.belowText = evolution.GetResult(Loading.belowText);
                    Loading.isSingleOper = true;
                }
                // 3.进行过单目运算
                else
                {
                    if ("".Equals(Loading.lastOperator))
                    {
                        Loading.topText = "√(" + Loading.topText + ")";
                        Loading.belowText = evolution.GetResult(Loading.belowText);
                    }
                    else
                    {
                        if (Loading.topText.LastIndexOf(Loading.currentOperator).Equals(Loading.topText.Length - 1))
                        {
                            Loading.topText += "√(" + Loading.lastResult + ")";
                        }
                        else
                        {
                            int num = Loading.topText.LastIndexOf(Loading.currentOperator) + 1;
                            string str = Loading.topText.Substring(num, Loading.topText.Length - num);
                            Loading.topText = Loading.topText.Substring(0, num) + "√(" + str + ")";
                            Loading.belowText = evolution.GetResult(Loading.belowText);
                        }
                    }
                }
            }
        }
    }
}
