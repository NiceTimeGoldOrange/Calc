using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.RoudingTools
{
    class Rouding
    {
        public static string MyRouding(string i1)
        {
            if (i1.Contains("."))
            {
                i1 = ContainsPoint.ContainPoint(i1);
            }
            else
            {
                i1 = NoContainsPoint.NoContainPoint(i1);
            }
            return i1;
        }
    }
}
