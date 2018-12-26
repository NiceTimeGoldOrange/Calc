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
        // 立方
        Cube cube = new Cube();
        // 平方
        Square square = new Square();
        // 倒数
        Inverse inverse = new Inverse();
        // 开方
        Evolution evolution = new Evolution();
        // 正负号
        Minus minus = new Minus();

        Equals eq = new Equals();
        AppendSign sign = new AppendSign();

        public string JudgeSingle(string opt)
        {
            Loading.isNewOperator = false;

            Loading.lastOperator = Loading.currentOperator;
            if (Loading.isEqual)
            {
                Loading.belowText = CalViewModel._disPlayBigText;
            }
            else
            {

                if (opt == "√")
                {
                    // 1.计算器初始化状态
                    if (Loading.belowText == "")
                    {
                        Loading.topText += "√(" + 0 + ")";
                        Loading.belowText = evolution.GetResult("0");
                        Loading.isSingleOper = true;
                    }
                    // 2.
                    else
                    {
                        if (Loading.isSingleOper)
                        {

                        }
                        else
                        {
                            Loading.topText = "√(" + Loading.belowText + ")";
                            Loading.belowText = evolution.GetResult(Loading.belowText);
                        }
                    }
                }
                else if (opt == "x²")
                {
                    // 计算器初始化状态
                    if (Loading.belowText == "")
                    {
                        Loading.topText += "sqr（" + Loading.belowText + ")";
                        Loading.belowText = evolution.GetResult("0");
                        Loading.isSingleOper = true;
                    }
                    // 底部不为空  是否进行过单目运算 
                    else if (!Loading.isSingleOper)
                    {
                        Loading.topText += "sqr(" + Loading.belowText + ")";
                        Loading.belowText = square.MySquare(Loading.belowText);
                        Loading.isSingleOper = true;
                    }
                    else
                    {
                        // 上一个结果是空值
                        if (Loading.lastOperator == "")
                        {
                            Loading.topText = "sqr(" + Loading.topText + ")";
                            Loading.belowText = square.MySquare(Loading.belowText);
                        }
                        else
                        {
                            if (Loading.topText.LastIndexOf(Loading.currentOperator) == Loading.topText.Length - 1)
                            {
                                Loading.topText += "sqr(" + Loading.lastResult + ")";
                                Loading.belowText = square.MySquare(Loading.lastResult);
                            }
                            else
                            {
                                int index = Loading.topText.LastIndexOf(Loading.lastOperator) + 1;
                                string str = Loading.topText.Substring(index, Loading.topText.Length - index);
                                Loading.topText = Loading.topText.Substring(0, index) + ("sqr(" + str + ")");
                                Loading.belowText = square.MySquare(Loading.belowText);
                            }
                        }
                    }
                }
                else if (opt == "⅟x")
                {
                    // 初始化状态
                    if (Loading.belowText == "")
                    {
                        Loading.topText += "1/(" + 0 + ")";
                        Loading.belowText = "除数不能为零";
                        Loading.isSingleOper = true;
                    }
                    else
                    {
                        Loading.topText += "1/(" + Loading.belowText + ")";
                        Loading.belowText = inverse.MyInverse(Loading.belowText);
                    }
                }
                else if (opt == "x³")
                {
                    if (Loading.belowText == "")
                    {
                        Loading.topText += "cube(" + 0 + ")";
                        Loading.belowText = cube.MyCube(Loading.belowText);
                        Loading.isSingleOper = true;
                    }
                    // 有输入数
                    else
                    {
                        if (!Loading.isSingleOper)
                        {
                            Loading.topText += "cube(" + Loading.belowText + ")";
                            Loading.belowText = cube.MyCube(Loading.belowText);
                            Loading.isSingleOper = true;
                        }
                        else
                        {
                            Loading.topText = "cube(" + Loading.belowText + ")";
                            Loading.belowText = cube.MyCube(Loading.belowText);
                            Loading.isSingleOper = true;
                        }
                    }
                }
                else if (opt == "±")
                {
                    // 是否是新操作数
                    if (Loading.isSingleOper)
                    {
                        if (!Loading.isSingleOper)
                        {
                            Loading.topText += "negate(" + CalViewModel._disPlayText + ")";
                            Loading.belowText = minus.MyMinus(CalViewModel._disPlayText);
                            Loading.isSingleOper = true;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        if (Loading.belowText == "")
                        {
                            if (!Loading.isSingleOper)
                            {
                                Loading.topText = "negate(" + 0 + ")";
                                Loading.belowText = "0";
                                Loading.isSingleOper = true;
                            }
                        }
                        else if (Loading.isSingleOper == true && Loading.belowText == "0")
                        {
                            Loading.topText = "negate(" + Loading.topText + ")";
                            Loading.belowText = "0";
                        }
                        else
                        {
                            if (Loading.belowText == "0")
                            {
                                Loading.belowText = minus.MyMinus(Loading.belowText);

                            }
                        }
                    }
                }
                else if(opt == "%")
                {

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
