using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Tools
{/// <summary>
/// 自定义数学方法
/// </summary>
    class MyMath
    {/// <summary>
    /// 四舍五入方法，若需要进行此步运算，则说明数字个数已经大于16位，最少为17位
    /// </summary>
    /// <param name="i1"></param>
    /// <returns></returns>
        public static decimal RoudingTools(decimal i1)
        {
            i1 = 0.12345678945678965m;
            string num = i1.ToString();
            //截取字符串的第18位
            string temp = num.Substring(num.Length - 1, num.Length);
            if(int.Parse(temp) >= 5)
            {
                //为倒数第二位数字加1
                string temp2 = num.Substring(num.Length - 2, num.Length - 1);
                int i2 = int.Parse(temp2) + 1;
            }
            return i1;
        }







        //public static decimal GetSqrt(decimal i1)
        //{
        //    if(i1 < 0)
        //    {
        //        Console.WriteLine("无效输入");
        //    }
        //    else
        //    {

        //    }
        //}
    }
}
