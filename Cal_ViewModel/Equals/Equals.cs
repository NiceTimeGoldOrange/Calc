using Cal_ViewModel.Format;
using Cal_ViewModel.Operator;
using Cal_ViewModel.OperatorModel;
using History_Memory;
using MyMathTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel
{
    /// <summary>
    /// 等于运算
    /// </summary>
    class Equals
    {
        IOperator add = new Addition();
        IOperator sub = new Subtract();
        IOperator mul = new Multiply();
        IOperator dev = new Devide();

        public string Result()
        {
            // 底部文本框为空 无最后一个操作符(计算器初始化)
            if (CalViewModel._disPlayText == "" && Loading.lastOperator == "")
            {
                return Loading.belowText = "0";
            }
            // 无操作符
            else if ("" == Loading.lastOperator)
            {
                Loading.lastResult = Loading.belowText;
            }
            // 输入了新数值，新四则运算符
            else if (Loading.isNewNum && !Loading.isNewOperator)
            {
                Loading.lastResult = CalViewModel._disPlayText;

                if (Loading.currentOperator == "+")
                {
                    Loading.belowText = MyMath.MyRouding(add.GetResult(Loading.lastResult, Loading.belowText));
                }
                else if (Loading.currentOperator == "-")
                {
                    Loading.belowText = MyMath.MyRouding(sub.GetResult(Loading.lastResult, Loading.belowText));
                }
                else if (Loading.currentOperator == "×")
                {
                    Loading.belowText = MyMath.MyRouding(mul.GetResult(Loading.lastResult, Loading.belowText));
                }
                else if (Loading.currentOperator == "÷")
                {
                    Loading.belowText = MyMath.MyRouding(dev.GetResult(Loading.lastResult, Loading.belowText));
                }
            }
            else
            {
                if (Loading.currentOperator == "+")
                {
                    Loading.belowText = MyMath.MyRouding(add.GetResult(Loading.lastResult, Loading.belowText));
                }
                else if (Loading.currentOperator == "-")
                {
                    Loading.belowText = MyMath.MyRouding(sub.GetResult(Loading.lastResult, Loading.belowText));
                }
                else if (Loading.currentOperator == "×")
                {
                    Loading.belowText = MyMath.MyRouding(mul.GetResult(Loading.lastResult, Loading.belowText));
                }
                else if (Loading.currentOperator == "÷")
                {
                    Loading.belowText = MyMath.MyRouding(dev.GetResult(Loading.lastResult, Loading.belowText));
                }
            }
            return AppendComma.TrisectionMethod(Loading.lastResult);
        }
    }
}
