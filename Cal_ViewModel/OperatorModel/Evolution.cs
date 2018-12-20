using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Operator
{/// <summary>
/// 开方
/// 问题：
///     1. 自带的开方方法，无法满足精度，自己写一个开方的方法；
/// </summary>
    public class Evolution : IOperator
    {
        public decimal GetResult(decimal i1, decimal i2 = 1)
        {
            return (decimal)Math.Sqrt((double)(i1 * i2));
        }
    }
}
