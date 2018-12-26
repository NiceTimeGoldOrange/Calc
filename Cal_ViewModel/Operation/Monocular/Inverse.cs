using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Operation.Monocular
{/// <summary>
/// 倒数
/// </summary>
    class Inverse
    {
        public string MyInverse(string i1)
        {
            if (i1 == "0")
            {
                return "除数不能为零";
            }
            else
            {
                decimal result = decimal.Parse("1") / decimal.Parse(i1);
                return MyMathTools.MyMath.MyRouding(result.ToString());
            }
        }
    }
}
