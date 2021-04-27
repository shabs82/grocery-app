using GroceryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryApp.Core.DomainService;

namespace GroceryApp.Core.AppService.Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepo _storeRepo;

        public StoreService(IStoreRepo storeRepo)
        {
            _storeRepo = storeRepo;
        }
        public List<Stores> ReadAll()
        {
            return _storeRepo.ReadAll().ToList();
        }

        public Stores ReadById(int id)
        {

            return _storeRepo.ReadById(id);
        }
    }
}
