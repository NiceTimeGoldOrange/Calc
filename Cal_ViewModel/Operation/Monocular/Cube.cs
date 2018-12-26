using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.OperatorModel
{/// <summary>
/// 立方运算
/// </summary>
    class Cube
    {
        public string MyCube(string i1)
        {
            string result = MyMathTools.MyMath.MyRouding((decimal.Parse(i1) * decimal.Parse(i1) * decimal.Parse(i1)).ToString());
            return result;
        }
    }
}
