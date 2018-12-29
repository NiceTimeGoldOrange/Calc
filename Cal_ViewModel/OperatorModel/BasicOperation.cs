using MyMathTools.NumToSci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.OperatorModel
{
    public class Basic_Opreation
    {
        public string Add(string num1, string num2)
        {
            //if(num1.Contains())

            return MyMathTools.MyMath.MyRouding((BigInteger.Parse(num1) + BigInteger.Parse(num2)).ToString());
        }

        public string Sub(string num1, string num2)
        {

            return MyMathTools.MyMath.MyRouding((Convert.ToDecimal(num1) - Convert.ToDecimal(num2)).ToString());
        }

        public string Mul(string num1, string num2)
        {
            if (num1.Contains("E") || num2.Contains("E"))
            {
                return Science.Multiply(num1, num2);
            }
            else
            {
                return MyMathTools.MyMath.MyRouding((Convert.ToDecimal(num1) * Convert.ToDecimal(num2)).ToString());
            }
        }

        public string Div(string num1, string num2)
        {
            if (num2 == "0")
            {
                return "除数不能为零";
            }
            return MyMathTools.MyMath.MyRouding((Convert.ToDecimal(num1) / Convert.ToDecimal(num2)).ToString());
        }
    }
}
