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

namespace Cal_ViewModel
{
    public class CalViewModel : NotifyObject
    {
        //private static List<string> HisCollection = new List<string>();
        //private static List<string> MemCollection= new List<string>();

        public CalViewModel()
        {
            _addCommand = new NVCommand(AddHandler);
            _subtractCommand = new NVCommand(SubtractHandler);
            _multiplyCommand = new NVCommand(MultiplyHandler);
            _divideCommand = new NVCommand(DivideHandler);
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

        }
        private String _formDisPlay;
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
        private String _disPlayText;

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
        private String _disPlayBigText;
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





        private void AddHandler()
        {
            DisPlayText = FormDisPlay + "  +    ";
        }

        private void SubtractHandler()
        {
            DisPlayText = FormDisPlay + "  -    ";
        }

        private void MultiplyHandler()
        {
            DisPlayText = FormDisPlay + "  ×    ";
        }

        private void DivideHandler()
        {
            DisPlayText = FormDisPlay + "  ÷    ";
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
            
            FormDisPlay = FormDisPlay+"9";
            DisPlayBigText = TrisectionMethod(FormDisPlay);

        }
        //绑定 .
        private readonly NVCommand _pointCommand;
        public NVCommand PointCommand
        {
            get => _pointCommand;
        }
        private void PointHandler()
        {   //判断.是否出现过
            Boolean jd = true;
            Boolean test = false;
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
        //三位分节法
        private string TrisectionMethod(String str)
        {   //带小数的正则表达式判断
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
    }
}
