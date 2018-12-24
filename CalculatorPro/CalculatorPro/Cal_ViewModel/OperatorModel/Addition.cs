using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel
{/// <summary>
/// 加、内存加
/// 问题：
///     限制输入的数字的长度
/// </summary>
    public class Addition : IOperator
    {
        public decimal GetResult(decimal i1, decimal i2)
        {
            return i1 + i2;
        }
    }
}
