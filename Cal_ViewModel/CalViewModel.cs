using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using Cal_ViewModel.SaveModel;
using Cal_ViewModel.AddNumber;
using Cal_ViewModel.JudgeModel;
using Cal_ViewModel.TypeModel;
using Cal_ViewModel.FormatModel;
using System.Collections.ObjectModel;
using Infrastructure;
using MyMathTools.ScienceNum;
using System.Diagnostics;

namespace Cal_ViewModel
{
    public class CalViewModel : NotifyObject
    {   //输入框
        public static string _disPlayBigText = "0";//初始为0的底部框子
        public static string _disPlayText = "";//
        string stri;

        AddNumber.NumberOneToNine addNum = new AddNumber.NumberOneToNine();
        AddNumber.NumberZero addNum0 = new AddNumber.NumberZero();
        AddNumber.Dot addDot = new AddNumber.Dot();
        AddOperator addOperator = new AddOperator();
        AddSymbol addSymbol = new AddSymbol();
        AddSingle addSingle = new AddSingle();
        Memory myMemory = new Memory();
        Equals eq = new Equals();
        History_Memory his = new History_Memory();
        Memory mem = new Memory();
        public string DisPlayBigText
        {
            get
            {
                return _disPlayBigText;
            }
            set
            {
                SetPropertyNotify(ref _disPlayBigText, value, nameof(DisPlayBigText));
            }
        }

        public string DisPlayText
        {
            get
            {
                return _disPlayText;
            }
            set
            {
                SetPropertyNotify(ref _disPlayText, value, nameof(DisPlayText));
            }
        }

        private readonly NVCommand _addCommand;
        public NVCommand AddCommand                          //加
        {
            get => _addCommand;
        }

        private readonly NVCommand _subtractCommand;
        public NVCommand SubtractCommand                    //减
        {
            get => _subtractCommand;
        }

        private readonly NVCommand _multiplyCommand;
        public NVCommand MultiplyCommand                   //乘
        {
            get => _multiplyCommand;
        }

        private readonly NVCommand _divideCommand;
        public NVCommand DivideCommand                   //除
        {
            get => _divideCommand;
        }

        //创建添加数字addNum的委托
        private readonly NVCommand _num1Command;
        public NVCommand Num1Command
        {
            get => _num1Command;
        }

        private readonly NVCommand _num2Command;
        public NVCommand Num2Command
        {
            get => _num2Command;
        }

        private readonly NVCommand _num3Command;
        public NVCommand Num3Command
        {
            get => _num3Command;
        }

        private readonly NVCommand _num4Command;
        public NVCommand Num4Command
        {
            get => _num4Command;
        }

        private readonly NVCommand _num5Command;
        public NVCommand Num5Command
        {
            get => _num5Command;
        }

        private readonly NVCommand _num6Command;
        public NVCommand Num6Command
        {
            get => _num6Command;
        }

        private readonly NVCommand _num7Command;
        public NVCommand Num7Command
        {
            get => _num7Command;
        }

        private readonly NVCommand _num8Command;
        public NVCommand Num8Command
        {
            get => _num8Command;
        }

        private readonly NVCommand _num9Command;
        public NVCommand Num9Command
        {
            get => _num9Command;
        }

        private readonly NVCommand _num0Command;
        public NVCommand Num0Command
        {
            get => _num0Command;
        }

        private readonly NVCommand _percentOneCommand;
        public NVCommand PercentOneCommand              //%
        {
            get => _percentOneCommand;
        }

        private readonly NVCommand _squareCommand;
        public NVCommand SquareCommand                  //平方
        {
            get => _squareCommand;
        }
        private readonly NVCommand _cubeCommand;
        public NVCommand CubeCommand                  //平方
        {
            get => _cubeCommand;
        }

        private readonly NVCommand _inverseCommand;
        public NVCommand InverseCommand               //加减号 
        {
            get => _inverseCommand;
        }

        private readonly NVCommand _radicalCommand;
        public NVCommand RadicalCommand              // 开方
        {
            get => _radicalCommand;
        }
        private readonly NVCommand _reciprocalCommand;
        public NVCommand ReciprocalCommand             //倒数
        {
            get => _reciprocalCommand;
        }

        private readonly NVCommand _clearAllCommand;
        public NVCommand ClearAllCommand                       //C
        {

            get => _clearAllCommand;
        }

