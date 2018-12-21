using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Operator
{/// <summary>
/// 百分比
/// </summary>
    public class Percent : IOperator
    {
        public decimal GetResult( decimal i2)
        {
            return 0;
        }

        /// <summary>
        /// 重载计算方法
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        public decimal GetResult(decimal i1, decimal i2)
        {
            return (i1 * i2) / 100;
        }

        /// <summary>
        /// 百分号算式
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return num;
        }


    }
}
