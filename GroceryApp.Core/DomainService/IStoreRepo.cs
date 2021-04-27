using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryApp.Core.Entities;

namespace GroceryApp.Core.DomainService
{
    public interface IStoreRepo
    {
        Stores ReadById(int id);
        IEnumerable<Stores> ReadAll();
    }
}
