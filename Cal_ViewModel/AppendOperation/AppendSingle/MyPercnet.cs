using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.AppendOperation.AppendSingle
{
    /// <summary>
    /// 百分比运算
    /// </summary>
    class MyPercnet
    {
        public static void Percent(string opt)
        {
            // 是否进行了双目运算
            if (!Loading.isEqual)
            {
                if (Loading.lastOperator == "")
                {
                    Loading.topText = "0";
                    Loading.belowText = "0";
                }
                else
                {
                    if (Loading.isNewNum)
                    {
                        if ("+" == Loading.currentOperator || "-" == Loading.currentOperator)
                        {
                            int num = Loading.topText.LastIndexOf(Loading.currentOperator) + 1;
                            string str = Loading.topText.Substring(0, num);
                            Loading.topText = str + (decimal.Parse(Loading.belowText) * decimal.Parse(Loading.belowText) / 100).ToString();
                            Loading.belowText = (decimal.Parse(Loading.belowText) * decimal.Parse(Loading.belowText) / 100).ToString();
                            Loading.isSingleOper = true;
                        }
                        else if ("x" == Loading.currentOperator || "÷" == Loading.currentOperator)
                        {
                            int num = Loading.topText.LastIndexOf(Loading.currentOperator) + 1;
                            string str = Loading.topText.Substring(0, num);
                            Loading.topText = str + (decimal.Parse(Loading.belowText) * decimal.Parse(Loading.belowText) / 100).ToString();
                            Loading.belowText = (decimal.Parse(Loading.belowText) / 100).ToString();
                            Loading.isSingleOper = true;
                        }
                    }
                    else
                    {
                        if ("+" == Loading.currentOperator || "-" == Loading.currentOperator)
                        {
                            int num = Loading.topText.LastIndexOf(Loading.currentOperator) + 1;
                            string str = Loading.topText.Substring(0, num);
                            Loading.topText = str + (Convert.ToDecimal(Loading.lastResult) * Convert.ToDecimal(Loading.belowText) / 100).ToString();
                            Loading.belowText = (Convert.ToDecimal(Loading.lastResult) * Convert.ToDecimal(Loading.belowText) / 100).ToString();
                            Loading.isSingleOper = true;
                        }
                        else if ("x" == Loading.currentOperator || "÷" == Loading.currentOperator)
                        {
                            int num = Loading.topText.LastIndexOf(Loading.currentOperator) + 1;
                            string str = Loading.topText.Substring(0, num);
                            Loading.topText = str + (Convert.ToDecimal(Loading.belowText) / 100).ToString();
                            Loading.belowText = (Convert.ToDecimal(Loading.belowText) / 100).ToString();
                            Loading.isSingleOper = true;
                        }
                    }
                }
            }
            // 没有进行过双目运算
            else
            {
                if ("" == Loading.currentOperator)
                {
                    Loading.topText = "0";
                    Loading.belowText = "0";
                }
                else
                {
                    if ("＋".Equals(Loading.currentOperator) || "－".Equals(Loading.currentOperator))
                    {
                        Loading.topText = (Convert.ToDecimal(CalViewModel._disPlayBigText) * Convert.ToDecimal(CalViewModel._disPlayBigText) / 100).ToString();
                        Loading.belowText = (Convert.ToDecimal(CalViewModel._disPlayBigText) * Convert.ToDecimal(CalViewModel._disPlayBigText) / 100).ToString();
                        Loading.isSingleOper = true;
                    }
                    else if ("×".Equals(Loading.currentOperator) || "÷".Equals(Loading.currentOperator))
                    {
                        Loading.topText = (Convert.ToDecimal(CalViewModel._disPlayBigText) / 100).ToString();
                        Loading.belowText = (Convert.ToDecimal(CalViewModel._disPlayBigText) / 100).ToString();
                        Loading.isSingleOper = true;
                    }
                }
            }
        }
    }
}
