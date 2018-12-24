using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.Enum;

namespace Cal_ViewModel.OperatorModel
{
    public class OperationFactory
    {


        public static IOperator CreatOperator(ArithmeticEnum? oe)
        {
            IOperator oper = null;

            switch (oe)
            {
                case ArithmeticEnum.Add:
                    {
                        oper = new Addition();
                        break;
                    }
                case ArithmeticEnum.Sub:
                    {
                        oper = new Subtract();
                        break;
                    }
                case ArithmeticEnum.Mul:
                    {
                        oper = new Multiply();
                        break;
                    }
                case ArithmeticEnum.Div:
                    {
                        oper = new ();
                        break;
                    }
            }
            return oper;
        }
    }
}
