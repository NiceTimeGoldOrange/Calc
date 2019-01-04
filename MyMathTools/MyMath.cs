using MyMathTools.RoudingTools;
using MyMathTools.ScienceNum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools
{
    public class MyMath
    {
        // 平方根
        public static string Sqrt(string i1)
        {
            return MySqrt.MySqrt.GetSqrt(i1);
        }

        //四舍五入
        public static string MyRouding(string i1)
        {
            return Rouding.MyRouding(i1);
        }

        // 数值到科学计数法
        public static string ScienceNum(string i1)
        {

            return Science.MySciToNum(i1);
        }

        // 科学计数法到数值
        public static string NumToScience(string i1)
        {
            return ScienceToNum.ScienceToNum.ScienceToNumber(i1);
        }
    }
}
