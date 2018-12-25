using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History_Memory
{/// <summary>
/// 对历史记录的操作
/// </summary>
    class History
    {
        public static List<string> his = new List<string>();

        //存入历史记录
        public void AddHis(string i1)
        {
            his.Add(i1);
        }

        // 查看历史记录
        public List<string> CheckHis()
        {
            return his;
        }

        // 清除所有历史记录
        public void ClearAllHis()
        {
            his.Clear();
        }
    }
}
