using FWC.WebMall.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FWC.WebMall.Data.ORMHelpers
{
   public class ProductHelper
    {
        public int Insert(string Name, string Description, int Size, Double Weight)
        {
            Product product = new Product()
            {
                Name = Name,
                Description = Description,
                Size = Size,
                Weight = Weight,
            };
            var db = new WebMallEntities();

            db.Products.Add(product);
            db.SaveChanges();
            db.Dispose();

            return product.Id;

        }

        public int Update(int ProductId,string Name, string Description, int Size, Double Weight)
        {
            var db = new WebMallEntities();

            var product = db.Products.Where(p => p.Id == ProductId).First();


            product.Name = Name;
            product.Description = Description;
            product.Size = Size;
            product.Weight = Weight;
       
           
            db.SaveChanges();
            db.Dispose();

            return product.Id;

        }

        public List<ProductWithInvertory> GetProductWithInventory()
        {
            var db = new WebMallEntities();

         //  var result = db.Products.Join(db.Inventories, p => p.Id, i => i.ProductId,
         //                               (p, i) => new
         //                              {
         //                                  p.Id,
         //                                   p.Name,
         //                                   i.Inventory1,
         //                                   i.WarehouseId
         //                                 
         //                                }).ToList()
         //                                .Join(db.WareHouses, t => t.WarehouseId , w => w.Id,
         //                                (t, w) => new
         //                                {
         //                                   t.Id,
         //                                   t.Name,
         //                                    t.Inventory1,
         //                                   w.Code
         //                                }).ToList();


            //----FOR SELECTING ALL *------//
            var result = db.Products.Join(db.Inventories, p => p.Id, i => i.ProductId,
                                     (p, i) => new
                                     {
                                         p,i
                                     }).ToList()
                                     .Join(db.WareHouses, t => t.i.WarehouseId, w => w.Id,
                                     (t, w) => new
                                     {
                                         t.p,
                                         t.i,
                                         w
                                     }).ToList();

            var resultlist = new List<ProductWithInvertory>();



            result.ForEach(r =>
            {
                resultlist.Add(new ProductWithInvertory()
                {
                    ProductId=r.p.Id,
                    ProductName=r.p.Name,
                    WareHouseCode=r.w.Code,
                    Inventory=r.i.Inventory1
                });
            }
            );

            return resultlist;
         
        }
    }
}
