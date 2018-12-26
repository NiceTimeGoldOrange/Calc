using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Format
{
    class AppendFormat
    {
        public static string Addformat(string temp)
        {
            if (temp.Contains("."))
            {
                temp = temp.TrimEnd('0');
                if (temp.EndsWith("."))
                {
                    temp = temp.Substring(0, temp.Length - 1);
                }
            }
            return temp;
        }
    }
}
