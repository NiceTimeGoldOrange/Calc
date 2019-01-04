using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.RoudingTools
{
    class NoContainsPoint
    {
        public static string NoContainPoint(string i1)
        {
            if (i1.StartsWith("-"))
            {
                i1 = Method(i1.Substring(1, i1.Length - 1));
            }
            return Method(i1);
            //if (i1.Contains("e") || i1.Contains("E"))
            //{
            //    return i1;
            //}
            //else
            //{
            //    return Method(i1);
            //}
        }

        private static string Method(string i1)
        {
            if (i1.Length > 16)
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
