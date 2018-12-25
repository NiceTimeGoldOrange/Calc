using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.NumberFormat
{/// <summary>
/// 判定0
/// </summary>
    class Zero
    {
        public string IsZero()
        {
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

            //上部文本框中不为空
            if (CalViewModel.DisPlayText1 != "")
            {
                if (CalViewModel.DisPlayText1.Last().ToString() == ")")
                {
                    if (Loading.currentOperator == "")
                    {
                        Loading.topText = "";
                    }
                    else
                    {
                        Loading.topText = Loading.topText.Substring(0, Loading.topText.LastIndexOf(Loading.currentOperator) + 1);
                    }
                    Loading.belowText = "0";
                }
            }
            Loading.lastOperator = Loading.currentOperator;
            Loading.isNewOperator = true;
            Loading.isSingleOper = false;

            if (Loading.isNewNum)
            {
                Loading.belowText = "";
                Loading.isNewNum = false;
            }

            if (Loading.belowText == "")
            {
                Loading.belowText = "0";
                return Loading.belowText;
            }

            if (Loading.belowText != "0")
            {
                Loading.belowText += 0;
                return Loading.belowText;
            }
            return "";
        }
    }
}
