using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.Exceptions;

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
           decimal result = 0;
            if (i1 < 0)
            {
                throw new CalcException("无效输入");
            }
            else
            {
                result = Math.Sqrt(i1);
                return result;
            }
        }
}
