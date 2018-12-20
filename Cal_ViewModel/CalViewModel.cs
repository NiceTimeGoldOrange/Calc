using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Web.Infrastructure;

namespace Cal_ViewModel
{
    public class CalViewModel : INotifyPropertyChanged
    {
        //private static List<string> HisCollection = new List<string>();
        //private static List<string> MemCollection= new List<string>();

        private ICommand _numberCommand;

        public CalViewModel()
        {

        }

        /// <summary>
        /// 通过按钮的值，判定运算
        /// </summary>
        /// <param name="btn"></param>
        public void OnNumClick(Button btn)
        {
            string op = btn.Content.ToString();
            if (op == "=")
            {

            }
            else if (op == "+")
            {

            }
            else if (op == "-")
            {

            }
            else if (op == "*")
            {

            }
            else if (op == "/")
            {

            }
            else if (op == "+")
            {

            }
            else if (op == "√")
            {

            }
            else if (op == "%")
            {

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
