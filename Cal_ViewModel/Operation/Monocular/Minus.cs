using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Operation.Monocular
{
    class Minus
    {
        public string MyMinus(string i1)
        {
            return (-decimal.Parse(i1)).ToString();
        }
    }
}
