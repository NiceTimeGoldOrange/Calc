using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.OperatorModel
{/// <summary>
/// 百分比
/// </summary>
    public class Percent : IOperator
    {
        public string GetResult(string i1, string i2)
        {
            decimal num1 = decimal.Parse(i1);
            decimal num2 = decimal.Parse(i2);

            decimal num = num1 + num1 * num2 / 100;
            return MyMathTools.MyMath.MyRouding(num.ToString());
        }
    }
}
