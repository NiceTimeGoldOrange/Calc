using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.SaveModel;
using Cal_ViewModel.FormatModel;
using Cal_ViewModel.JudgeModel;

namespace Cal_ViewModel.AddNumber
{
    class NumberZero : IJudgeZero

    {

        public string JudgeZero()

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

            if (CalViewModel._disPlayText != "")

            {



                if (CalViewModel._disPlayText.Last().ToString() == ")")

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

            if (Cache.underCache == "")

            {

                Cache.underCache = "0";

                return AddFormat.Addformat(Cache.underCache);

            }

            if (Cache.underCache != "0")

            {



                Cache.underCache += 0;

                return Cache.underCache;

            }

            return "0";



        }

    }



}