using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWC.WebMall.Data.ORMHelpers
{
    public class InventoryRespository : IInventoryRepository
    {
        private WebMallEntities _context;
        public InventoryRespository(WebMallEntities context)
        {
            this._context = context;
        }
        public void DeleteProduct(int inventoryId)
        {
            Inventory inventory = _context.Inventories.Find(inventoryId);
            _context.Inventories.Remove(inventory);
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public void Insert(Inventory inventory)
        {
            _context.Inventories.Add(inventory);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateProduct(Inventory inventory)
        {
            _context.Entry(inventory).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
