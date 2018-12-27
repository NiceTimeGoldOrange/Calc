using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.ChangeFactory
{/// <summary>
/// 添加正负号，不改变数值的 值，只改变数值的正负
/// </summary>
    class AppendSign
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
