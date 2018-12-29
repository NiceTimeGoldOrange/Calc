using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools.MyRouding
{
    class Rouding
    {
        public static string MyRouding(string i1)
        {
            if (i1.Contains("."))
            {
               i1 = ContainPoint.ContainsPoint(i1);
            }
            else
            {
                i1 = NoContainsPoint.NoPoint(i1);
            }
            return i1;
        }
    }
}
