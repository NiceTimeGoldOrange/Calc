using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.Other
{ 
 /// <summary>
 /// 一目运算和算式
 /// </summary>
public interface IOthers
{
    /// <summary>
    /// 运算的抽象方法
    /// </summary>
    /// <param name="i2">i2</param>
    /// <returns></returns>
    decimal GetResult(decimal i2);

    /// <summary>
    /// 获取算式的抽象方法
    /// </summary>
    /// <param name="num">之前的算式</param>
    /// <returns></returns>
    string GetToString(string num);
}
}
