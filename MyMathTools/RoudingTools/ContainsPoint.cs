using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.RoudingTools
{
    class ContainsPoint
    {
        public static string ContainPoint(string i1)
        {
            if (i1.StartsWith("-"))
            {
                i1 = i1.Substring(1, i1.Length - 1);
                i1 = "-" + Method(i1);
                return i1;
            }
            else
            {
                if (i1.Contains("E") ||i1.Contains("e"))
                {
                    string[] strArr = i1.Split('E');
                    string left = Method(strArr[0]);
                    string right = strArr[1];
                    string[] newNum = ScienceNum.Science.Adjust(left, int.Parse(right));
                    if (int.Parse(right) < 0)
                    {
                        return newNum[0] + "E" + newNum[1];
                    }
                    else
                    {
                        return newNum[0] + "E+" + newNum[1];
                    }

                }
                else
                {
                    return Method(i1);
                }
            }
        }

        private static string Method(string i1)
        {
            string[] strArr = i1.Split('.');

            // 小数点左侧不为0
            if (strArr[0] != "0")
            {
                if (i1.Length > 17)
                {
                    if (strArr[0].Length > 16)
                    {
                        i1 = NoContainsPoint.NoContainPoint(i1);
                    }
                    else
                    {  
                        // 拿到总的第17位数值
                        string num = strArr[1].Substring(16 - strArr[0].Length, 1);
                        if (int.Parse(num) >= 5)
                        {
                            string num2 = strArr[1].Substring(0, 16 - strArr[0].Length);
                            BigInteger numRight = BigInteger.Parse(num2) + 1;
                            i1 = strArr[0] + "." + numRight;
                        }
                        else
                        {
                            string num1 = strArr[1].Substring(0, 16 - strArr[0].Length);
                            i1 = strArr[0] + "." + num1;
                        }
                    }
                }
                return i1;
            }
            // 左侧为零
            else
            {
                if (strArr[1].Length > 16)
                {
                    string temp = strArr[1].Substring(16, 1);
                    if (int.Parse(temp) >= 5)
                    {
                        BigInteger numRight = BigInteger.Parse(strArr[1]) + 1;
                        string str = "0.";
                        if (numRight.ToString().Length != strArr[1].Length) // 即小数点后还有0,循环遍历，为小数点右边加0
                        {
                            int count0 = strArr[1].Length - numRight.ToString().Length;
                            for (int i = 0; i < count0; i++)
                            {
                                str += "0";
                            }
                        }
                        i1 = str + numRight;
                    }
                    else
                    {
                        i1 = "0." + strArr[1].Substring(0, 16);
                    }
                }
            }
            return i1;
        }
    }
}
