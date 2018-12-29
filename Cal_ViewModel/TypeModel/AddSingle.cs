using Cal_ViewModel.SaveModel;
using Cal_ViewModel.JudgeModel;
using Cal_ViewModel.TypeModel.SingleOperation;

namespace Cal_ViewModel.TypeModel
{
    public class AddSingle : IJudgeForSingle
    {
        //Complex_Operation CO = new Complex_Operation();
        //AddSymbol sy = new AddSymbol();

        //添加单目符号，并进行运算
        public string JudgeForSinge(string single)
        {
            Cache.count++;
            Cache.judgeTurn = true;

            Cache.operatorCacheOld = Cache.operatorCacheNew;
            if (Cache.judgeEqual)//按过＝运算，赋值结果给underCache
            {
                Cache.underCache = CalViewModel._disPlayBigText;
                Cache.judgeTurn = true;
                Cache.judgeSinge = false;
                Cache.judgeMinus = true;
            }
            switch (single)
            {
                case "√":
                    MySqrt.Sqrt();
                    break;
                case "x²":
                    MySquare.Square();
                    break;
                case "1/x":
                    MyOneCent.OneCent();
                    break;
                case "±":
                    MyMinus.Minus();
                    break;
                case "%":
                    MyPercent.Percent();                
                    break;
                case "x³":
                    MyCube.Cube();                  
                    break;
            }

            if (Cache.judgeEqual)
            {
                Cache.judgeEqual = false;
                Cache.judgeNewInp = true;
                Cache.operatorCacheOld = "";
                Cache.operatorCacheNew = "";
            }
            Cache.judgeNewInp = true;
            return Cache.topCache;
        }
    }
}