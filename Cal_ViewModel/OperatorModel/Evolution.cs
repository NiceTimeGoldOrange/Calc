using MyMathTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.OperatorModel
{/// <summary>
/// 开方
/// </summary> 
    public class Evolution : IOperator
    {
        public string GetResult(string i1, string i2 = "1")
        {
            decimal num = decimal.Parse(i1) * decimal.Parse(i2);

            return MyMath.MySqrt(num.ToString());
        }
    }
}
