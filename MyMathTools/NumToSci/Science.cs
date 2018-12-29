using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.NumToSci
{
    class Science
    {
        public static string MySciToNum(string i1)
        {
            if (i1.Contains("."))
            {
                i1 = ContainsPoint.ContainPoint(i1);
            }
            else
            {
                i1 = NoContainsPoint.NoContainPoint(i1);
            }
            return i1;
        }

        // 除
        public static string Devide(string num1, string num2)
        {
            num1 = Science.MySciToNum(num1);
            num2 = Science.MySciToNum(num2);

            Int32 right = Int32.Parse(num1.Substring(num1.IndexOf('e') + 1)) - Int32.Parse(num2.Substring(num2.IndexOf('e') + 1));

            decimal left1 = Convert.ToDecimal(num1.Substring(0, num1.IndexOf('e')));
            decimal left2 = Convert.ToDecimal(num2.Substring(0, num2.IndexOf('e')));
            decimal left = decimal.Divide(left1, left2);
            string[] str = Adjust(left.ToString(), right);
            if (right > 0)
            {
                return str[0] + "e+" + right;
            }
            else
            {
                return str[0] + "e" + right;
            }
        }

        // 乘
        public static string Multiply(string num1, string num2)
        {
            num1 = Science.MySciToNum(num1);
            num2 = Science.MySciToNum(num2);

            Int32 right = Int32.Parse(num1.Substring(num1.IndexOf('e') + 1)) + Int32.Parse(num2.Substring(num2.IndexOf('e') + 1));

            decimal left1 = Convert.ToDecimal(num1.Substring(0, num1.IndexOf('e')));
            decimal left2 = Convert.ToDecimal(num2.Substring(0, num2.IndexOf('e')));
            decimal left = decimal.Multiply(left1, left2);

            string[] str = Adjust(left.ToString(), right);
            if (right > 0)
            {
                return str[0] + "e+" + str[1];
            }
            else
            {
                return str[0] + "e" + str[1];
            }
        }

        // 加法
        public static string Addition(string num1, string num2)
        {
            num1 = Science.MySciToNum(num1);
            num2 = Science.MySciToNum(num2);

            Int32 right1 = Int32.Parse(num1.Substring(num1.IndexOf('e') + 1));
            Int32 right2 = Int32.Parse(num2.Substring(num2.IndexOf('e') + 1));

            decimal left1 = Convert.ToDecimal(num1.Substring(0, num1.IndexOf('e')));
            decimal left2 = Convert.ToDecimal(num2.Substring(0, num2.IndexOf('e')));

            int len = right1 - right2;
            if (right1 >= right2)
            {
                StringBuilder sb = new StringBuilder();
                string str = "0." + sb.Append('0', right1 - right2) + left2.ToString().Replace(".", "");
                Console.WriteLine(str);
                decimal result = left1 + decimal.Parse(str);
                if (right1 > 0 || right2 > 0)
                {
                    return result.ToString().TrimEnd('0') + "e+" + right1;
                }
                else
                {
                    return result.ToString().TrimEnd('0') + "e-" + right1;
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
                    return result.ToString().TrimEnd('0') + "e+" + right2;
                }
                else
                {
                    return result.ToString().TrimEnd('0') + "e-" + right2;
                }
            }
        }

        // 减法
        public static string Subtract(string num1, string num2)
        {
            num1 = Science.MySciToNum(num1);
            num2 = Science.MySciToNum(num2);

            Int32 right1 = Int32.Parse(num1.Substring(num1.IndexOf('e') + 1));
            Int32 right2 = Int32.Parse(num2.Substring(num2.IndexOf('e') + 1));

            decimal left1 = Convert.ToDecimal(num1.Substring(0, num1.IndexOf('e')));
            decimal left2 = Convert.ToDecimal(num2.Substring(0, num2.IndexOf('e')));

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
                    return newNum[0] + "e+" + newNum[1];
                }
                else
                {
                    return newNum[0] + "e+" + newNum[1];
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
                    return newNum[0] + "e+" + newNum[1];
                }
                else
                {
                    return newNum[0] + "e-" + newNum[1];
                }
            }
        }

        // 科学计数法计算出来的结果值可能小数点左侧不为单个非零整数
        public static string[] Adjust(string left, int right)
        {
            string[] array = new string[2];
            // 包含小数点
            if (left.Contains("."))
            {
                string[] strArr = left.Split('.');
                // 左侧长度大于1
                if (strArr[0].Length > 1)
                {
                    left = strArr[0].Insert(0, ".") + strArr[1];
                    right = right + (left.Length - 1);
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
