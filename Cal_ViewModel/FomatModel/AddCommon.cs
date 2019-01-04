using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cal_ViewModel.FormatModel
{
    static class AddCommon
    {
        //为整数部分添加逗号
        public static string Addcommon(string underCache)
        {
            // NTGO  梁家其 科学计数法、小数不需要添加逗号
            if (underCache.Contains('E'))
            {
                string[] str = underCache.Split('E');
                string newNum = underCache.Substring(0, underCache.IndexOf('E'));
                underCache = MyMathTools.MyMath.MyRouding(str[0]) + "E" + str[1];
            }
            else if (underCache.Contains("."))
            {
                underCache = MyMathTools.MyMath.MyRouding(underCache);
            }
            else
            {
                // NTGO 张桔 为整数添加逗号
                underCache = underCache + ".01";
                underCache = Regex.Replace(underCache, @"\d+?(?=(?:\d{3})+\.)", "$0,");
                string[] sArray = underCache.Split('.');
                underCache = sArray.ElementAt(0);
                if(underCache.Length > 21)
                {
                    // 9,999,999,999,999,999
                    underCache = underCache.Substring(0, 21);
                    string[] strArr = underCache.Split(',');
                    string str = "";
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        str += strArr[i];
                    }
                    str = str + ".01";
                    str = Regex.Replace(underCache, @"\d+?(?=(?:\d{3})+\.)", "$0,");
                    string[] s1Array = underCache.Split('.');
                    underCache = s1Array.ElementAt(0);
                }
            }
            return underCache;
        }

        // AddCommon方法的子部分，负责计算
        private static void CommaIndex(ref string integer)
        {
            //整数部分3个以下不需要加逗号
            if (integer.Length <= 3)
            { return; }

            if (integer.Contains("-"))
            {
                integer = integer.Substring(1, integer.Length - 1);
                char[] strs = integer.ToCharArray();
                List<char> list = new List<char>();
                int len = strs.Length;
                for (int i = 0; i < len; i++)
                {
                    list.Add(strs[i]);
                }
                int index = len / 3 - 1;
                for (int i = 0; i <= index; i++)
                {
                    if ((len % 3 == 0) && i == 0)
                        continue;
                    if ((len % 3 == 0) && i != 0)
                    {
                        list.Insert(i * 3 + i - 1, ',');
                        continue;
                    }
                    list.Insert(len % 3 + i * 3 + i, ',');
                }
                integer = string.Join("", list.ToArray());
                integer = "-" + integer;
            }
            else
            {
                char[] strs = integer.ToCharArray();
                List<char> list = new List<char>();
                int len = strs.Length;
                for (int i = 0; i < len; i++)
                {
                    list.Add(strs[i]);
                }
                int index = len / 3 - 1;
                for (int i = 0; i <= index; i++)
                {
                    if ((len % 3 == 0) && i == 0)
                        continue;
                    if ((len % 3 == 0) && i != 0)
                    {
                        list.Insert(i * 3 + i - 1, ',');
                        continue;
                    }
                    list.Insert(len % 3 + i * 3 + i, ',');
                }
                integer = string.Join("", list.ToArray());
            }
        }
    }
}



