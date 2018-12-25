using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.OperatorModel
{/// <summary>
/// 乘、平方、立方、正负号
/// 问题：
///     1.较大的乘法的精度问题；
///     2.科学计数法；
/// </summary>
    public class Multiply : IOperator
    {
        public string GetResult(string i1, string i2)
        {
            decimal num1 = decimal.Parse(i1);
            decimal num2 = decimal.Parse(i2);
            decimal num = num1 * num2;
            return MyMathTools.MyMath.MyRouding(num.ToString());
        }
    }
}
