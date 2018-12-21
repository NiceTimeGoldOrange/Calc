using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Other
{
    //相反数
    public class Invert : IOthers
    {
        public decimal GetResult(decimal right)
        {
            return 0;
        }
        public string GetResult(string str)
        {
            str = str.StartsWith("-") ? str.Remove(0, 1) : $"-{str}";
            return str;
        }
        public string GetToString(string num)
        {
            return $"negate({num})";
        }
    }
}
