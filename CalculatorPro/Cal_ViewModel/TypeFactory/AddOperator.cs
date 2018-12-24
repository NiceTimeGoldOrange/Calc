using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.FormatFactory;
using Cal_ViewModel.OperatorModel;
using Cal_ViewModel.SaveModel;
namespace Cal_ViewModel.Symbol
{
    class AddOperator : Judge.IJudgeOperator
    {
        Basic_Opreation bo = new Basic_Opreation();
        public string JudgeOperator(string opt)
        {
            Cache.judgeNewInp = true;//输入符号后，数字肯定是新输入
            if (Cache.judgeEqual)//按过＝运算，赋值结果给underCache
            {
                Cache.underCache = Cache.resultCache;
                Cache.operatorCacheOld = "";
                Cache.resultCache = "";
            }
            // if else判断
            #region
            if (Cache.operatorCacheOld == "" && Cache.underCache == "")//开始直接输入加减乘除
            {

                Cache.operatorCacheNew = opt;
                Cache.topCache = 0 + opt;
                Cache.judgeTurn = false;
                Cache.resultCache = "0";
                Cache.underCache = "0";

            }
            else//不是直接输入加减乘除
            {
                Cache.operatorCacheNew = opt;
                if (Cache.judgeTurn)//四则运算符加减乘除是是新输入 同时进行运算
                {
                    Cache.judgeTurn = false;
                    if (Cache.judgeSinge)//对结果进行单目，不需要将结果传上去
                    {
                        if (Cache.judgeEqual)
                        {
                            Cache.topCache += Cache.underCache + opt;
                        }
                        else
                        {
                            Cache.topCache += opt;
                        }
                    }
                    else
                    {
                        Cache.topCache += AddFormat.Addformat(Cache.underCache) + opt;

                    }
                    if (Cache.resultCache == "")
                    {
                        Cache.resultCache = AddFormat.Addformat(Cache.underCache);
                        // Console.WriteLine(Cache.resultCache);
                    }
                    //新输入一个符号后的运算，只走一次
                    switch (Cache.operatorCacheOld)
                    {
                        case "＋":
                            Cache.underCache = bo.Add(Cache.resultCache, Cache.underCache).ToString();
                            Cache.resultCache = Cache.underCache;
                            break;
                        case "－":
                            Cache.underCache = bo.Sub(Cache.resultCache, Cache.underCache).ToString();
                            Cache.resultCache = Cache.underCache;
                            break;
                        case "×":
                            Cache.underCache = bo.Mul(Cache.resultCache, Cache.underCache).ToString();
                            Cache.resultCache = Cache.underCache;
                            break;
                        case "÷":
                            Cache.underCache = bo.Div(Cache.resultCache, Cache.underCache).ToString();
                            Cache.resultCache = Cache.underCache;
                            break;
                    }
                }
                else//不是新输入符号
                {
                    Cache.operatorCacheNew = opt;
                    Cache.topCache = Cache.topCache.Substring(0, Cache.topCache.Length - 1) + opt;
                }
            }
            #endregion
            Cache.judgeEqual = false;
            return Cache.topCache;
        }

    }
}
