using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.OperatorModel
{
    public class Complex_Operation
    {

        public string Sqrt(string num1)
        {
            return MyMathTools.MyMath.MySqrt(num1);
        }

        public string Squ(string num1)
        {
            if (num1.Contains("."))
            {
               string[] strArr = num1.Split('E');
               num1 = MyMathTools.MyMath.MyRouding((decimal.Parse(strArr[0]) * decimal.Parse(strArr[0])).ToString());

            }

            return MyMathTools.MyMath.MyRouding((Convert.ToDouble(num1) * Convert.ToDouble(num1)).ToString());
        }

        public string Cube(string num1)
        {
            return (Convert.ToDecimal(num1) * Convert.ToDecimal(num1) * Convert.ToDecimal(num1)).ToString();
        }

        public string OneCent(string num1)
        {
            if ("0".Equals(num1))
            {
                return "除数不能为零";
            }
            else
            {
                return (1 / Convert.ToDecimal(num1)).ToString();
            }


        }

        public string Minus(string num1)
        {
            return (-Convert.ToDecimal(num1)).ToString();
        }
    }
}
