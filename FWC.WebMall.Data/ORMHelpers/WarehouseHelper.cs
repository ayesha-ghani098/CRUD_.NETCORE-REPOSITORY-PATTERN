using System.Linq;

namespace FWC.WebMall.Data.ORMHelpers
{
    public class WarehouseHelper
    {
        public int Insert(string Code, string Location)
        {
           WareHouse warehouse = new WareHouse()
            {
                Code = Code,
               Location = Location
            };
            var db = new WebMallEntities();

            db.WareHouses.Add(warehouse);
            db.SaveChanges();
            db.Dispose();

            return warehouse.Id;
        }

        public int Update(int Id, string Code, string Location)
        {
            var db = new WebMallEntities();

            var warehouse = db.WareHouses.Where(w => w.Id == Id).First();

            warehouse.Code = Code;
            warehouse.Location = Location;




            db.SaveChanges();
            db.Dispose();

            return warehouse.Id;
        }
        public int Delete(int Id)
        {
            var db = new WebMallEntities();

            var warehouse = db.WareHouses.Where(w => w.Id == Id).First();

            db.WareHouses.Remove(warehouse);


            db.SaveChanges();
            db.Dispose();

            return warehouse.Id;
        }

      
    }
}
