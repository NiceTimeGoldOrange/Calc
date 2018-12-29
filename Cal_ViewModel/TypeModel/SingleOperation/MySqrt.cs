using Cal_ViewModel.OperatorModel;
using Cal_ViewModel.SaveModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.TypeModel.SingleOperation
{
    class MySqrt
    {
        public static void Sqrt()
        {
            Complex_Operation CO = new Complex_Operation();
            //1.什么都不输入的情况下
            if ("".Equals(Cache.underCache))
            {
                Cache.topCache += ("√(" + "0" + ")");
                Cache.underCache = CO.Sqrt("0");
                Cache.judgeSinge = true;
            }
            //2.输入数的情况下
            else if (!Cache.judgeSinge)
            {
                Cache.topCache += ("√(" + Cache.underCache + ")");
                Cache.underCache = CO.Sqrt(Cache.underCache);
                Cache.judgeSinge = true;
            }
            //3.Cache.judgeSinge为true即已经进行过单目运算的情况下
            else
            {
                if ("".Equals(Cache.operatorCacheOld))
                {
                    Cache.topCache = ("√(" + Cache.topCache + ")");
                    Cache.underCache = CO.Sqrt(Cache.underCache);
                }
                else
                {
                    if (Cache.topCache.LastIndexOf(Cache.operatorCacheNew).Equals(Cache.topCache.Length - 1))
                    {
                        Cache.topCache += ("√(" + Cache.resultCache + ")");
                        Cache.underCache = CO.Sqrt(Cache.underCache);
                    }
                    else
                    {
                        int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1;
                        string str = Cache.topCache.Substring(index, Cache.topCache.Length - index);
                        Cache.topCache = Cache.topCache.Substring(0, index) + ("√(" + str + ")");
                        Cache.underCache = CO.Sqrt(Cache.underCache);
                    }
                }
            }
        }
    }
}
