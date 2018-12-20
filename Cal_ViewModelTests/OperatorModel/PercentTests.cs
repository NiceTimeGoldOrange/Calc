using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cal_ViewModel.Operator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Operator.Tests
{
    [TestClass()]
    public class PercentTests
    {
        [TestMethod()]
        public void GetResultTest()
        {
            Percent p = new Percent();
            Console.WriteLine(p.GetResult(2m, 3m));
            Console.ReadKey();
        }
    }
}