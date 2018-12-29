using Cal_ViewModel.OperatorModel;
using Cal_ViewModel.SaveModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.TypeModel.SingleOperation
{
    class MyCube
    {
        public static void Cube()
        {
            Complex_Operation CO = new Complex_Operation();
            if ("".Equals(Cache.underCache))
            {
                Cache.topCache += ("sqr(" + "0" + ")");
                Cache.underCache = (CO.Squ("0"));
                Cache.judgeSinge = true;
            }
            //2.输入数的情况下
            else if (!Cache.judgeSinge)
            {
                Cache.topCache += ("cube(" + Cache.underCache + ")");
                Cache.underCache = CO.Cube(Cache.underCache);
                Cache.judgeSinge = true;
            }
            //3.Cache.judgeSinge为true即已经进行过单目运算的情况下
            else
            {
                if ("".Equals(Cache.operatorCacheOld))
                {
                    Cache.topCache = ("cube(" + Cache.topCache + ")");
                    Cache.underCache = CO.Cube(Cache.underCache);
                }
                else
                {
                    if (Cache.topCache.LastIndexOf(Cache.operatorCacheNew).Equals(Cache.topCache.Length - 1))
                    {
                        Cache.topCache += ("cube(" + Cache.resultCache + ")");
                        Cache.underCache = CO.Cube(Cache.underCache);
                    }
                    else
                    {
                        int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1;
                        string str = Cache.topCache.Substring(index, Cache.topCache.Length - index);
                        Cache.topCache = Cache.topCache.Substring(0, index) + ("cube(" + str + ")");
                        Cache.underCache = CO.Cube(Cache.underCache);
                    }

                }

            }
        }


    }
}
