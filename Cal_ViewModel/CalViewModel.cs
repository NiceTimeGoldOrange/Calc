using System;
using System.Text.RegularExpressions;
using Infrastructure;
using Cal_ViewModel.Operator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyMathTools;
using Cal_ViewModel.OperatorModel;
using Cal_ViewModel.NumberFormat;
using Cal_ViewModel.ChangeFactory;
using History_Memory;
using Cal_ViewModel.Format;

namespace Cal_ViewModel
{
    public class CalViewModel : NotifyObject
    {
        IOperator add = new Addition();
        IOperator sub = new Subtract();
        IOperator mul = new Multiply();
        IOperator dev = new Devide();
        IOperator evo = new Evolution();

        NumberOne2Nine appendNum = new NumberOne2Nine();
        Zero num0 = new Zero();
        Point point = new Point();
        AppendOperator appendOpt = new AppendOperator();
        AppendSingle appendSingle = new AppendSingle();
        AppendSign appendSign = new AppendSign();
        Memory memory = new Memory();
        History his = new History();
        Equals eq = new Equals();

        private static String _formDisPlay;
        public string FormDisPlay
        {
            get
            {
                return _formDisPlay;
            }
            set
            {
                SetPropertyNotify(ref _formDisPlay, value, nameof(FormDisPlay));
            }
        }

        public static String _disPlayText = "";
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

        public static String _disPlayBigText = "0";
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


        //绑定0
        private readonly NVCommand _zeroCommand;
        public NVCommand ZeroCommand
        {
            get => _zeroCommand;
        }

        private void ZeroHandler()
        {
            FormDisPlay = FormDisPlay + "0";
            DisPlayBigText = AppendComma.TrisectionMethod(FormDisPlay);
        }

        //绑定1
        private readonly NVCommand _oneCommand;
        public NVCommand OneCommand
        {
            get => _oneCommand;
        }
        private void OneHandler()
        {
            DisPlayText = AppendComma.TrisectionMethod(appendNum.JudgeNum("1"));
            DisPlayBigText = Loading.topText;
        }

        //绑定2
        private readonly NVCommand _twoCommand;
        public NVCommand TwoCommand
        {
            get => _twoCommand;
        }
        private void TwoHandler()
        {
            DisPlayText = Loading.topText;
            DisPlayBigText = AppendComma.TrisectionMethod(appendNum.JudgeNum("2"));
        }

        //绑定3
        private readonly NVCommand _threeCommand;
        public NVCommand ThreeCommand
        {
            get => _threeCommand;
        }
        private void ThreeHandler()
        {
            DisPlayText = Loading.topText;
            DisPlayBigText = AppendComma.TrisectionMethod(appendNum.JudgeNum("3"));
        }

        //绑定4
        private readonly NVCommand _fourCommand;
        public NVCommand FourCommand
        {
            get => _fourCommand;
        }
        private void FourHandler()
        {
            DisPlayBigText = AppendComma.TrisectionMethod(appendNum.JudgeNum("4"));
            DisPlayText = Loading.topText;
        }

        //绑定5
        private readonly NVCommand _fiveCommand;
        public NVCommand FiveCommand
        {
            get => _fiveCommand;
        }
        private void FiveHandler()
        {
            DisPlayBigText = AppendComma.TrisectionMethod(appendNum.JudgeNum("5"));
            DisPlayText = Loading.topText;
        }

        //绑定6
        private readonly NVCommand _sixCommand;
        public NVCommand SixCommand
        {
            get => _sixCommand;
        }
        private void SixHandler()
        {
            DisPlayBigText = AppendComma.TrisectionMethod(appendNum.JudgeNum("6"));
            DisPlayText = Loading.topText;
        }

        //绑定7
        private readonly NVCommand _sevenCommand;
        public NVCommand SevenCommand
        {
            get => _sevenCommand;
        }
        private void SevenHandler()
        {
            DisPlayBigText = AppendComma.TrisectionMethod(appendNum.JudgeNum("7"));
            DisPlayText = Loading.topText;
        }

