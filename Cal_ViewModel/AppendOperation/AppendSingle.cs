using Cal_ViewModel.AppendOperation.AppendSingle;
using Cal_ViewModel.Judge;
using Cal_ViewModel.Operation.Monocular;
using Cal_ViewModel.OperatorModel;
using History_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.ChangeFactory
{/// <summary>
/// 添加单目运算
/// </summary>
    class AppendSingle : IJudgeForSingle
    {
        public string JudgeSingle(string opt)
        {
            Loading.singleCount++;
            Loading.isNewOperator = true;

            Loading.lastOperator = Loading.currentOperator;
            // 进行过等于运算，将结果赋给belowText
            if (Loading.isEqual)
            {
                Loading.belowText = CalViewModel._disPlayBigText;
                Loading.isNewOperator = true;
                Loading.isMinus = true;
                Loading.isSingleOper = false;
            }
            // 判断单目运算符
            else
            {

                if (opt == "√")
                {
                    MyEvolution.MyEvo(opt);
                }
                else if (opt == "x²")
                {
                    MySquare.MySqr(opt);
                }
                else if (opt == "⅟x")
                {
                    MyInverse.MyInve(opt);
                }
                else if (opt == "x³")
                {
                    MyCube.Mycube(opt);
                }
                else if (opt == "±")
                {
                    MyInverse.MyInve(opt);
                }
                else if (opt == "%")
                {
                    MyPercnet.Percent(opt);
                }
            }
            if (Loading.isEqual)
            {
                Loading.isEqual = false;
                Loading.isNewNum = true;
                Loading.lastOperator = "";
                Loading.currentOperator = "";
            }
            Loading.isNewNum = true;
            return Loading.topText;
        }
    }
}