        private readonly NVCommand _clearPreCommand;
        public NVCommand ClearPreCommand                       //CE
        {
            get => _clearPreCommand;
        }

        private readonly NVCommand _delCommand;
        public NVCommand DelCommand                       //删除 
        {
            get => _delCommand;
        }

        private readonly NVCommand _dotCommand;
        public NVCommand DotCommand                    //小数点
        {
            get => _dotCommand;
        }

        private readonly NVCommand _equalsCommand;
        public NVCommand EqualsCommand                //=
        {
            get => _equalsCommand;
        }
        private readonly NVCommand btn_ms;
        public NVCommand Btn_ms                        //MS
        {
            get => btn_ms;
        }
        private readonly NVCommand btn_mc;
        public NVCommand Btn_mc                       //MC
        {
            get => btn_mc;
        }
        private readonly NVCommand btn_mr;
        public NVCommand Btn_mr                       //MR
        {
            get => btn_mr;
        }
        private readonly NVCommand btn_minus;
        public NVCommand Btn_minus                    //M-
        {
            get => btn_minus;
        }
        private readonly NVCommand btn_plus;
        public NVCommand Btn_plus                     //M+
        {
            get => btn_plus;
        }
        private readonly NVCommand btn_clearHistory;
        public NVCommand Btn_clearHistory            //清除历史记录那个垃圾桶
        {
            get => btn_clearHistory;
        }

        public CalViewModel()
        {
            _addCommand = new NVCommand(AddHandler);
            _subtractCommand = new NVCommand(SubtractHandler);
            _multiplyCommand = new NVCommand(MultiplyHandler);
            _divideCommand = new NVCommand(DivideHandler);
            //实现委托
            _num1Command = new NVCommand(Num1Handler);
            _num2Command = new NVCommand(Num2Handler);
            _num3Command = new NVCommand(Num3Handler);
            _num4Command = new NVCommand(Num4Handler);
            _num5Command = new NVCommand(Num5Handler);
            _num6Command = new NVCommand(Num6Handler);
            _num7Command = new NVCommand(Num7Handler);
            _num8Command = new NVCommand(Num8Handler);
            _num9Command = new NVCommand(Num9Handler);
            _num0Command = new NVCommand(Num0Handler);
            _percentOneCommand = new NVCommand(PercentOneHandler);
            _squareCommand = new NVCommand(SquareHandler);
            _inverseCommand = new NVCommand(InverseHandler);
            _reciprocalCommand = new NVCommand(ReciprocalHandler);
            _radicalCommand = new NVCommand(RadicalHandler);
            _clearAllCommand = new NVCommand(ClearAllHandler);
            _clearPreCommand = new NVCommand(ClearPreHandler);
            _delCommand = new NVCommand(DelHandler);
            _equalsCommand = new NVCommand(EqualsHandler);
            _dotCommand = new NVCommand(DotHandler);
            _cubeCommand = new NVCommand(CubeHandler);
            btn_ms = new NVCommand(MS);
            btn_mc = new NVCommand(MC);
            btn_mr = new NVCommand(MR);
            btn_minus = new NVCommand(MMinus);
            btn_plus = new NVCommand(MPlus);
            btn_clearHistory = new NVCommand(ClearHistory);
        }

        private void AddHandler()
        {
            DisPlayText = addOperator.JudgeOperator("＋");
            DisPlayBigText = AddFormat.Addformat(AddCommon.Addcommon(Cache.underCache));
        }

        private void SubtractHandler()
        {
            DisPlayText = addOperator.JudgeOperator("－");
            DisPlayBigText = AddFormat.Addformat(AddCommon.Addcommon(Cache.underCache));
        }

        private void MultiplyHandler()
        {
            DisPlayText = addOperator.JudgeOperator("×");
            DisPlayBigText = AddFormat.Addformat(AddCommon.Addcommon(Cache.underCache));
        }

        private void DivideHandler()
        {
            DisPlayText = addOperator.JudgeOperator("÷");
            DisPlayBigText = AddFormat.Addformat(AddCommon.Addcommon(Cache.underCache));
        }

