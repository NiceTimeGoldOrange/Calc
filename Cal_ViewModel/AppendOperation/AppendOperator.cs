using Cal_ViewModel.Format;
using Cal_ViewModel.Judge;
using Cal_ViewModel.Operator;
using Cal_ViewModel.OperatorModel;
using History_Memory;
using MyMathTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.ChangeFactory
{/// <summary>
/// 添加运算符
/// </summary>
    class AppendOperator : IJudgeForOperation
    {
        IOperator add = new Addition();
        IOperator sub = new Subtract();
        IOperator mul = new Multiply();
        IOperator dev = new Devide();

        public string JudgeOperation(string opt)
        {
            // 输入新数值，改变状态
            Loading.isNewNum = true;

            //执行过等于运算，将结果赋给belowText
            if (Loading.isEqual)
            {
                Loading.belowText = Loading.lastResult;
                Loading.lastOperator = "";
                Loading.lastResult = "";
            }

            // 直接进行四则运算
            if (Loading.lastOperator == "" && Loading.belowText == "")
            {
                Loading.currentOperator = opt;
                Loading.topText = 0 + opt;
                Loading.isNewOperator = false;
                Loading.lastResult = "0"; // 设为空？
                Loading.belowText = "0";
            }
            // 不进行四则运算
            else
            {
                Loading.currentOperator = opt;
                // 新操作符
                if (Loading.isNewOperator)
                {
                    Loading.isNewNum = false;
                    // 单目运算
                    if (Loading.isSingleOper)
                    {
                        if (Loading.isEqual)
                        {
                            Loading.topText += Loading.belowText + opt;
                        }
                        else
                        {
                            Loading.topText += opt;
                        }
                    }
                    else
                    {
                        Loading.topText += AppendComma.TrisectionMethod(Loading.belowText) + opt;
                    }

                    //belowText没有结果
                    if (Loading.lastResult == "")
                    {
                        Loading.lastResult = AppendFormat.Addformat(Loading.belowText);
                    }

                    if (Loading.lastOperator == "+")
                    {
                        Loading.belowText = MyMath.MyRouding(add.GetResult(Loading.lastResult, Loading.belowText));
                        Loading.lastResult = Loading.belowText;
                    }
                    else if (Loading.lastOperator == "-")
                    {
                        Loading.belowText = MyMath.MyRouding(sub.GetResult(Loading.lastResult, Loading.belowText));
                        Loading.lastResult = Loading.belowText;
                    }
                    else if (Loading.lastOperator == "×")
                    {
                        Loading.belowText = MyMath.MyRouding(mul.GetResult(Loading.lastResult, Loading.belowText));
                        Loading.lastResult = Loading.belowText;
                    }
                    else if (Loading.lastOperator == "÷")
                    {
                        Loading.belowText = MyMath.MyRouding(dev.GetResult(Loading.lastResult, Loading.belowText));
                        Loading.lastResult = Loading.belowText;
                    }
                }
                // 不是新操作符
                else
                {
                    Loading.currentOperator = opt;
                    Loading.topText = Loading.topText.Substring(0, Loading.topText.Length - 1) + opt;
                }
            }
            Loading.isEqual = false;
            return Loading.topText;
        }
    }
}
