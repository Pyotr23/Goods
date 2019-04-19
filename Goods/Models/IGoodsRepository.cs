using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Goods.Models
{
    public interface IGoodsRepository
    {
        IEnumerable<Good> Goods { get; }
    }
}
