using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryApp.Core.Entities;

namespace GroceryApp.Core.AppService
{
    public interface IStoreService
    {
        Stores ReadById(int id);
        List<Stores> ReadAll();
    }
}
