using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_ViewModel.StoreModel
{
    interface IStore
    {
        List<decimal> StoreMem(decimal i1);
    }
}
