using Cal_ViewModel.OperatorModel;
using Cal_ViewModel.SaveModel;

namespace Cal_ViewModel.TypeModel.SingleOperation
{
    class MyMinus
    {
        public static void Minus()
        {
            Complex_Operation CO = new Complex_Operation();
            AddSymbol sy = new AddSymbol();
            //如果没有新的输入，最后输入的是运算符
            if (Cache.judgeNewInp)
            {
                if (!Cache.judgeSinge)
                {
                    Cache.topCache += ("negate(" + CalViewModel._disPlayBigText + ")");
                    Cache.underCache = CO.Minus(CalViewModel._disPlayBigText);
                    Cache.judgeSinge = true;
                }
                else
                {
                    int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1;
                    string str = Cache.topCache.Substring(index, Cache.topCache.Length - index);
                    if (str == "")
                    {
                        str = CalViewModel._disPlayBigText;
                    }
                    Cache.topCache = Cache.topCache.Substring(0, index) + ("negate(" + str + ")");
                    Cache.underCache = CO.Minus(Cache.underCache);
                }
            }
            else
            {
                if ("".Equals(Cache.underCache))
                {
                    if (!Cache.judgeSinge)
                    {
                        Cache.topCache = ("negate(" + "0" + ")");
                        Cache.underCache = "0";
                        Cache.judgeSinge = true;
                    }
                }
                else if (Cache.judgeSinge == true && "0".Equals(Cache.underCache))
                {
                    Cache.topCache = ("negate(" + Cache.topCache + ")");
                    Cache.underCache = "0";
                }
                else
                {
                    if ("0.".Equals(Cache.underCache))
                    {
                        Cache.underCache = sy.GetSymbol();
                    }
                    else
                    {
                        if (Cache.underCache.Contains("."))
                        {
                            Cache.underCache = sy.GetSymbol();
                        }
                        else
                        {
                            Cache.underCache = CO.Minus(Cache.underCache);
                        }
                    }
                }
            }
        }
    }
}
