using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return i1 * i2;
        }
    }
}
