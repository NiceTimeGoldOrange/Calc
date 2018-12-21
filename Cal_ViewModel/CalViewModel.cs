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
            DisPlayText = "+    ";
        }

        private void SubtractHandler()
        {
            DisPlayText = "-    ";
        }

        private void MultiplyHandler()
        {
            DisPlayText = "×    ";
        }

        private void DivideHandler()
        {
            DisPlayText = "÷    ";
        }
        //绑定0
        private readonly NVCommand _zeroCommand;
        public NVCommand ZeroCommand
        {
            get => _zeroCommand;
        }
        private void ZeroHandler()
        {
            DisPlayBigText = DisPlayBigText+"0";
        }

        //绑定1
        private readonly NVCommand _oneCommand;
        public NVCommand OneCommand
        {
            get => _oneCommand;
        }
        private void OneHandler()
        {
            DisPlayBigText = DisPlayBigText+"1";
        }
        //绑定2
        private readonly NVCommand _twoCommand;
        public NVCommand TwoCommand
        {
            get => _twoCommand;
        }
        private void TwoHandler()
        {
            DisPlayBigText = DisPlayBigText + "2";
        }
        //绑定3
        private readonly NVCommand _threeCommand;
        public NVCommand ThreeCommand
        {
            get => _threeCommand;
        }
        private void ThreeHandler()
        {
            DisPlayBigText = DisPlayBigText + "3";
        }
        //绑定4
        private readonly NVCommand _fourCommand;
        public NVCommand FourCommand
        {
            get => _fourCommand;
        }
        private void FourHandler()
        {
            DisPlayBigText = DisPlayBigText + "4";
        }
        //绑定5
        private readonly NVCommand _fiveCommand;
        public NVCommand FiveCommand
        {
            get => _fiveCommand;
        }
        private void FiveHandler()
        {
            DisPlayBigText = DisPlayBigText + "5";
        }
        //绑定6
        private readonly NVCommand _sixCommand;
        public NVCommand SixCommand
        {
            get => _sixCommand;
        }
        private void SixHandler()
        {
            DisPlayBigText = DisPlayBigText + "6";
        }
        //绑定7
        private readonly NVCommand _sevenCommand;
        public NVCommand SevenCommand
        {
            get => _sevenCommand;
        }
        private void SevenHandler()
        {
            DisPlayBigText = DisPlayBigText + "7";
        }
        //绑定8
        private readonly NVCommand _eightCommand;
        public NVCommand EightCommand
        {
            get => _eightCommand;
        }
        private void EightHandler()
        {
            DisPlayBigText = DisPlayBigText + "8";
        }
        //绑定9
        private readonly NVCommand _nineCommand;
        public NVCommand NineCommand
        {
            get => _nineCommand;
        }
        private void NineHandler()
        {
            DisPlayBigText = DisPlayBigText + "9";
        }

    }
}
