using MyMathTools.MyRouding;
using MyMathTools.MySqrt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools
{ /// <summary>
  /// 自定义数学工具类
  ///     1.四舍五入 + 科学计数法；
  ///     2.开平方。
  /// </summary>
    public class MyMath
    {
        // 四舍五入
        public static string MyRouding(string i1)
        {
            return Rouding.MyRouding(i1);
        }

        // 开平方
        public static string MySqrt(string i1)
        {
            return Sqrt.GetSqrt(i1);
        }

        // 数值变科学计数法
        public static string MyNumToSci(string i1)
        {
            return NumToSci.Science.MySciToNum(i1);
        }

        // 科学计数法变数值
        public static string MySciToNum(string i1)
        {
            return SciToNum.ScienceToNum.ScienceToNumber(i1);
        }
    }
}
