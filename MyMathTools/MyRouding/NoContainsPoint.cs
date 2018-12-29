using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.MyRouding
{/// <summary>
/// 四舍五入，不包含小数点
/// </summary>
    class NoContainsPoint
    {
        public static string NoPoint(string i1)
        {
            if (i1.StartsWith("-"))
            {
                i1 = Method(i1.Substring(1, i1.Length - 1));
            }
            return Method(i1);
        }

        private static string Method(string i1)
        {
            if (i1.Length > 17)
            {
                int i = int.Parse(i1.Substring(16, 1)); // 获取第17位的值
                if (i >= 5)
                {
                    i1 = (BigInteger.Parse(i1.Substring(0, 16)) + 1).ToString();
                }
                else
                {
                    i1 = i1.Substring(0, 16);
                }
            }
            return i1;
        }
    }
}
