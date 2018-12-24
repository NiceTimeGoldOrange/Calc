using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Tools
{/// <summary>
/// 四舍五入工具类
/// </summary>
    public class Rouding
    {
        public static decimal RoudingTools(decimal i1)
        {
            char[] ch = i1.ToString().ToArray();
            int[] arr = new int[] { ch.Length };
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = int.Parse(ch[i].ToString());
                }
            }

            return i1;
        }
    }
}
