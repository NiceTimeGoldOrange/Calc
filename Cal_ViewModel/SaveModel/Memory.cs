using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.SaveModel
{
    public class Memory : IMSChange, IMSClear, IMSUse
    {
        public static List<string> mymemory = new List<string>();

        public void MSChange(string num)
        {
            mymemory.Add(num);
            Cache.judgeNewInp = true;
        }
        public List<string> GetMemory()
        {
            return mymemory;
        }

        public void MSClear()
        {
            mymemory.Clear();
        }
        public void MSMinus(string num)
        {
            if (mymemory.Count == 0)
            {
                mymemory.Add(num);
            }
            else
            {
                mymemory[mymemory.Count - 1] = (Convert.ToDecimal(mymemory.Last()) - Convert.ToDecimal(num)).ToString();
            }
            Cache.judgeNewInp = true;
        }
        public void MSPlus(string num)
        {
            if (mymemory.Count == 0)
            {
                mymemory.Add(num);
            }
            else
            {
                mymemory[mymemory.Count - 1] = (Convert.ToDecimal(mymemory.Last()) + Convert.ToDecimal(num)).ToString();
            }
            Cache.judgeNewInp = true;
        }
        public void MSUse()
        {
            throw new NotImplementedException();
        }
    }
}
