using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal_ViewModel.SaveModel;
using Cal_ViewModel.JudgeModel;

namespace Cal_ViewModel.AddNumber
{
    public class Dot : IJudgeForDot

    {
        public string Judgefordot()
        {
            if (Cache.judgeNewInp)
            {
                Cache.underCache = "";
                Cache.judgeNewInp = false;
            }
            //点.只对Cache.underCache进行操作
            if (Cache.underCache.Contains("."))

            {
                return Cache.underCache;
            }
            else
            {
                if (Cache.underCache == "")
                {
                    Cache.underCache = Cache.underCache + "0.";
                }
                else
                {
                    Cache.underCache = Cache.underCache + ".";
                }
                return Cache.underCache;
            }
        }
    }
}