using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.SaveModel;
using MyMathTools;
using MyMathTools.ScienceNum;

namespace Cal_ViewModel.OperatorModel
{
    public class Complex_Operation
    {
        public string Sqrt(string num1)
        {
            return MyMath.Sqrt(num1);
        }

        // NTGO 梁家其  科学计数法四则运算
        public string Squ(string num1)
        {
            if (num1.Contains("e") || num1.Contains("E"))
            {
                return Science.Multiply(num1, num1);
            }
            else if (num1.Contains("不") || num1.Contains("无") || num1.Contains("未") || num1.Contains("溢"))
            {
                return num1;
            }
            else
            {
                return (Convert.ToDouble(num1) * Convert.ToDouble(num1)).ToString();
            }
        }

        // NTGO 梁家其  科学计数法四则运算
        public string Cube(string num1)
        {
            return (Convert.ToDecimal(num1) * Convert.ToDecimal(num1) * Convert.ToDecimal(num1)).ToString();
        }

        // NTGO 梁家其  科学计数法四则运算
        public string OneCent(string num1)
        {
            if ("0".Equals(num1))
            {
                return "除数不能为零";
            }
            else
            {
                if (num1.Contains("不") || num1.Contains("溢") || num1.Contains("无") || num1.Contains("未"))
                {
                    Cache.topCache = "";
                    return num1;
                }
                else
                {
                    string newNum = (1 / Convert.ToDecimal(num1)).ToString();
                    if (newNum.Contains('.'))
                    {
                        string[] str = newNum.Split('.');
                        BigInteger integer = BigInteger.Parse(str[1]);

                        if (str[1].Length - integer.ToString().Length > 10)
                        {
                            return str[0];
                        }
                        else
                        {
                            return newNum;
                        }
                    }
                    return newNum;
                }
            }
        }

        public string Minus(string num1)
        {
            // NTGO 梁家其  1.3 当下部文本框不为数值时，点击会报错
            if (num1.Contains("不") || num1.Contains("溢") || num1.Contains("无") || num1.Contains("未"))
            {
                //Cache.topCache = "";
                return num1;
            }
            else
            {
                return (-Convert.ToDecimal(num1)).ToString();
            }
        }
    }
}
