using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.ScienceNum
{
    class NoContainsPoint
    {
        public static string NoContainPoint(string i1)
        {
            if (i1.Contains("E"))
            {
                return i1;
            }
            return Method(i1);
        }

        private static string Method(string i1)
        {
            string result = "";
            // 正数
            if (!i1.Contains("-"))
            {
                //if (i1.Length > 16)
                //{
                result = i1.Insert(1, ".") + "E+" + (i1.Length - 1);
                //}
                //else
                //{
                //    result = i1;
                //}
            }
            // 负数
            else
            {
                //if (i1.Length > 17)
                //{
                result = "-" + i1.Substring(1, i1.Length - 1) + "E+" + (i1.Length - 1);
                //}
                //else
                //{
                //    result = i1;
                //}
            }
            return result;
        }
    }
}
