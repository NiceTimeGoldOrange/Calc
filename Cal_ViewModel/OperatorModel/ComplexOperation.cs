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


            decimal x, y;
            x = 0;
            y = Convert.ToDecimal(num1) / 2;
            while (x != y)
            {
                x = y;
                y = (x + Convert.ToDecimal(num1) / x) / 2;
            }
            return x.ToString();

        }
        public string Squ(string num1)
        {
            return (Convert.ToDouble(num1) * Convert.ToDouble(num1)).ToString();
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
