using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Other
{
    public class Square : IOthers
    {
        public decimal GetResult(decimal  i2)
        {
            decimal result = 0;
            result = i2 * i2;
            return result;
        }

        public string GetToString(string num)
        {
            return $"sqr({num})";
        }
    }
}
