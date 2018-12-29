using Cal_ViewModel.OperatorModel;
using Cal_ViewModel.SaveModel;
using MyMathTools.NumToSci;

namespace Cal_ViewModel.TypeModel.SingleOperation
{
    class MySquare
    {
        public static void Square()
        {
            Complex_Operation CO = new Complex_Operation();
            //1.什么都不输入的情况下
            if ("".Equals(Cache.underCache))
            {
                Cache.topCache += ("sqr(" + "0" + ")");
                Cache.underCache = (CO.Squ("0"));
                Cache.judgeSinge = true;
            }
            //2.输入数的情况下
            else if (!Cache.judgeSinge)
            {
                Cache.topCache += ("sqr(" + Cache.underCache + ")");
                Cache.underCache = CO.Squ(Cache.underCache);

                if (Cache.underCache.Contains("E"))
                {
                    Cache.underCache = Science.Multiply(Cache.underCache, Cache.underCache);
                }

                Cache.judgeSinge = true;
            }
            //3.Cache.judgeSinge为true即已经进行过单目运算的情况下
            else
            {
                if ("".Equals(Cache.operatorCacheOld))
                {
                    Cache.topCache = ("sqr(" + Cache.topCache + ")");
                    Cache.underCache = CO.Squ(Cache.underCache);
                }
                else
                {
                    if (Cache.topCache.LastIndexOf(Cache.operatorCacheNew).Equals(Cache.topCache.Length - 1))
                    {
                        Cache.topCache += ("sqr(" + Cache.resultCache + ")");
                        Cache.underCache = CO.Squ(Cache.underCache).Substring(0 ,16);
                    }
                    else
                    {
                        int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1;
                        string str = Cache.topCache.Substring(index, Cache.topCache.Length - index);
                        Cache.topCache = Cache.topCache.Substring(0, index) + ("sqr(" + str + ")");
                        Cache.underCache = CO.Squ(Cache.underCache);
                    }
                }
            }
        }
    }
}
