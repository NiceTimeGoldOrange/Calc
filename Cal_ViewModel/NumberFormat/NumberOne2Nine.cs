using Cal_ViewModel.Judge;
using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.NumberFormat
{
    /// <summary>
    /// 数字1-9
    /// </summary>
    class NumberOne2Nine : IJudgeForNumber
    {
        public string JudgeNum(string num)
        {
            // 执行过等于运算
            if (Loading.isEqual)
            {
                Loading.lastOperator = "";
                Loading.currentOperator = "";
                Loading.lastResult = "";
                Loading.isNewOperator = true;
                Loading.isSingleOper = false;
                Loading.isEqual = false;
                Loading.isMinus = true;
            }

            // 顶部文本框不为空
            if (CalViewModel._disPlayText != "")
            {
                if (CalViewModel._disPlayText.Last().ToString() == ")" || Loading.isSingleOper)
                {
                    if (Loading.lastOperator == "")
                    {
                        Loading.topText = "";
                    }
                    else
                    {
                        Loading.topText = Loading.topText.Substring(0, Loading.lastOperator.Length - 1);
                    }
                    Loading.belowText = "0";
                }
            }

            Loading.lastOperator = Loading.currentOperator;
            Loading.isNewOperator = false;
            Loading.isSingleOper = false;

            if (Loading.isNewNum)
            {
                Loading.belowText = "";
                Loading.isNewNum = false;
            }

            if (Loading.belowText == "0")
            {
                Loading.belowText = "";
            }

            Loading.belowText += num;
            return Loading.belowText;
        }
    }
}
