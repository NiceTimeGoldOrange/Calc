using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.ScienceNum
{
    public class Science
    {
        public static string MySciToNum(string i1)
        {
            if (i1.Contains("."))
            {
                i1 = ScienceNum.ContainsPoint.ContainPoint(i1);
            }
            else
            {
                i1 = ScienceNum.NoContainsPoint.NoContainPoint(i1);
            }
            return i1;
        }

        // 除
        public static string Devide(string num1, string num2)
        {
            if (num2 == "0")
            {
                return "除数不能为零";
            }
            else
            {
                num1 = Science.MySciToNum(num1);
                num2 = Science.MySciToNum(num2);

                Int32 right = Int32.Parse(num1.Substring(num1.IndexOf('E') + 1)) - Int32.Parse(num2.Substring(num2.IndexOf('E') + 1));

                decimal left1 = Convert.ToDecimal(num1.Substring(0, num1.IndexOf('E')));
                decimal left2 = Convert.ToDecimal(num2.Substring(0, num2.IndexOf('E')));
                decimal left = decimal.Divide(left1, left2);
                string[] str = Adjust(left.ToString(), right);
                if (right > 0)
                {
                    return str[0] + "E+" + right;
                }
                else
                {
                    return str[0] + "E" + right;
                }
            }
        }

        // 乘
        public static string Multiply(string num1, string num2)
        {
            num1 = Science.MySciToNum(num1);
            num2 = Science.MySciToNum(num2);

            BigInteger right1 = BigInteger.Parse(num1.Substring(num1.IndexOf('E') + 1));
            BigInteger right2 = BigInteger.Parse(num2.Substring(num2.IndexOf('E') + 1));
            BigInteger right = right1 + right2;
            Debug.WriteLine(right);

            decimal left1 = Convert.ToDecimal(num1.Substring(0, num1.IndexOf('E')));
            decimal left2 = Convert.ToDecimal(num2.Substring(0, num2.IndexOf('E')));
            decimal left = decimal.Multiply(left1, left2);

            string[] str = Adjust(left.ToString(), right);
            if (right >= 1000 || right <= -1000)
            {
                return "溢出";
            }
            else
            {
                if (right > 0)
                {
                    return str[0] + "E+" + str[1];
                }
                else
                {
                    return str[0] + "E" + str[1];
                }
            }
        }

        // 加法
        public static string Addition(string num1, string num2)
        {
            num1 = Science.MySciToNum(num1);
            num2 = Science.MySciToNum(num2);

            Int32 right1 = Int32.Parse(num1.Substring(num1.IndexOf('E') + 1));
            Int32 right2 = Int32.Parse(num2.Substring(num2.IndexOf('E') + 1));

            decimal left1 = Convert.ToDecimal(num1.Substring(0, num1.IndexOf('E')));
            decimal left2 = Convert.ToDecimal(num2.Substring(0, num2.IndexOf('E')));

            int len = right1 - right2;
            if (right1 >= right2)
            {
                StringBuilder sb = new StringBuilder();
                string str = "0." + sb.Append('0', right1 - right2) + left2.ToString().Replace(".", "");
                Console.WriteLine(str);
                decimal result = left1 + decimal.Parse(str);
                if (right1 > 0 || right2 > 0)
                {
                    return result.ToString().TrimEnd('0') + "E+" + right1;
                }
                else
                {
                    return result.ToString().TrimEnd('0') + "E-" + right1;
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                string str = "0." + sb.Append('0', right2 - right1 - 1) + left1.ToString().Replace(".", "");
                Console.WriteLine(str);
                decimal result = left2 + decimal.Parse(str);
                if (right1 > 0 || right2 > 0)
                {
                    return result.ToString().TrimEnd('0') + "E+" + right2;
                }
                else
                {
                    return result.ToString().TrimEnd('0') + "E-" + right2;
                }
            }
        }

        // 减法
        public static string Subtract(string num1, string num2)
        {
            num1 = Science.MySciToNum(num1);
            num2 = Science.MySciToNum(num2);

            Int32 right1 = Int32.Parse(num1.Substring(num1.IndexOf('E') + 1));
            Int32 right2 = Int32.Parse(num2.Substring(num2.IndexOf('E') + 1));

            decimal left1 = Convert.ToDecimal(num1.Substring(0, num1.IndexOf('E')));
            decimal left2 = Convert.ToDecimal(num2.Substring(0, num2.IndexOf('E')));

            int len = right1 - right2;
            if (right1 >= right2)
            {
                StringBuilder sb = new StringBuilder();
                string str = "0." + sb.Append('0', right1 - right2) + left2.ToString().Replace(".", "");
                Console.WriteLine(str);
                decimal result = left1 - decimal.Parse(str);
                string[] newNum = Adjust(result.ToString(), right1);
                if (right1 > 0 || right2 > 0)
                {
                    return newNum[0] + "E+" + newNum[1];
                }
                else
                {
                    return newNum[0] + "E+" + newNum[1];
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                string str = "0." + sb.Append('0', right2 - right1 - 1) + left1.ToString().Replace(".", "");
                Console.WriteLine(str);
                decimal result = left2 - decimal.Parse(str);
                string[] newNum = Adjust(result.ToString(), right2);
                if (right1 > 0 || right2 > 0)
                {
                    return newNum[0] + "E+" + newNum[1];
                }
                else
                {
                    return newNum[0] + "E-" + newNum[1];
                }
            }
        }

        // 科学计数法计算出来的结果值可能小数点左侧不为单个非零整数 left 整数部分  right 小数部分
        public static string[] Adjust(string left, BigInteger right)
        {
            string[] array = new string[2];
            // 包含小数点
            if (left.Contains("."))
            {
                string[] strArr = left.Split('.');
                // 左侧长度大于1 11.123456789
                if (strArr[0].Length > 1)
                {
                    left = strArr[0].Insert(1, ".") + strArr[1];
                    // NTGO 梁家其 strArr[0]错写成了left
                    right = right + (strArr[0].Length - 1);
                    Debug.WriteLine("Adjust:" + right);
                    array[0] = left;
                    array[1] = right.ToString();
                    return array;
                }
                // 左侧长度小于1
                else
                {
                    if (strArr[0].Equals("0"))
                    {
                        decimal newLeftNum = decimal.Parse(strArr[1]); // 999544
                        array[0] = newLeftNum.ToString().Insert(1, ".");
                        array[1] = (right - 1).ToString();
                        return array;
                    }
                    else
                    {
                        array[0] = left;
                        array[1] = right.ToString();
                        return array;
                    }
                }
            }
            else
            {
                array[0] = left.Insert(1, ".");
                array[1] = (right + left.Length - 1).ToString();
                return array;
            }
        }

    }
}
