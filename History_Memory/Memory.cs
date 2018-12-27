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

        // 添加内存
        public void MSChange(string i1)
        {
            list.Add(i1);
            Loading.isNewNum = true;
        }

        public List<string> GetMemory()
        {
            return list;
        }

        public void MsClear()
        {
            list.Clear();
        }

        // 取反
        public void MsMinus(string i1)
        {
            if (list.Count == 0)
            {
                list.Add(i1);
            }
            else
            {
                list[list.Count - 1] = (decimal.Parse(list.Last()) - decimal.Parse(i1)).ToString();
            }
            Loading.isNewNum = true;
        }

        //内存加
        public void MemAdd(string i1)
        {
            if (list.Count == 0)
            {
                list.Add(i1);
            }
            else
            {
                list[list.Count - 1] = (decimal.Parse(i1) + decimal.Parse(list.Last())).ToString();
            }
            Loading.isNewNum = true;
        }

        public void MemUse()
        {
            throw new NotImplementedException();
        }

    }
}
