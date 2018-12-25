using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.ChangeFactory
{/// <summary>
/// 正负号运算
/// </summary>
    class ChangeSign
    {
        public string GetStatus()
        {
            if (Loading.isMinus)
            {
                Loading.belowText = "-" + Loading.belowText;
                Loading.isMinus = false;
                return Loading.belowText;
            }
            else
            {
                Loading.belowText = Loading.belowText.Substring(1, Loading.belowText.Length - 1);
                Loading.isMinus = true;
                return Loading.belowText;
            }
        }
    }
}
