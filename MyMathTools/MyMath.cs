using MyMathTools.MySqrt;
using MyMathTools.RoudingTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools
{/// <summary>
/// 自定义数学工具类
///     1.四舍五入 + 科学计数法；
///     2.开平方。
/// </summary>
    public class MyMath
    {
        // 四舍五入 + 科学计数法
        public static string MyRouding(string i1)
        {
            string result = "";
            if (i1.Contains("."))
            {
                result = Con_Point.Point(i1);
            }
            else
            {
                result = No_Point.NPoint(i1);
            }
            return result;
        }

        // 开平方
        public static string MySqrt(string i1)
        {
            return MyRouding(Sqrt.GetSqrt(i1).ToString());
        }
    }
}
