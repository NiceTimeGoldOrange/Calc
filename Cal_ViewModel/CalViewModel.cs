using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Web.Infrastructure;
using System.Runtime.CompilerServices;
using Infrastructure;


namespace Cal_ViewModel
{
    public class CalViewModel : NotifyObject
    //private static List<string> HisCollection = new List<string>();
    //private static List<string> MemCollection= new List<string>();

    { private String _disPlayText;

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
        private readonly NVCommand _pointCommand;
        public NVCommand PointCommand
        {
            get => _pointCommand;
        }
        private readonly NVCommand _addsubCommand;
        public NVCommand AddSubCommand
        {
            get => _addsubCommand;
        }
        private readonly NVCommand _percentCommand;
        public NVCommand PercentCommand
        {
            get => _percentCommand;
        }
        private readonly NVCommand _evolutionCommand;
        public NVCommand EvolutionCommand
        {
            get => _evolutionCommand;
        }
        private readonly NVCommand _squareCommand;
        public NVCommand SquareCommand
        {
            get => _squareCommand;
        }
        private readonly NVCommand _cubeCommand;
        public NVCommand CubeCommand
        {
            get => _cubeCommand;
        }
        private readonly NVCommand _reciprocalCommand;
        public NVCommand ReciprocalCommand
        {
            get => _reciprocalCommand;
        }
        private readonly NVCommand _equalCommand;
        public NVCommand EqualCommand
        {
            get => _equalCommand;
        }
        private readonly NVCommand _deleteCommand;
        public NVCommand DeleteCommand
        {
            get => _deleteCommand;
        }
        private readonly NVCommand _clearCommand;
        public NVCommand ClearCommand
        {
            get => _clearCommand;
        }
        private readonly NVCommand _ceCommand;
        public NVCommand CECommand
        {
            get => _ceCommand;
        }
        private readonly NVCommand _msCommand;
        public NVCommand MSCommand
        {
            get => _msCommand;
        }
        private readonly NVCommand _mrCommand;
        public NVCommand MRCommand
        {
            get => _mrCommand;
        }
        private readonly NVCommand _mcCommand;
        public NVCommand MCCommand
        {
            get => _mcCommand;
        }
        private readonly NVCommand _mpCommand;
        public NVCommand MPCommand
        {
            get => _mpCommand;
        }
        private readonly NVCommand _msubCommand;
        public NVCommand MSubCommand
        {
            get => _msubCommand;
        }
        public CalViewModel()
        {
            _addCommand = new NVCommand(AddHandler);
            _subtractCommand = new NVCommand(SubtractHandler);
            _multiplyCommand = new NVCommand(MultiplyHandler);
            _divideCommand = new NVCommand(DivideHandler);
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
            _pointCommand = new NVCommand(PointHandler);
            _addsubCommand = new NVCommand(AddSubHandler);
            _percentCommand = new NVCommand(PercentHandler);
            _evolutionCommand = new NVCommand(EvolutionHandler);
            _squareCommand = new NVCommand(SquareHandler);
            _cubeCommand = new NVCommand(CubeHandler);
            _reciprocalCommand = new NVCommand(ReciprocalHandler);
            _deleteCommand = new NVCommand(DeleteHandler);
            _clearCommand = new NVCommand(ClearHandler);
            _msCommand = new NVCommand(MSHandler);
            _mrCommand = new NVCommand(MRHandler);
            _mcCommand = new NVCommand(MCHandler);
            _mpCommand = new NVCommand(MPHandler);
            _msubCommand = new NVCommand(MSubHandler);

        }

        private void AddHandler()
        {
            DisPlayText = "+";
        }

        private void SubtractHandler()
        {
            DisPlayText = "-";
        }

        private void MultiplyHandler()
        {
            DisPlayText = "*";
        }

        private void DivideHandler()
        {
            DisPlayText = "/";
        }
        private void Num1Handler()
        {
            DisPlayText = "1";
        }
        private void Num2Handler()
        {
            DisPlayText = "2";
        }
        private void Num3Handler()
        {
            DisPlayText = "3";
        }
        private void Num4Handler()
        {
            DisPlayText = "4";
        }
        private void Num5Handler()
        {
            DisPlayText = "5";
        }
        private void Num6Handler()
        {
            DisPlayText = "6";
        }
        private void Num7Handler()
        {
            DisPlayText = "7";

        }
        private void Num8Handler()
        {
            DisPlayText = "8";

        }
        private void Num9Handler()
        {
            DisPlayText = "9";

        }
        private void Num0Handler()
        {
            DisPlayText = "0";

        }
        private void PointHandler()
        {
            DisPlayText = ".";

        }
        private void AddSubHandler()
        {
            DisPlayText = "±";

        }
        private void PercentHandler()
        {
            DisPlayText = "% ";

        }
        private void EvolutionHandler()
        {
            DisPlayText = "√ ";

        }
        private void SquareHandler()
        {
            DisPlayText = "x² ";

        }
        private void CubeHandler()
        {
            DisPlayText = "x ³";

        }
        private void ReciprocalHandler()
        {
            DisPlayText = "1/x ";

        }

        private void EqualHandler()
        {
            DisPlayText = "=  ";

        }
        private void DeleteHandler()
        {
            DisPlayText = "⌫  ";

        }
        private void ClearHandler()
        {
            DisPlayText = "C";

        }
        private void CEHandler()
        {
            DisPlayText = "CE";

        }
        private void MSHandler()
        {
            DisPlayText =" MS";

        }
        private void MRHandler()
        {
            DisPlayText = "MR";

        }
        private void MPHandler()
        {
            DisPlayText = "M+";

        }
        private void MSubHandler()
        {
            DisPlayText = "M-";

        }
        private void MCHandler()
        {
            DisPlayText = "MC";

        }

    }
}
