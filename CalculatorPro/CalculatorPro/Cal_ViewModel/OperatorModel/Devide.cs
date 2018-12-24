using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Operator
{/// <summary>
/// 除、倒数
/// 问题:
///    1. 限制前台输入的数字的长度
///    2. 四舍五入（通过工具类解决） 
///    3. 科学计数法
/// </summary>
    public class Devide : IOperator
    {
        public decimal GetResult(decimal i1, decimal i2)
        {
            return i1 / i2;
        }
    }
}
