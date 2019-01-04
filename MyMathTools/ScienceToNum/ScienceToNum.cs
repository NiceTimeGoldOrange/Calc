using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.ScienceToNum
{
    class ScienceToNum
    {
        public static string ScienceToNumber(string i1)
        {
            if (!i1.Contains("E"))
            {
                return i1;
            }
            else
            {
                return Method(i1);
            }
        }

        public static string Method(string num) // 1.2345678912 .34567 e+ 10
        {
            int right = Convert.ToInt32(num.Substring(num.IndexOf('E') + 1));
            if (right > -4 && right < 16)
            {
                num = Decimal.Parse(num, System.Globalization.NumberStyles.Float).ToString();
            }
            else if (right <= -4 && right >= -18)
            {
                decimal num1 = Decimal.Parse(num, System.Globalization.NumberStyles.Float);
                if ((num1.ToString().Length <= 18 && num1 >= 0.00000001m))
                {
                    num = num1.ToString();
                }
            }
            return num;
        }
    }
}
