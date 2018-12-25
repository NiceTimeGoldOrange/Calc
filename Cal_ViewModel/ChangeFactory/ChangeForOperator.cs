using Cal_ViewModel.Judge;
using Cal_ViewModel.Operator;
using Cal_ViewModel.OperatorModel;
using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.ChangeFactory
{
    class ChangeOperator : IJudgeForOperation
    {
        IOperator add = new Addition();
        IOperator sub = new Subtract();
        IOperator mul = new Multiply();
        IOperator dev = new Devide();

        public string JudgeOperation(string opt)
        {
            Loading.isNewNum = true;

            //执行过等于运算
            if (Loading.isEqual)
            {
                Loading.belowText = Loading.lastResult;
                Loading.lastOperator = "";
                Loading.lastResult = "";
            }

            //直接进行四则运算
            if (Loading.lastOperator == "" && Loading.belowText == "")
            {
                Loading.currentOperator = opt;
                Loading.topText = 0 + opt;
                Loading.isNewOperator = false;
                Loading.lastResult = "";
                Loading.belowText = "0";
            }
            // 不进行四则运算
            else
            {
                Loading.currentOperator = opt;
                if (Loading.isNewNum)
                {
                    Loading.isNewNum = false;
                    if (Loading.isEqual)
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
                        Loading.topText += Loading.belowText + opt;
                    }
                    if (Loading.lastResult == "")
                    {
                        Loading.lastResult = Loading.belowText;
                    }
                }
            }
        }
    }
}
