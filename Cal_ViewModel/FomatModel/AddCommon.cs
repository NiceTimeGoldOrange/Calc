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
            string integer;
            if (underCache.Contains("-") && underCache.Contains(".") && underCache.Length >= 19)
            {
                underCache = underCache.Substring(0, 19);
            }
            else if (!underCache.Contains("-") && underCache.Contains(".") && underCache.Length >= 16)
            {
                underCache = underCache.Substring(0, 16);
            }
            else if (underCache.Contains("-") && !underCache.Contains(".") && underCache.Length >= 17)
            {
                underCache = underCache.Substring(0, 17);
            }
            else if (!underCache.Contains("-") && !underCache.Contains(".") && underCache.Length >= 16)
            {
                underCache = underCache.Substring(0, 16);
            }
            else if (underCache.Contains("除数不能为零"))
            {
                return "除数不能为零";
            }

            if (underCache.Contains("."))
            {
                //判断是否有小数点，只取整数部分
                integer = underCache.Substring(0, underCache.IndexOf("."));
                CommaIndex(ref integer);
                return integer + underCache.Substring(underCache.IndexOf("."));
            }
            else
            {
                integer = underCache;
                CommaIndex(ref integer);
                return integer;
            }



        }
        // AddComma方法的子部分，负责计算
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



