using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.MySqrt
{
    class Sqrt
    {
        public static string GetSqrt(string i1)
        {
            decimal x = decimal.Parse(i1);
            //牛顿法
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
                if ((int)tem == Math.Sqrt((int)x))
                {
                    return ((int)tem).ToString();
                }
                else
                {
                    return tem.ToString();
                }
            }
        }
    }
}
