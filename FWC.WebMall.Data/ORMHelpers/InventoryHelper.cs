using System.Linq;


namespace FWC.WebMall.Data.ORMHelpers
{
    public class InventoryHelper
    {
        public int Insert(int ProductId,int WarehouseId, int Inventory1)
        {
           Inventory inventory = new Inventory()
            {
            ProductId = ProductId,
            WarehouseId = WarehouseId,
            Inventory1 = Inventory1
            };
            var db = new WebMallEntities();

            db.Inventories.Add(inventory);
            db.SaveChanges();
            db.Dispose();

            return inventory.Id;
        }

        public int Update(int ProductId, int WarehouseId, int Inventory1)
        {
            var db = new WebMallEntities();

            var inventory = db.Inventories.Where(i => i.ProductId ==  ProductId ).First();


            inventory.WarehouseId = WarehouseId;
            inventory.Inventory1 = Inventory1;


            db.SaveChanges();
            db.Dispose();

            return inventory.Id;
        }
        public int Delete(int ProductId)
        {
            var db = new WebMallEntities();

            var inventory = db.Inventories.Where(i => i.ProductId == ProductId).First();

            db.Inventories.Remove(inventory);


            db.SaveChanges();
            db.Dispose();

            return inventory.Id;
        }

  


    }
}