        //绑定8
        private readonly NVCommand _eightCommand;
        public NVCommand EightCommand
        {
            get => _eightCommand;
        }
        private void EightHandler()
        {
            DisPlayBigText = AppendComma.TrisectionMethod(appendNum.JudgeNum("8"));
            DisPlayText = Loading.topText;
        }

        //绑定9
        private readonly NVCommand _nineCommand;
        public NVCommand NineCommand
        {
            get => _nineCommand;
        }
        private void NineHandler()
        {
            if (Loading.isSingleOper)
            {
                his.AddHis(DisPlayText);
            }
        }

        //绑定 .
        private readonly NVCommand _pointCommand;
        public NVCommand PointCommand
        {
            get => _pointCommand;
        }
        private void PointHandler()
        {
            DisPlayBigText = point.IsPoint();
            ////判断.是否出现过
            //Boolean jd = true;
            //foreach (char element in DisPlayBigText)
            //{
            //    if (element == '.')
            //    {
            //        jd = false;
            //    }
            //}

            //if (jd == true)
            //{
            //    FormDisPlay = FormDisPlay + ".";
            //    DisPlayBigText = AppendComma.TrisectionMethod(FormDisPlay);
            //}
        }

        // 加法
        private readonly NVCommand _addCommand;
        public NVCommand AddCommand
        {
            get => _addCommand;
        }
        private void AddHandler()
        {
            DisPlayText = appendOpt.JudgeOperation("+");
            DisPlayBigText = AppendFormat.Addformat(AppendComma.TrisectionMethod(Loading.belowText));
        }

        // 减法
        private readonly NVCommand _subtractCommand;
        public NVCommand SubtractCommand
        {
            get => _subtractCommand;
        }
        private void SubtractHandler()
        {
            DisPlayText = appendOpt.JudgeOperation("-");
            DisPlayBigText = AppendFormat.Addformat(AppendComma.TrisectionMethod(Loading.belowText));
        }

        // 乘法
        private readonly NVCommand _multiplyCommand;
        public NVCommand MultiplyCommand
        {
            get => _multiplyCommand;
        }
        private void MultiplyHandler()
        {
            DisPlayText = appendOpt.JudgeOperation("×");
            DisPlayBigText = AppendFormat.Addformat(AppendComma.TrisectionMethod(Loading.belowText));
        }

        //除法
        private readonly NVCommand _divideCommand;
        public NVCommand DivideCommand { get => _divideCommand; }
        private void DivideHandler()
        {
            DisPlayText = appendOpt.JudgeOperation("÷");
            DisPlayBigText = AppendFormat.Addformat(AppendComma.TrisectionMethod(Loading.belowText));
        }


        // 平方
        private readonly NVCommand _squareCommand;
        public NVCommand SquareCommand { get => _squareCommand; }
        public void SqareHandler()
        {
            DisPlayText = appendSingle.JudgeSingle("x²");
            DisPlayBigText = AppendFormat.Addformat(AppendComma.TrisectionMethod(Loading.belowText));
        }

        // 开方
        private readonly NVCommand _sqrtCommand;
        public NVCommand SqrtCommand { get => _sqrtCommand; }
        public void SqrtHandler()
        {
            DisPlayText = appendSingle.JudgeSingle("√");
            DisPlayBigText = AppendFormat.Addformat(AppendComma.TrisectionMethod(Loading.belowText));
        }

        // 百分比
        private readonly NVCommand _percentCommand;
        public NVCommand PercentCommand { get => _percentCommand; }
        public void PercentHandler()
        {
            DisPlayText = appendSingle.JudgeSingle("%");
            DisPlayBigText = AppendFormat.Addformat(AppendComma.TrisectionMethod(Loading.belowText));
        }

        // 倒数
        private readonly NVCommand _inverseCommand;
        public NVCommand InverseCommand { get => _inverseCommand; }
        public void InverseHandler()
        {
            DisPlayText = appendSingle.JudgeSingle("⅟x");
            DisPlayBigText = AppendComma.TrisectionMethod(AppendFormat.Addformat(Loading.belowText));
        }

