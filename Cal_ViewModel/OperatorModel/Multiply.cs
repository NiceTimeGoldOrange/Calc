using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.Enum;

namespace Cal_ViewModel
{/// <summary>
/// 乘、平方、立方、正负号
/// 问题：
///     1.较大的乘法的精度问题；
///     2.科学计数法；
/// </summary>
    public class Multiply : IOperator
    {
        public decimal GetResult(decimal i1, decimal i2)
        {
            decimal result = 0;
            result = i1 * i2;
            return result;
        }

        /// <summary>
        /// 乘法算式
        /// </summary>
        /// <param name="num">i1</param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return num + (char)ArithmeticEnum.Mul;
        }
    }
}
