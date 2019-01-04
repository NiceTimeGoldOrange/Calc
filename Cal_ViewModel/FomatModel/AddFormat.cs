using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.FormatModel
{
    static class AddFormat
    {
        public static string Addformat(string temp)
        {
            // NTGO 梁家其 1.3 当科学计数法最后为0时，不显示0，添加判断 
            if (temp.Contains(".") && !temp.Contains("E"))
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
