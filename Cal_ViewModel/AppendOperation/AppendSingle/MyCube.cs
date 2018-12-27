using Cal_ViewModel.OperatorModel;
using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.AppendOperation.AppendSingle
{/// <summary>
/// 立方
/// </summary>
    class MyCube
    {
        public static void Mycube(string opt)
        {
            Cube cube = new Cube();
            if (Loading.belowText == "")
            {
                Loading.topText += "cube(" + "0" + ")";
                Loading.belowText = cube.MyCube("0");
                Loading.isSingleOper = true;
            }
            // 有输入数
            else if (!Loading.isSingleOper)
            {
                Loading.topText += "cube(" + Loading.belowText + ")";
                Loading.belowText = cube.MyCube(Loading.belowText);
                Loading.isSingleOper = true;
            }
            else
            {
                if ("" == Loading.lastOperator)
                {
                    Loading.topText += "cube(" + Loading.topText + ")";
                    Loading.belowText = cube.MyCube(Loading.belowText);
                }
                else
                {
                    if (Loading.topText.LastIndexOf(Loading.currentOperator) == Loading.topText.Length - 1)
                    {
                        Loading.topText += "cube(" + Loading.lastResult + ")";
                        Loading.belowText = cube.MyCube(Loading.belowText);
                    }
                    else
                    {
                        int index = Loading.topText.LastIndexOf(Loading.currentOperator) + 1;
                        string str = Loading.topText.Substring(index, Loading.topText.Length - index);
                        Loading.topText = Loading.topText.Substring(0, index) + ("cube(" + str + ")");
                        Loading.belowText = cube.MyCube(Loading.belowText);
                        Loading.belowText = cube.MyCube(Loading.belowText);
                    }
                }
            }
        }
    }
}
