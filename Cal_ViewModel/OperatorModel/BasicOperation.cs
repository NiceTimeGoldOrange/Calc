using MyMathTools.ScienceNum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.OperatorModel
{
    public class Basic_Opreation
    {
        // 加 NTGO 梁家其 引用科学计数法
        public string Add(string num1, string num2)
        {
            if (num1.Contains('E') || num2.Contains('E'))
            {
                return Science.Addition(num1, num2);
            }
            else
            {
                return (Convert.ToDecimal(num1) + Convert.ToDecimal(num2)).ToString();
            }
        }

        // 减 NTGO 梁家其 引用科学计数法
        public string Sub(string num1, string num2)
        {
            if (num1.Contains('E') || num2.Contains('E'))
            {
                return Science.Subtract(num1, num2);
            }
            else
            {
                return (Convert.ToDecimal(num1) - Convert.ToDecimal(num2)).ToString();
            }
        }

        // 乘 NTGO 梁家其 引用科学计数法
        public string Mul(string num1, string num2)
        {
            if (num1.Contains('E') && num2.Contains('E'))
            {
                return Science.Multiply(num1, num2);
            }
            else if(!num2.Contains("E") && num1.Contains("E"))
            {
                // 1.123456789123456E+10   6
                string[] strArr = num1.Split('E'); //  1.123456789123456   +10
                decimal newNum = decimal.Parse(strArr[0]) * decimal.Parse(num2);
                string[] str = Science.Adjust(newNum.ToString(), int.Parse(strArr[1]));
                if(int.Parse(strArr[1]) < 0)
                {
                    return str[0] + "E" + str[1];
                }
                else
                {
                    return str[0] + "E+" + str[1];
                }
            }
            else
            {
                decimal result = Convert.ToDecimal(num1) * Convert.ToDecimal(num2);
                if(result.ToString().Length > 16)
                {
                   return Science.MySciToNum(result.ToString());
                }
                else
                {
                    return result.ToString();
                }
            }
        }

        // 除 NTGO 梁家其 引用科学计数法
        public string Div(string num1, string num2)
        {
            if (num2 == "0")
            {
                return "除数不能为零";
            }
            if (num1.Contains('E') && num2.Contains('E'))
            {
                return Science.Devide(num1, num2);
            }
            else if (num1.Contains("E") && !num2.Contains("E"))
            {
                // 1.123456789123456E+10   6
                string[] strArr = num1.Split('E');
                decimal newNum = decimal.Divide(decimal.Parse(strArr[0]), decimal.Parse(num2));
                string[] str = Science.Adjust(newNum.ToString(), int.Parse(strArr[1]));
                if(int.Parse(strArr[1]) < 0)
                {
                    return str[0] + "E" + str[1];
                }
                else
                {
                    return str[0] + "E+" + str[1];
                }
            }
            else
            {
                return (Convert.ToDecimal(num1) / Convert.ToDecimal(num2)).ToString();
            }
        }
    }
}
