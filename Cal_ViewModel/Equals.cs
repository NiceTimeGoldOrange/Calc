using Cal_ViewModel.Operator;
using Cal_ViewModel.OperatorModel;
using History_Memory;
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
                if (CalViewModel.DisPlayText1 == "" && Loading.lastOperator == "")
                {
                    return Loading.belowText = "0";
                }
                else
                {
                    Loading.lastResult = CalViewModel.DisPlayBigText1;
                    switch (Loading.currentOperator)
                    {
                        case "+":
                            Loading.belowText = add.GetResult(Loading.lastResult, Loading.belowText);
                            break;
                        case "-":
                            Loading.belowText = sub.GetResult(Loading.lastResult, Loading.belowText);
                            break;
                        case "×":
                            Loading.belowText = mul.GetResult(Loading.lastResult, Loading.belowText);
                            break;
                        case "÷":
                            Loading.belowText = dev.GetResult(Loading.lastResult, Loading.belowText);
                            break;
                    }
                }
                return Loading.belowText;
            }
        }
}
