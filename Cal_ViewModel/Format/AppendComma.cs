using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cal_ViewModel.Format
{
    
    class AppendComma
    {
        //三位分节法 ，添加逗号
        public static string TrisectionMethod(String str)
        {
            //带小数的正则表达式判断
            if (str.Contains(".") == true)
            {
                str = Regex.Replace(str, @"\d+?(?=(?:\d{3})+\.)", "$0,");
            }
            else
            {
                str = str + ".01";
                str = Regex.Replace(str, @"\d+?(?=(?:\d{3})+\.)", "$0,");
                string[] sArray = str.Split('.');
                str = sArray.ElementAt(0);
            }
            return str;
        }
    }
}
