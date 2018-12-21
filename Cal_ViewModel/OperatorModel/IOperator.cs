using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel
{
    public interface IOperator
    
     {
        /// <summary>
        /// 运算的抽象方法
        /// </summary>
        /// <param name="i1">i1</param>
        /// <param name="i2">i2</param>
        /// <returns></returns>
        decimal GetResult(decimal i1, decimal i2);

    /// <summary>
    /// 获得算式的抽象方法
    /// </summary>
    /// <param name="num">i1</param>
    /// <returns></returns>
       string GetToString(string num);
}
}


