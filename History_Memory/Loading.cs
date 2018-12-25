using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History_Memory
{/// <summary>
/// 初始化计算器的值
/// </summary>
    public static class Loading
    {
        // 顶部Text的值
        public static string topText = "";

        // 底部Text的值
        public static string belowText = "";

        // 上一个符号
        public static string lastOperator = "";

        // 最新的操作符
        public static string currentOperator = "";

        // 上一次输入的结果
        public static string lastResult = "";

        // 数值是否为新输入的值
        public static bool isNewNum = false;

        // 四则运算符是否为新输入
        public static bool isNewOperator = true;

        // 是否是对结果单目运算
        public static bool isSingleOper = false;

        // 是否进行过等于运算
        public static bool isEqual = false;

        // 是否做过正负运算
        public static bool isMinus = true;

        // 单目运算次数
        public static Int32 singleCount = 0;

    }
}