        // 删除
        private readonly NVCommand _delCommand;
        public NVCommand DelCommand { get => _delCommand; }
        public void DelHandler()
        {

        }

        // 清空
        private readonly NVCommand _clearAllCommand;
        public NVCommand ClearAllCommand { get => _clearAllCommand; }
        public void ClearAllHandler()
        {

        }

        // 清除上一个
        private readonly NVCommand _clearPreCommand;
        public NVCommand ClearPreCommand { get => _clearPreCommand; }
        public void ClearPreHandler()
        {

        }

        // 等于号
        private readonly NVCommand _equalsCommand;
        public NVCommand EqualsCommand { get => _equalsCommand; }
        public void EqualsHandler()
        {

        }

        // MS
        private readonly NVCommand _btn_ms;
        public NVCommand Btn_ms { get => _btn_ms; }
        public void MSHandler()
        {

        }

        // MR
        private readonly NVCommand _btn_mr;
        public NVCommand Btn_mr { get => _btn_mr; }
        public void MRHandler()
        {

        }

        private readonly NVCommand _btn_mc;
        public NVCommand Btn_mc { get => _btn_mc; }
        public void MCHandler()
        {

        }


        // 负号
        private readonly NVCommand _btn_minus;
        public NVCommand Btn_minus { get => _btn_minus; }
        public void MinusHandler()
        {

        }

        // 正号
        private readonly NVCommand _btn_plus;
        public NVCommand Btn_plus { get => _btn_plus; }
        public void PlusHandler()
        {

        }

        // 清除历史记录
        private readonly NVCommand _btn_clearHis;
        public NVCommand Btn_clearHis { get => _btn_clearHis; }
        public void ClearHisHandler()
        {

        }

        // 历史记录集合
        private readonly List<string> _HisCollection = new List<string>();
        public List<string> HisCollection { get => _HisCollection; }

        // 内存集合
        private readonly List<string> _MemCollection = new List<string>();
        public List<string> MemCollection { get => _MemCollection; }

        public CalViewModel()
        {
            // 四则运算
            _addCommand = new NVCommand(AddHandler);
            _subtractCommand = new NVCommand(SubtractHandler);
            _multiplyCommand = new NVCommand(MultiplyHandler);
            _divideCommand = new NVCommand(DivideHandler);

            // 1 - 9数字
            _zeroCommand = new NVCommand(ZeroHandler);
            _oneCommand = new NVCommand(OneHandler);
            _twoCommand = new NVCommand(TwoHandler);
            _threeCommand = new NVCommand(ThreeHandler);
            _fourCommand = new NVCommand(FourHandler);
            _fiveCommand = new NVCommand(FiveHandler);
            _sixCommand = new NVCommand(SixHandler);
            _sevenCommand = new NVCommand(SevenHandler);
            _eightCommand = new NVCommand(EightHandler);
            _nineCommand = new NVCommand(NineHandler);
            _pointCommand = new NVCommand(PointHandler);

            _percentCommand = new NVCommand(PercentHandler);
            _squareCommand = new NVCommand(SqareHandler);
            _inverseCommand = new NVCommand(InverseHandler);
            _clearAllCommand = new NVCommand(ClearAllHandler);
            _clearPreCommand = new NVCommand(ClearPreHandler);
            _equalsCommand = new NVCommand(EqualsHandler);
            _btn_ms = new NVCommand(MSHandler);
            _btn_mr = new NVCommand(MRHandler);
            _btn_mc = new NVCommand(MCHandler);
            _btn_plus = new NVCommand(PlusHandler);
            _btn_clearHis = new NVCommand(ClearHisHandler);
            _sqrtCommand = new NVCommand(SqrtHandler);
            _btn_minus = new NVCommand(MinusHandler);
            _delCommand = new NVCommand(DelHandler);
        }
    }
}
