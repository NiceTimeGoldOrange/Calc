using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Exceptions
{
    public class CalcException : Exception
    {
        private string message;

        public CalcException(string exceptionMessage) : base(exceptionMessage)
        {
            message = exceptionMessage;
        }

        public override string ToString()
        {
            return message;
        }
    }
}
