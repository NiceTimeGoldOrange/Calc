using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.NumToSci
{
    class NoContainsPoint
    {
        public static string NoContainPoint(string i1)
        {
            if (i1.Contains("e"))
            {
                return i1;
            }
            else
            {
                return Method(i1);
            }
        }

        private static string Method(string i1)
        {
            string result = "";
            // 正数
            if (i1.Contains("-"))
            {
                if (i1.Length > 16)
                {
                    result = i1.Insert(1, ".") + "e+" + (i1.Length - 1);
                }
                return i1;
            }

            // 负数
            else
            {
                if (i1.Length > 17)
                {
                    result = "-" + i1.Substring(1, i1.Length - 1) + "e+" + (i1.Length - 1);
                }
            }
            return result;
        }
    }
}
