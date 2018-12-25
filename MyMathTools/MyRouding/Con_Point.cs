using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.RoudingTools
{/// <summary>
/// 四舍五入，包含小数点
///     1.小数点左侧为0
///     2.小数点左侧不为0
/// </summary>
    class Con_Point
    {
        public static string Point(string i1)
        {
            string result = "";
            if (i1.Contains("."))
            {
                if (i1.Length > 16)
                {
                    char[] ch = new char[] { '.' };
                    string[] strArr = i1.Split(ch);
                    string left = strArr[0];
                    string right = strArr[1];
                    // 左侧不为0 左侧位数大于16位，小于16位
                    if (left != "0")
                    {
                        // 左侧长度大于16位
                        if (left.Length > 16) // 1234567891234567,49
                        {
                            result = No_Point.NPoint(left);
                        }
                        // 左侧长度小于16位  1234567.123456789,12345
                        else
                        {
                            int rNum = int.Parse(right.Substring(16 - left.Length, 1)); // 1
                            if (rNum >= 5)
                            {
                                result = left + "." + (decimal.Parse(right.Substring(0, 16 - left.Length)) + 1);
                            }
                            else
                            {
                                result = left + "." + right.Substring(0, 16 - left.Length);
                            }
                        }
                    }
                    // 小数点左侧为0时，当右侧的0的个数大于3时，采用科学计数法
                    else
                    {
                        BigInteger rNum = BigInteger.Parse(right); // 0000123456789123456789 ==> 123456789123456789
                        // 左侧0的个数大于3，采用科学计数法，四舍五入
                        if ((right.Length - rNum.ToString().Length) > 3)
                        {
                            string str = rNum.ToString(); // 123456789123456789
                            if (int.Parse(str.Substring(16, 1)) >= 5) // 8
                            {
                                BigInteger num1 = BigInteger.Parse(str.Substring(0, 16)) + 1; // 
                                result = num1.ToString().Insert(1, ".") + "e-" + (right.Length - rNum.ToString().Length + 1);
                            }
                            // 右侧第17位小于5 0.00001234567891234567,49
                            else
                            {
                                result = rNum.ToString().Substring(0, 16) + "e-" + (right.Length - rNum.ToString().Length + 1);
                            }
                        }
                        // 左侧0的个数小于3
                        else
                        {
                            // 获取第17位数字，四舍五入
                            string num = right.Substring(16, 1);
                            // 将右侧转换为数值
                            BigInteger newNum = BigInteger.Parse(right);
                            if (int.Parse(num) >= 5)
                            {
                                int len = right.Length - newNum.ToString().Length;
                                if (len == 0)
                                {
                                    result = "0." + (newNum + 1);
                                }
                                else if (len == 1)
                                {
                                    result = "0.0" + (newNum + 1);
                                }
                                else if (len == 2)
                                {
                                    result = "0.00" + (newNum + 1);
                                }
                                else if (len == 3)
                                {
                                    result = "0.000" + (newNum + 1);
                                }
                            }
                            // 右侧第17位小于5                         
                            else
                            {
                                int len = right.Length - newNum.ToString().Length;
                                if (len == 0)
                                {
                                    result = "0." + newNum;
                                }
                                else if (len == 1)
                                {
                                    result = "0.0" + newNum;
                                }
                                else if (len == 2)
                                {
                                    result = "0.00" + newNum;
                                }
                                else if (len == 3)
                                {
                                    result = "0.000" + newNum;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

    }
}
