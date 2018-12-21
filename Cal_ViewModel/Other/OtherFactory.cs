using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.Enum;

namespace Cal_ViewModel.Other
{
    public class OtherFactory
    {
        public static IOthers CreateSpecialOperation(OtherEnum? se)
        {
            IOthers spo = null;

            switch (se)
            {
                case OtherEnum.Square:
                    {
                        spo = new Square();
                        break;
              
                case OtherEnum.Reciprocal:
                    {
                        spo = new Reciprocal();
                        break;
                    }
               
                case OtherEnum.Invert:
                    {
                        spo = new Invert();
                        break;
                    }
            }
            return spo;
        }
    }
}
