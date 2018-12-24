using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Operator
{/// <summary>
/// 百分比
/// </summary>
    public class Percent : IOperator
    {
        public decimal GetResult(decimal i1, decimal i2)
        {
            return i1 + i1 * i2 / 100;
        }

        public static void Main(string[] args)
        {
            Percent p = new Percent();
            Console.WriteLine(p.GetResult(2m, 3m));
            Console.ReadKey();
        }
    }
}
