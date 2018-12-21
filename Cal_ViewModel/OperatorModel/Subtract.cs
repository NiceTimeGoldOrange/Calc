using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.Enum;

namespace Cal_ViewModel
{/// <summary>
/// 减、内存减
/// </summary>
    public class Subtract : IOperator
    {
        public decimal GetResult(decimal i1, decimal i2)
        {
            decimal result = 0;
            result = i1 - i2;
            return result;
        }

        /// <summary>
        /// 减法算式
        /// </summary>
        /// <param name="num">i1</param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return num + (char)ArithmeticEnum.Sub;
        }
    }
}
