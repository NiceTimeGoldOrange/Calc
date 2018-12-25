using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.OperatorModel
{
    interface IOperator
    {
        string GetResult(string i1, string i2);
    }
}
