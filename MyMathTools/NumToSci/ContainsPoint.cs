using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.NumToSci
{
    class ContainsPoint
    {
        public static string ContainPoint(string i1)
        {
            if (i1.Contains("e"))
            {
                return i1;
            }
            else
            {
                return Method(i1);
            }
        }

        private static string Method(string i1)
        {
            string result = "";
            string newNum = i1.Replace("-", "");// 从数字截到最后一位 -1.23456789123456789 ==> 1.23456789123456789   -1.23456789123456789 e+ 17
            string[] strArr = newNum.Split('.');
            // 负数
            if (i1.StartsWith("-"))
            {
                // 1.1小数点左侧为0
                if (strArr[0].Equals("0"))
                {
                    // 右侧大于16位
                    if (strArr[1].Length > 16)
                    {
                        string newStr = strArr[1].Trim('0'); // 右侧首位去除0   0个数大于3时，采用科学计数法  0.0000123456789123456
                        int len = strArr[1].Length - newStr.Length;
                        string num1 = newStr.Insert(1, "."); // 1.23456789123456
                        result = "-" + num1 + "e-" + (len - 1);
                    }
                    // 右侧小于16位
                    else
                    {
                        result = i1;
                    }

                }
                // 小数点左侧不为0
                else
                {
                    // 总位数大于16位
                    int len = strArr[0].Length + strArr[1].Length;
                    if (len > 16)
                    {
                        result = "-" + strArr[0].Insert(1, ".") + strArr[1] + "e+" + (strArr[0].Length - 1);
                    }
                    // 总位数小于16位
                    else
                    {
                        result = i1;
                    }
                }
            }

            // 正数
            else
            {
                if (strArr[0].Equals("0"))
                {
                    if (strArr[1].Length > 16)
                    {
                        string newStr = strArr[1].Trim('0'); // 右侧首位去除0   0个数大于3时，采用科学计数法  0.0000123456789123456
                        int len = strArr[1].Length - newStr.Length;
                        string num1 = newStr.Insert(1, "."); // 1.23456789123456
                        result = num1 + "e-" + (len - 1);
                        result = i1;
                    }
                    else
                    {
                        result = i1;
                    }

                }
                else
                {
                    // 总位数大于16位
                    int len = strArr[0].Length + strArr[1].Length;
                    if (len > 16)
                    {
                        result = strArr[0].Insert(1, ".") + strArr[1] + "e+" + (strArr[0].Length - 1);
                    }
                    // 总位数小于16位
                    else
                    {
                        result = i1;
                    }

                }
            }
            return result;
        }
    }
}
