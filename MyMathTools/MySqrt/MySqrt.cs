using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.MySqrt
{
    class MySqrt
    {
        public static string GetSqrt(string i1)
        {
            if (i1.Contains("不") || i1.Contains("未") || i1.Contains("溢") || i1.Contains("无"))
            {
                return i1;
            }
            else
            {
                if (i1.Contains("E"))
                {
                    string[] strArr = i1.Split('E');
                    string left = Method(strArr[0]);
                    string right = (int.Parse(strArr[1]) / 2).ToString();
                    if (int.Parse(right) < 0)
                    {
                        return left + "E" + right;
                    }
                    else
                    {
                        return left + "E+" + right;
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
            decimal x = decimal.Parse(i1);
            //牛顿法，速度比二分法快
            if (x < 0)
            {
                return "无效输入";
            }
            else
            {
                // 首先随便猜一个近似值，然后不断令tem等于x和a/pre的平均数
                decimal pre = x, tem = (pre + x / pre) / 2;
                while ((tem * tem - x) > 0.0000000000001m || (tem * tem - x) < -0.0000000000001m)
                {
                    tem = (tem + x / tem) / 2;
                }
                if (tem.ToString().Contains('.'))
                {
                    string[] str = tem.ToString().Split('.');
                    BigInteger i = BigInteger.Parse(str[1]);
                    if (str[1].Length - i.ToString().Length > 12)
                    {
                        return str[0].ToString();
                    }
                    else
                    {
                        return tem.ToString();
                    }
                }
                else
                {
                    return tem.ToString();
                }
            }
        }
    }
}
