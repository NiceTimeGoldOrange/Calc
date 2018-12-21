using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.Enum;

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
            decimal result = 0;
            result = i1 + i2;
            return result;
        }
        public string GetToString(string num)
        {
            return num + (char)ArithmeticEnum.Add;
        }
    }
}
