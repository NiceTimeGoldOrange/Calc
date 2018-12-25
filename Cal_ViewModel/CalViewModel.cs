using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Web.Infrastructure;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Infrastructure;
using System.Text.RegularExpressions;
using MyMathTools;
using Cal_ViewModel.OperatorModel;
using Cal_ViewModel.Operator;

namespace Cal_ViewModel
{
    public class CalViewModel : NotifyObject
    {
        private static List<string> list = new List<string>();

        IOperator add = new Addition();
        IOperator sub = new Subtract();
        IOperator mul = new Multiply();
        IOperator dev = new Devide();
        IOperator evo = new Evolution();

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
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定1
        private readonly NVCommand _oneCommand;
        public NVCommand OneCommand
        {
            get => _oneCommand;
        }
        private void OneHandler()
        {
            FormDisPlay = FormDisPlay + "1";
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定2
        private readonly NVCommand _twoCommand;
        public NVCommand TwoCommand
        {
            get => _twoCommand;
        }
        private void TwoHandler()
        {
            FormDisPlay = FormDisPlay + "2";
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定3
        private readonly NVCommand _threeCommand;
        public NVCommand ThreeCommand
        {
            get => _threeCommand;
        }
        private void ThreeHandler()
        {
            FormDisPlay = FormDisPlay + "3";
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定4
        private readonly NVCommand _fourCommand;
        public NVCommand FourCommand
        {
            get => _fourCommand;
        }
        private void FourHandler()
        {
            FormDisPlay = FormDisPlay + "4";
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定5
        private readonly NVCommand _fiveCommand;
        public NVCommand FiveCommand
        {
            get => _fiveCommand;
        }
        private void FiveHandler()
        {
            FormDisPlay = FormDisPlay + "5";
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定6
        private readonly NVCommand _sixCommand;
        public NVCommand SixCommand
        {
            get => _sixCommand;
        }
        private void SixHandler()
        {
            FormDisPlay = FormDisPlay + "6";
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定7
        private readonly NVCommand _sevenCommand;
        public NVCommand SevenCommand
        {
            get => _sevenCommand;
        }
        private void SevenHandler()
        {
            FormDisPlay = FormDisPlay + "7";
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定8
        private readonly NVCommand _eightCommand;
        public NVCommand EightCommand
        {
            get => _eightCommand;
        }
        private void EightHandler()
        {
            FormDisPlay = FormDisPlay + "8";
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定9
        private readonly NVCommand _nineCommand;
        public NVCommand NineCommand
        {
            get => _nineCommand;
        }
        private void NineHandler()
        {
            FormDisPlay = FormDisPlay + "9";
            DisPlayBigText = TrisectionMethod(FormDisPlay);
        }

        //绑定 .
        private readonly NVCommand _pointCommand;
        public NVCommand PointCommand
        {
            get => _pointCommand;
        }

        public static NVCommand PercentCommand { get => _percentCommand; set => _percentCommand = value; }
        public static NVCommand InverseCommand { get => _inverseCommand; set => _inverseCommand = value; }
        public static NVCommand DelCommand { get => _delCommand; set => _delCommand = value; }
        public static NVCommand ClearAllCommand { get => _clearAllCommand; set => _clearAllCommand = value; }
        public static NVCommand ClearPreCommand { get => _clearPreCommand; set => _clearPreCommand = value; }
        public static NVCommand EqualsCommand { get => _equalsCommand; set => _equalsCommand = value; }
        public static NVCommand Btn_ms { get => _btn_ms; set => _btn_ms = value; }
        public static NVCommand Btn_mr { get => _btn_mr; set => _btn_mr = value; }
        public static NVCommand Btn_minus { get => _btn_minus; set => _btn_minus = value; }
        public static NVCommand Btn_plus { get => _btn_plus; set => _btn_plus = value; }
        public static NVCommand Btn_clearHis { get => _btn_clearHis; set => _btn_clearHis = value; }
        public static NVCommand SqareCommand { get => _sqareCommand; set => _sqareCommand = value; }
        public static NVCommand SqrtCommand { get => _sqrtCommand; set => _sqrtCommand = value; }
        public static List<string> HisCollection { get => _HisCollection; set => _HisCollection = value; }
        public static List<string> MemCollection { get => _MemCollection; set => _MemCollection = value; }

        // 0-9数字绑定、四则运算、小数点、逗号
        private readonly NVCommand _addCommand;
        public NVCommand AddCommand
        {
            get => _addCommand;
        }

        private readonly NVCommand _subtractCommand;
        public NVCommand SubtractCommand
        {
            get => _subtractCommand;
        }

        private readonly NVCommand _multiplyCommand;
        public NVCommand MultiplyCommand
        {
            get => _multiplyCommand;
        }

        private readonly NVCommand _divideCommand;
        public NVCommand DivideCommand
        {
            get => _divideCommand;
        }

        // 平方
        private static NVCommand _sqareCommand;
        // 开方
        private static NVCommand _sqrtCommand;
        // 百分比
        private static NVCommand _percentCommand;
        // 倒数
        private static NVCommand _inverseCommand;
        // 删除
        private static NVCommand _delCommand;
        // 清空
        private static NVCommand _clearAllCommand;
        // 清除上一个
        private static NVCommand _clearPreCommand;
        // 等于号
        private static NVCommand _equalsCommand;
        // MS
        private static NVCommand _btn_ms;
        // MR
        private static NVCommand _btn_mr;
        // 负号
        private static NVCommand _btn_minus;
        // 正号
        private static NVCommand _btn_plus;
        // 清除历史记录
        private static NVCommand _btn_clearHis;
        // 历史记录集合
        private static List<string> _HisCollection = new List<string>();
        // 内存集合
        private static List<string> _MemCollection = new List<string>();

        private void PointHandler()
        {
            //判断.是否出现过
            Boolean jd = true;
            foreach (char element in DisPlayBigText)
            {
                if (element == '.')
                {
                    jd = false;
                }
            }

            if (jd == true)
            {
                FormDisPlay = FormDisPlay + ".";
                DisPlayBigText = TrisectionMethod(FormDisPlay);
            }
        }

        //三位分节法 ，添加逗号
        private string TrisectionMethod(String str)
        {
            //带小数的正则表达式判断
            if (str.Contains(".") == true)
            {
                str = Regex.Replace(str, @"\d+?(?=(?:\d{3})+\.)", "$0,");
            }
            else
            {
                str = str + ".01";
                str = Regex.Replace(str, @"\d+?(?=(?:\d{3})+\.)", "$0,");
                string[] sArray = str.Split('.');
                str = sArray.ElementAt(0);
            }
            return str;
        }

        // 加法
        private void AddHandler()
        {
            DisPlayText = FormDisPlay + "   +    ";
            DisPlayBigText = "";
        }

        //减法
        private void SubtractHandler()
        {
            DisPlayText = FormDisPlay + "   -    ";
        }

        // 乘法
        private void MultiplyHandler()
        {
            DisPlayText = FormDisPlay + "  ×    ";
        }

        // 除法
        private void DivideHandler()
        {
            DisPlayText = FormDisPlay + "  ÷    ";
        }

        //百分比
        public void PercentHandler()
        {

        }

        // 平方
        public void SqareHandler()
        {

        }

        // 倒数
        public void InverseHandler()
        {

        }

        //清除所有
        public void ClearAllHandler()
        {

        }

        public void ClearPreHandler()
        {

        }

        public void DelHandler()
        {

        }

        public void EqualsHandler()
        {

        }

        public void MS()
        {

        }

        public void MR()
        {

        }

        public void MC()
        {

        }

        public void Minus()
        {

        }

        public void Plus()
        {

        }

        public void ClearHistory()
        {

        }

        public void Sqrt()
        {
            DisPlayBigText = MyMath.MyRouding(MyMath.MySqrt(FormDisPlay));
        }

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
            _sqareCommand = new NVCommand(SqareHandler);
            _inverseCommand = new NVCommand(InverseHandler);
            _clearAllCommand = new NVCommand(ClearAllHandler);
            _clearPreCommand = new NVCommand(ClearPreHandler);
            _equalsCommand = new NVCommand(EqualsHandler);
            _btn_ms = new NVCommand(MS);
            _btn_mr = new NVCommand(MR);
            _btn_plus = new NVCommand(Plus);
            _btn_clearHis = new NVCommand(ClearHistory);
            _sqrtCommand = new NVCommand(Sqrt);
        }
    }

}


