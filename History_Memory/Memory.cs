using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History_Memory
{/// <summary>
/// 内存操作
/// </summary>
    public class Memory
    {
        // 内存集合
        public static List<string> list = new List<string>();

        //内存加
        public string MemAdd(string i1)
        {
            string result = "";
            if (list.Count == 0)
            {
                list.Add(i1);
            }
            else
            {
                result = (decimal.Parse(i1) + decimal.Parse(list.Last())).ToString();
            }
            return result;
        }

        // 内存减
        public string MemSub(string i1)
        {
            string result = "";
            if (list.Count == 0)
            {
                list.Add(i1);
            }
            else
            {
                result = (decimal.Parse(i1) - decimal.Parse(list.Last())).ToString();
            }
            return result;
        }

        // 清空内存
        public void MemClearAll()
        {
            list.Clear();

        }

        public void MemChange(string i1)
        {
            list.Add(i1);
        }

        // 清空内存
        public void MemClear()
        {
            list.Clear();
        }

        public void MemUse()
        {
            throw new NotImplementedException();
        }

    }
}
