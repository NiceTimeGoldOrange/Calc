using Cal_ViewModel.OperatorModel;
using Cal_ViewModel.SaveModel;

namespace Cal_ViewModel.TypeModel.SingleOperation
{
    class MyOneCent
    {
        public static void OneCent()
        {
            Complex_Operation CO = new Complex_Operation();
            //1.什么都不输入的情况下
            if ("".Equals(Cache.underCache))
            {
                Cache.topCache += ("1/(" + "0" + ")");
                Cache.underCache = "除数不能为零";
            }
            //2.输入数的情况下
            else if (!Cache.judgeSinge)
            {
                Cache.topCache += ("1/(" + Cache.underCache + ")");
                Cache.underCache = CO.OneCent(Cache.underCache);
                Cache.judgeSinge = true;

            }
            //3.Cache.judgeSinge为true即已经进行过单目运算的情况下
            else
            {
                if ("".Equals(Cache.operatorCacheOld))
                {
                    Cache.topCache = ("1/(" + Cache.topCache + ")");
                    Cache.underCache = CO.OneCent(Cache.underCache);
                }
                else
                {
                    if (Cache.topCache.LastIndexOf(Cache.operatorCacheNew).Equals(Cache.topCache.Length - 1))
                    {
                        Cache.topCache += ("1/(" + Cache.resultCache + ")");
                        Cache.underCache = CO.OneCent(Cache.underCache);
                    }
                    else
                    {
                        int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1;
                        string str = Cache.topCache.Substring(index, Cache.topCache.Length - index);
                        Cache.topCache = Cache.topCache.Substring(0, index) + ("1/(" + str + ")");
                        Cache.underCache = CO.OneCent(Cache.underCache);
                    }

                }

            }
        }
    }
}
