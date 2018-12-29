using Cal_ViewModel.OperatorModel;
using Cal_ViewModel.SaveModel;
using System;

namespace Cal_ViewModel.TypeModel.SingleOperation
{
    class MyPercent
    {
        public static void Percent()
        {
            Complex_Operation CO = new Complex_Operation();
            //是否进行过等号运算
            if (!Cache.judgeEqual)
            {
                //是否进行过双目运算
                if ("".Equals(Cache.operatorCacheOld))
                {
                    Cache.topCache = "0";
                    Cache.underCache = "0";
                }
                else
                {
                    //如果没有新的输入，数据加减乘除后直接进行百分号运算
                    if (Cache.judgeNewInp)
                    {
                        if ("＋".Equals(Cache.operatorCacheNew) || "－".Equals(Cache.operatorCacheNew))
                        {
                            int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1;
                            string str = Cache.topCache.Substring(0, index);
                            Cache.topCache = str + (Convert.ToDecimal(Cache.underCache) * Convert.ToDecimal(Cache.underCache) / 100).ToString();
                            Cache.underCache = (Convert.ToDecimal(Cache.underCache) * Convert.ToDecimal(Cache.underCache) / 100).ToString();
                            Cache.judgeSinge = true;
                        }
                        else if ("×".Equals(Cache.operatorCacheNew) || "÷".Equals(Cache.operatorCacheNew))
                        {
                            int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1;
                            string str = Cache.topCache.Substring(0, index);
                            Cache.topCache = str + (Convert.ToDecimal(Cache.underCache) / 100).ToString();
                            Cache.underCache = (Convert.ToDecimal(Cache.underCache) / 100).ToString();
                            Cache.judgeSinge = true;
                        }
                    }
                    //有新的输入，数据加减乘除数据之后进行百分号运算
                    else
                    {
                        if ("＋".Equals(Cache.operatorCacheNew) || "－".Equals(Cache.operatorCacheNew))
                        {
                            int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1;
                            string str = Cache.topCache.Substring(0, index);
                            Cache.topCache = str + (Convert.ToDecimal(Cache.resultCache) * Convert.ToDecimal(Cache.underCache) / 100).ToString();
                            Cache.underCache = (Convert.ToDecimal(Cache.resultCache) * Convert.ToDecimal(Cache.underCache) / 100).ToString();
                            Cache.judgeSinge = true;
                        }
                        else if ("×".Equals(Cache.operatorCacheNew) || "÷".Equals(Cache.operatorCacheNew))
                        {
                            int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1;
                            string str = Cache.topCache.Substring(0, index);
                            Cache.topCache = str + (Convert.ToDecimal(Cache.underCache) / 100).ToString();
                            Cache.underCache = (Convert.ToDecimal(Cache.underCache) / 100).ToString();
                            Cache.judgeSinge = true;
                        }
                    }
                }
            }
            //如果没有过等号运算
            else
            {
                if ("".Equals(Cache.operatorCacheNew))
                {
                    Cache.topCache = "0";
                    Cache.underCache = "0";
                }
                else
                {
                    if ("＋".Equals(Cache.operatorCacheNew) || "－".Equals(Cache.operatorCacheNew))
                    {
                        Cache.topCache = (Convert.ToDecimal(CalViewModel._disPlayBigText) * Convert.ToDecimal(CalViewModel._disPlayBigText) / 100).ToString();
                        Cache.underCache = (Convert.ToDecimal(CalViewModel._disPlayBigText) * Convert.ToDecimal(CalViewModel._disPlayBigText) / 100).ToString();
                        Cache.judgeSinge = true;
                    }
                    else if ("×".Equals(Cache.operatorCacheNew) || "÷".Equals(Cache.operatorCacheNew))
                    {
                        Cache.topCache = (Convert.ToDecimal(CalViewModel._disPlayBigText) / 100).ToString();
                        Cache.underCache = (Convert.ToDecimal(CalViewModel._disPlayBigText) / 100).ToString();
                        Cache.judgeSinge = true;
                    }
                }
            }
        }
    }
}
