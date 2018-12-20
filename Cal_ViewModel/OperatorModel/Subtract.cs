using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel
{/// <summary>
/// 减、内存减
/// </summary>
    public class Subtract : IOperator
    {
        public decimal GetResult(decimal i1, decimal i2)
        {
            return i1 - i2;
        }
    }
}
