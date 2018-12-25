using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.RoudingTools
{
    class No_Point
    {
        public static string NPoint(string i1) // 1234567891234567,5852
        {
            if (i1.Length > 16)
            {
                string str = i1.Substring(16, 1);
                // 第17位数值大于5
                if (int.Parse(str) >= 5)
                {
                    BigInteger newNum = BigInteger.Parse(i1.Substring(0, 16)) + 1; // 1234567891234568
                    i1 = newNum.ToString().Insert(1, ".") + "e+" + (i1.Length - 1).ToString();
                }
                else
                {
                    i1 = i1.Substring(0, 16).Insert(1, ".") + "e+" + (i1.Length - 1);
                }
            }
            return i1;
        }
    }
}
