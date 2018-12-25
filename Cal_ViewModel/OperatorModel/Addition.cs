using Cal_ViewModel.OperatorModel;
using MyMathTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Operator
{/// <summary>
/// 加、内存加
/// 问题：
///     限制输入的数字的长度
/// </summary>
    public class Addition : IOperator
    {
        public string GetResult(string i1, string i2)
        {
            decimal num1 = decimal.Parse(i1);
            decimal num2 = decimal.Parse(i2);

            return MyMath.MyRouding(decimal.Add(num1, num2).ToString());
        }
    }
}
