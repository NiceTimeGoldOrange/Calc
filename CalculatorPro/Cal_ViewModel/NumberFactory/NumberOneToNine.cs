using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.SaveModel;

namespace Cal_ViewModel.AddNumber
{
    public class NumberOneToNine : Judge.IJudgeForNumber

    {
        public string Judgefornumber(string number)
        {
            if (Cache.judgeEqual)
            {
                Cache.operatorCacheOld = "";
                Cache.operatorCacheNew = "";
                Cache.resultCache = "";
                Cache.judgeTurn = true;
                Cache.judgeSinge = false;
                Cache.judgeEqual = false;
                Cache.judgeMinus = true;
            }
            //单目后直接输入数字
            if (CalViewModel._disPlayTextTop != "")
            {
                if (CalViewModel._disPlayTextTop.Last().ToString() == ")" || Cache.judgeSinge)
                {
                    if (Cache.operatorCacheNew == "")
                    {
                        Cache.topCache = "";
                    }
                    else
                    {
                        Cache.topCache = Cache.topCache.Substring(0, Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1);
                    }
                    Cache.underCache = "0";
                }
            }
            Cache.operatorCacheOld = Cache.operatorCacheNew;
            Cache.judgeTurn = true;
            Cache.judgeSinge = false;
            if (Cache.judgeNewInp)
            {
                Cache.underCache = "";
                Cache.judgeNewInp = false;
            }
            if (Cache.underCache == "0")
            {
                Cache.underCache = "";
            }
            Cache.underCache += number;
            return Cache.underCache;
        }
    }
}