using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryApp.Core.DomainService;
using GroceryApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryApp.Data.Repositories
{
    public class StoreRepo: IStoreRepo
    {
        private readonly GroceryAppContext _ctx;

        public StoreRepo(GroceryAppContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Stores> ReadAll()
        {
            return _ctx.Stores;
        }

        public Stores ReadById(int id)
        {
            return _ctx.Stores.AsNoTracking().FirstOrDefault(s => s.Id == id);
        }
    }
}
