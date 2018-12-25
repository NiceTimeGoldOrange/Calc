using MyMathTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.OperatorModel
{
    /// <summary>
    /// 除、倒数
    /// 问题:
    ///    1. 限制前台输入的数字的长度
    ///    2. 四舍五入（通过工具类解决）
    ///    3. 科学计数法
    /// </summary>
    public class Devide : IOperator
    {
        public string GetResult(string i1, string i2)
        {
            if (decimal.Parse(i2) == 0)
            {
                return "除数不能为0";
            }
            decimal num = decimal.Parse(i1) * decimal.Parse(i2);
            string result = MyMath.MyRouding(num.ToString());

            return MyMath.MyRouding(result);
        }
    }
}
