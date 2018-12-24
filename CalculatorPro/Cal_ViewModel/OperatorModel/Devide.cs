using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.Enum;
using Cal_ViewModel.Exceptions;

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
       
        
        /// <summary>
        /// 除法计算
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
         public decimal GetResult(decimal i1, decimal i2)
        {
            decimal result = 0;

            if (i1 == 0 && i2 == 0)
            {
                throw new CalcException("结果未定义");
            }
            else if (i2!= 0)
            {
                result =( i1 / i2);
            }
            else
            {
                throw new CalcException("除数不能为零");
            }
            return result;
        }

        /// <summary>
        /// 除法算式
        /// </summary>
        /// <param name="num">i1</param>
        /// <returns></returns>
        public string GetToString(string num)
        {
            return num + (char)ArithmeticEnum.Div;
        }
    }
}
 