        //添加添加0-9数字的方法
        private void Num1Handler()
        {
            DisPlayBigText = AddCommon.Addcommon(addNum.Judgefornumber("1"));
            DisPlayText = Cache.topCache;
        }
        private void Num2Handler()
        {
            DisPlayBigText = AddCommon.Addcommon(addNum.Judgefornumber("2"));
            DisPlayText = Cache.topCache;
        }
        private void Num3Handler()
        {

            DisPlayBigText = AddCommon.Addcommon(addNum.Judgefornumber("3"));
            DisPlayText = Cache.topCache;
        }
        private void Num4Handler()
        {
            DisPlayBigText = AddCommon.Addcommon(addNum.Judgefornumber("4"));
            DisPlayText = Cache.topCache;
        }
        private void Num5Handler()
        {
            DisPlayBigText = AddCommon.Addcommon(addNum.Judgefornumber("5"));
            DisPlayText = Cache.topCache;
        }
        private void Num6Handler()
        {
            DisPlayBigText = AddCommon.Addcommon(addNum.Judgefornumber("6"));
            DisPlayText = Cache.topCache;
        }
        private void Num7Handler()
        {
            DisPlayBigText = AddCommon.Addcommon(addNum.Judgefornumber("7"));
            DisPlayText = Cache.topCache;
        }
        private void Num8Handler()
        {
            DisPlayBigText = AddCommon.Addcommon(addNum.Judgefornumber("8"));
            DisPlayText = Cache.topCache;

        }
        private void Num9Handler()
        {
            if (Cache.judgeSinge)
            {
                his.AddHistory(DisPlayText + "=" + DisPlayBigText);
                History.Clear();
                foreach (var item in his.GetHistory())
                {
                    History.Insert(0, item);
                }
            }
            DisPlayBigText = AddCommon.Addcommon(addNum.Judgefornumber("9"));
            DisPlayText = Cache.topCache;
        }
        private void Num0Handler()
        {
            DisPlayBigText = AddCommon.Addcommon(addNum0.JudgeZero());
            DisPlayText = Cache.topCache;
        }
        private void PercentOneHandler()//%
        {
            DisPlayText = addSingle.JudgeForSinge("%");
            DisPlayBigText = AddCommon.Addcommon(Cache.underCache);
        }
        private void SquareHandler()//平方
        {
            DisPlayText = addSingle.JudgeForSinge("x²");
            DisPlayBigText = AddCommon.Addcommon(Cache.underCache);
        }
        private void CubeHandler()//立方
        {
            DisPlayText = addSingle.JudgeForSinge("x³");
            DisPlayBigText = AddCommon.Addcommon(Cache.underCache);
        }
        private void InverseHandler()//相反数
        {
            DisPlayText = addSingle.JudgeForSinge("±");
            DisPlayBigText = AddCommon.Addcommon(Cache.underCache);
            Cache.judgeNewInp = false;
        }
        private void ReciprocalHandler()//倒数
        {
            DisPlayText = addSingle.JudgeForSinge("1/x");
            if ("除数不能为零".Equals(Cache.underCache))
            {
                DisPlayBigText = Cache.underCache;
            }
            else
            {
                DisPlayBigText = AddCommon.Addcommon(Cache.underCache);
            }
        }
        private void RadicalHandler()//根号
        {
            DisPlayText = addSingle.JudgeForSinge("√");
            DisPlayBigText = AddCommon.Addcommon(Cache.underCache);
        }

        private void ClearAllHandler()
        {
            Cache.topCache = "";
            Cache.underCache = "";
            DisPlayText = "";
            DisPlayBigText = "0";
            Cache.operatorCacheOld = "";
            Cache.operatorCacheNew = "";
            Cache.resultCache = "";
            Cache.judgeNewInp = false;
            Cache.judgeTurn = true;
            Cache.judgeSinge = false;
            Cache.judgeMinus = true;
            Cache.count = 0;
        }

        private void ClearPreHandler()
        {
            if (Cache.judgeSinge)
            {
                his.AddHistory(DisPlayText + "=" + DisPlayBigText);
                History.Clear();
                foreach (var item in his.GetHistory())
                {
                    History.Insert(0, item);
                }
            }
            DisPlayBigText = "0";
            Cache.underCache = "";
        }

