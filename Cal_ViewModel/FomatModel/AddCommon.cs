using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Convert;

namespace Cal_ViewModel.FormatModel
{
    static class AddCommon
    {
        //    public static string MaxContain(string resultValue, bool isNumDef)
        //    {
        //        char[] strs = { '不', '无', '未', '溢' };
        //        if (isNumDef || resultValue == "" || resultValue.IndexOfAny(strs) != -1)
        //            return resultValue;
        //        //科学记数法暂时不作取舍
        //        if (resultValue.Contains("e") || resultValue.Contains("E"))
        //            return DisplayScientficNum(resultValue);
        //        //去掉小数后面多余的0
        //        if (!isNumDef && resultValue.Contains("."))
        //            resultValue = resultValue.TrimEnd('0');
        //        #region 限制输出框最大容纳位数
        //        //判断是否为0.
        //        int index;
        //        if (ToDecimal(resultValue) < 1 && ToDecimal(resultValue) > -1)
        //            index = 1;
        //        else
        //            index = 0;
        //        //有点有负号
        //        if (resultValue.Contains(".") && resultValue.StartsWith("-") && resultValue.Length > index + 18)
        //        {
        //            resultValue = Rounding2(resultValue, index + 18);
        //        }
        //        //有点无负号
        //        else if (resultValue.Length > index + 17 && resultValue.Contains(".") && !resultValue.StartsWith("-"))
        //        {
        //            resultValue = Rounding2(resultValue, index + 17);
        //        }
        //        //无点有负号
        //        else if (resultValue.Length > 17 && !resultValue.Contains(".") && resultValue.StartsWith("-"))
        //        {
        //            resultValue = Rounding2(resultValue, 17);
        //        }
        //        //无点无负号
        //        else if (resultValue.Length > 16 && !resultValue.Contains(".") && !resultValue.StartsWith("-"))
        //        {
        //            resultValue = Rounding2(resultValue, 16);
        //        }

        //        if (!isNumDef)
        //        {
        //            //去掉小数后面多余的0和点
        //            if (resultValue.Contains("."))
        //                resultValue = resultValue.TrimEnd('0');
        //            //去掉尾数的点
        //            if (resultValue.EndsWith("."))
        //                resultValue = resultValue.TrimEnd('.');
        //        }



        //        #endregion
        //        return resultValue;
        //    }

        //    private static string Rounding2(string resultValue, int num)
        //    {
        //        string value1 = resultValue.Substring(0, num);
        //        string value2 = resultValue.Substring(num, 1);
        //        if (resultValue.Substring(num, 1).Equals("."))
        //            value2 = resultValue.Substring(num + 1, resultValue.Length - num - 1);
        //        else
        //            value2 = resultValue.Substring(num, resultValue.Length - num);
        //        value2 = value2.Insert(1, ".");
        //        if (Math.Round(ToDouble(value2), 0) >= 5)
        //        {
        //            string mm = "";
        //            char[] arr = value1.ToCharArray();
        //            for (int i = arr.Length - 1; i >= 0; i--)
        //            {

        //                if (arr[i] == '.')
        //                    continue;
        //                if (arr[i] != '9')
        //                {
        //                    int a = ToInt32(arr[i]) - 47;
        //                    arr[i] = char.Parse(a.ToString());
        //                    break;
        //                }
        //                else
        //                {
        //                    if (i == 0)
        //                    {
        //                        mm = "1";
        //                    }
        //                    arr[i] = '0';
        //                }

        //            }
        //            return mm + new string(arr);
        //        }
        //        else
        //        {
        //            return value1;
        //        }
        //    }

        //    public static string Addcommon(string resultValue)
        //    {
        //        char[] strs = { '不', '无', '未', '溢' };
        //        //科学记数法暂时不作取舍
        //        if (resultValue.Contains("e") || resultValue.IndexOfAny(strs) != -1)
        //            return resultValue;
        //        string integer; //输出框逗号显示部分
        //        if (resultValue.Contains("."))  //处理小数(正小数、负小数)
        //        {
        //            if (resultValue.Contains("-"))
        //            {
        //                resultValue = resultValue.Substring(1, resultValue.Length - 1);
        //                integer = resultValue.Substring(0, resultValue.IndexOf("."));
        //                CommaIndex(ref integer);
        //                return "-" + integer + resultValue.Substring(resultValue.IndexOf("."));
        //            }
        //            else
        //            {
        //                integer = resultValue.Substring(0, resultValue.IndexOf("."));
        //                CommaIndex(ref integer);
        //                return integer + resultValue.Substring(resultValue.IndexOf("."));
        //            }
        //        }
        //        else                         //处理整数(正整数、负整数)
        //        {
        //            if (resultValue.Contains("-"))
        //            {
        //                resultValue = resultValue.Substring(1, resultValue.Length - 1);
        //                integer = resultValue;
        //                CommaIndex(ref integer);
        //                return "-" + integer;
        //            }
        //            else if (resultValue.IndexOfAny(strs) != -1)
        //                return resultValue;
        //            else
        //            {
        //                integer = resultValue;
        //                CommaIndex(ref integer);
        //                return integer;
        //            }
        //        }
        //    }
        //    #region AddCommon方法的子部分，负责计算
        //    private static void CommaIndex(ref string integer)
        //    {
        //        // 3位数以下不要“逗号”
        //        if (integer.Length <= 3)
        //            return;

        //        char[] strs = integer.ToCharArray();
        //        List<char> list = new List<char>();
        //        int len = strs.Length;
        //        for (int i = 0; i < len; i++)
        //        {
        //            list.Add(strs[i]);
        //        }
        //        int index = len / 3 - 1;
        //        for (int i = 0; i <= index; i++)
        //        {
        //            if ((len % 3 == 0) && i == 0)
        //                continue;
        //            if ((len % 3 == 0) && i != 0)
        //            {
        //                list.Insert(i * 3 + i - 1, ',');
        //                continue;
        //            }
        //            list.Insert(len % 3 + i * 3 + i, ',');
        //        }
        //        integer = string.Join("", list.ToArray());
        //    }
        //    #endregion

        //    public static string DisplayScientficNum(string num)
        //    {
        //        string left = num.Substring(0, num.IndexOf("e"));
        //        if (left.Length > 17)
        //            left = Rounding2(left, 17).TrimEnd('0');
        //        return left + num.Substring(num.IndexOf("e"));
        //    }
        //}

        //publicstatic string Addcommon(string underCache)
        //{   //带小数的正则表达式判断
        //    if (underCache.Contains(".") == true)
        //    {
        //        underCache = Regex.Replace(underCache, @"\d+?(?=(?:\d{3})+\.)", "$0,");
        //    }
        //    else
        //    {
        //        underCache = underCache + ".01";
        //        underCache = Regex.Replace(underCache, @"\d+?(?=(?:\d{3})+\.)", "$0,");
        //        string[] sArray = underCache.Split('.');
        //        underCache = sArray.ElementAt(0);
        //    }

        //    return underCache;
        //}

        // 金洲 12.29 NTGO_Q1 重新更换算法逻辑 判断数字的位数
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
            //张桔 12.28 NTGO_Q1 问题解决方式
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



