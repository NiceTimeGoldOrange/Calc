using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.SaveModel
{
    public static class Cache
    {
        //缓存顶部栏内容
        public static string topCache = "";
        //缓存底部栏内容
        public static string underCache = "";
        //缓存上一个符号 
        public static string operatorCacheOld = "";
        //缓存最新的符号 
        public static string operatorCacheNew = "";
        //缓存上一次结果
        public static string resultCache = "";
        //判断是否为新新入
        public static bool judgeNewInp = false;
        //四则运算符是否是新输入
        public static bool judgeTurn = true;
        //是否是对结果单目运算
        public static bool judgeSinge = false;
        //判断是否进行过等于
        public static bool judgeEqual = false;
        //判断是否正负过
        public static bool judgeMinus = true;
        //判断进行过单目运算的次数
        public static Int32 count = 0;

    }
}

