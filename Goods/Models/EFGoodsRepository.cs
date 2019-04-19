using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Goods.Models
{
    public class EFGoodsRepository : IGoodsRepository
    {
        private TestContext context;

        public EFGoodsRepository(TestContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Good> Goods
            => context.Goods.FromSql("EXECUTE dbo.SELECT_GOODS").ToList();
    }
}
