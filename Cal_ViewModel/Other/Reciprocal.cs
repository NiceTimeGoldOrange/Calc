using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.Exceptions;

namespace Cal_ViewModel.Other
{

    /// <summary>
    /// 倒数
    /// </summary>
    public class Reciprocal : IOthers
    {
        /// <summary>
        /// 重载的计算方法
        /// </summary>
        /// <param name="i2"></param>
        /// <returns></returns>
        public decimal GetResult(decimal i2)
        {
            decimal result = 0;
            if (i2 == 0)
            {
                throw new CalcException("除数不能为零");
            }
            else
            {
                result = 1 / i2;
            }
            return result;
        }

        /// <summary>
        /// 倒数算式
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return $"reciproc({num})";
        }
    }
}