        private void DelHandler()
        {
            if (Cache.underCache.Length > 1)
            {
                Cache.underCache = Cache.underCache.Substring(0, Cache.underCache.Length - 1);
                DisPlayBigText = AddCommon.Addcommon(Cache.underCache);
            }
            else
            {
                Cache.underCache = "0";
                DisPlayBigText = Cache.underCache;
                Cache.underCache = "";
            }
        }

        private void DotHandler()
        {
            DisPlayBigText = addDot.Judgefordot();
        }

        private void EqualsHandler()
        {

            DisPlayBigText = AddFormat.Addformat(eq.getResult());
            if ("".Equals(Cache.operatorCacheNew))

            {
                if ("".Equals(Cache.underCache))
                {
                    his.AddHistory("0" + "=" + "0");
                    History.Clear();
                    foreach (var item in his.GetHistory())
                    {
                        History.Insert(0, item);
                    }
                }
                else
                {
                    if (Cache.judgeSinge)
                    {
                        his.AddHistory(Cache.topCache + "=" + Cache.underCache);
                        History.Clear();
                        foreach (var item in his.GetHistory())
                        {
                            History.Insert(0, item);
                        }
                        Cache.judgeSinge = false;
                    }
                    else
                    {
                        his.AddHistory(DisPlayBigText + "=" + DisPlayBigText);
                        History.Clear();
                        foreach (var item in his.GetHistory())
                        {
                            History.Insert(0, item);
                        }
                    }
                }
            }
            else
            {
                if (!"".Equals(DisPlayText))
                {
                    if (Cache.count > 1)
                    {
                        if (!Cache.judgeNewInp)
                        {
                            switch (Cache.operatorCacheNew)
                            {
                                case "＋":
                                    if (Cache.resultCache.Contains("E") || Cache.resultCache.Contains("e"))
                                    {
                                        stri = Science.Addition(Cache.resultCache, Cache.underCache);
                                    }
                                    else
                                    {
                                        stri = (Convert.ToDecimal(Cache.resultCache) - Convert.ToDecimal(Cache.underCache)).ToString();
                                    }
                                    break;
                                case "－":
                                    if (Cache.resultCache.Contains("E") || Cache.resultCache.Contains("e"))
                                    {
                                        stri = Science.Subtract(Cache.resultCache, Cache.underCache);
                                    }
                                    else
                                    {
                                        stri = (Convert.ToDecimal(Cache.resultCache) + Convert.ToDecimal(Cache.underCache)).ToString();
                                    }
                                    break;
                                case "×":
                                    if (Cache.resultCache.Contains("E") || Cache.resultCache.Contains("e"))
                                    {
                                        stri = Science.Multiply(Cache.resultCache, Cache.underCache);
                                    }
                                    else
                                    {
                                        stri = (Convert.ToDecimal(Cache.resultCache) / Convert.ToDecimal(Cache.underCache)).ToString();
                                    }
                                    break;
                                case "÷":
                                    if (Cache.resultCache.Contains("E") || Cache.resultCache.Contains("e"))
                                    {
                                        stri = Science.Devide(Cache.resultCache, Cache.underCache);
                                    }
                                    else if (Cache.resultCache.Contains("除数"))
                                    {
                                        stri = Cache.resultCache;
                                    }
                                    else
                                    {
                                        stri = (Convert.ToDecimal(Cache.resultCache) * Convert.ToDecimal(Cache.underCache)).ToString();
                                    }
                                    break;
                            }
                            his.AddHistory(Cache.topCache + stri + Cache.underCache + "=" + DisPlayBigText);
                            History.Clear();
                            foreach (var item in his.GetHistory())
                            {
                                History.Insert(0, item);
                            }
                        }
                        else
                        {
                            his.AddHistory(Cache.topCache + "=" + DisPlayBigText);
                            History.Clear();
                            foreach (var item in his.GetHistory())
                            {
                                History.Insert(0, item);
                            }
                        }

                        Cache.judgeSinge = false;
                    }
                    else
                    {
                        if (Cache.judgeTurn && Cache.judgeNewInp)
                        {
                            his.AddHistory(DisPlayText + "=" + DisPlayBigText);
                            History.Clear();
                            foreach (var item in his.GetHistory())
                            {
                                History.Insert(0, item);
                            }
                        }
                        else
                        {
                            his.AddHistory(DisPlayText + Cache.underCache + "=" + DisPlayBigText);
                            History.Clear();
                            foreach (var item in his.GetHistory())
                            {
                                History.Insert(0, item);
                            }
                        }
                    }
                }
                else
                {
                    switch (Cache.operatorCacheNew)
                    {
                        case "＋":
                            if (Cache.resultCache.Contains("E") || Cache.resultCache.Contains("e"))
                            {
                                stri = Science.Addition(Cache.resultCache, Cache.underCache);
                            }
                            else
                            {
                                stri = (Convert.ToDecimal(Cache.resultCache) - Convert.ToDecimal(Cache.underCache)).ToString();
                            }
                            break;
                        case "－":
                            if (Cache.resultCache.Contains("E") || Cache.resultCache.Contains("e"))
                            {
                                stri = Science.Subtract(Cache.resultCache, Cache.underCache);
                            }
                            else
                            {
                                stri = (Convert.ToDecimal(Cache.resultCache) + Convert.ToDecimal(Cache.underCache)).ToString();
                            }
                            break;
                        case "×":
                            //if (Cache.resultCache.Contains("E") || Cache.resultCache.Contains("e"))
                            //{
                                stri = Science.Multiply(Cache.resultCache, Cache.underCache);
                            //}
                            //else if(Cache.resultCache.Length > 16)
                            //{
                            //    string[] strArr = Cache.resultCache.Split(',');
                            //    string newNum = "";
                            //    for (int i = 0; i < strArr.Length; i++)
                            //    {
                            //        newNum = strArr[i];
                            //    }
                            //    stri = Science.MySciToNum(decimal.Parse(newNum).ToString());
                            //}
                            //else
                            //{
                            //    stri = (Convert.ToDecimal(Cache.resultCache) * Convert.ToDecimal(Cache.underCache)).ToString();
                            //    if(stri.Length > 16)
                            //    {
                            //       stri = Science.MySciToNum(stri);
                            //    }
                            //    Debug.WriteLine(Cache.resultCache);
                            //}
                            break;
                        case "÷":
                            if (Cache.resultCache.Contains("E") || Cache.resultCache.Contains("e"))
                            {
                                stri = Science.Devide(Cache.resultCache, Cache.underCache);
                            }
                            else if (Cache.resultCache.Contains("除数"))
                            {
                                stri = Cache.resultCache;
                            }
                            else
                            {
                                stri = (Convert.ToDecimal(Cache.resultCache) * Convert.ToDecimal(Cache.underCache)).ToString();
                            }
                            break;
                    }
                    his.AddHistory(stri + Cache.operatorCacheNew + Cache.underCache + "=" + DisPlayBigText);
                    History.Clear();
                    foreach (var item in his.GetHistory())
                    {
                        History.Insert(0, item);
                    }
                }
            }
            DisPlayText = "";
            Cache.topCache = "";
            Cache.judgeEqual = true;
            Cache.judgeTurn = true;
            Cache.judgeNewInp = true;
            Cache.count = 0;
        }
        private ObservableCollection<string> _memory = new ObservableCollection<string> { };
        public ObservableCollection<string> Memory
        {
            get { return _memory; }

        }
        private ObservableCollection<string> _history = new ObservableCollection<string> { "尚无历史记录                                         " };
        public ObservableCollection<string> History
        {
            get { return _history; }
        }
        private void MS()
        {
            mem.MSChange(DisPlayBigText);
            Memory.Clear();
            foreach (var item in mem.GetMemory())
            {
                Memory.Insert(0, item);
            }
        }
        private void MC()
        {
            mem.MSClear();
            Memory.Clear();
            foreach (var item in mem.GetMemory())
            {
                Memory.Insert(0, item);
            }
        }
        private void MR()
        {
            DisPlayBigText = mem.GetMemory().Last();
        }
        private void MMinus()
        {
            mem.MSMinus(DisPlayBigText);
            Memory.Clear();
            foreach (var item in mem.GetMemory())
            {
                Memory.Insert(0, item);
            }
        }
        private void MPlus()
        {
            mem.MSPlus(DisPlayBigText);
            Memory.Clear();
            foreach (var item in mem.GetMemory())
            {
                Memory.Insert(0, item);
            }
        }
        private void ClearHistory()
        {
            his.clear();
            History.Clear();
            foreach (var item in his.GetHistory())
            {
                History.Insert(0, item);
            }
        }
    }
}

