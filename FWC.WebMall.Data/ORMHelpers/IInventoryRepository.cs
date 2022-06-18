using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWC.WebMall.Data.ORMHelpers
{
    public interface IInventoryRepository : IDisposable
    {
       void Insert(Inventory inventory);
       void Update(Inventory inventory);
       void Delete(int inventoryId);
        void Save();

    }
    public interface IIGenericRepository<T> where T : class
    {
        void Insert(Inventory inventory);
        void Update(Inventory inventory);
        void Delete(int inventoryId);
        void Save();
    }
}
