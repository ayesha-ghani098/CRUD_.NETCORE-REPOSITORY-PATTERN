using FWC.WebMall.Data;
using FWC.WebMall.Data.ORMHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FWC.WebMall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------INSERT PRODUCT----------//
            //ProductHelper productHelper = new ProductHelper();
            
           // var id = productHelper.Insert("Iphone 12", "apple mobile phone..", 13, 15.99);
           // Console.WriteLine($"Inserted product with id {id}");





            //------UPDATE PRODUCT----------//
            // productHelper.Update(1, "Iphone", "Apple company phone", 13, 13.44);






            //------INSERT PRODUCT PRICE----------//
            //ProductPriceHelper productPriceHelper = new ProductPriceHelper();
            //productPriceHelper.Insert(1, new DateTime(2000, 03, 01), new DateTime(2000, 03, 31), 1000);
            // productPriceHelper.Insert(1, new DateTime(2000, 03, 23), new DateTime(2000, 03, 23), 500);
            // productPriceHelper.Insert(1, new DateTime(2000, 03, 20), new DateTime(2000, 03, 25), 560);





            //------GET PRODUCT PRICE----------//
            //var prices = productPriceHelper.GetPrice(1, new DateTime(2001, 03, 21));

            //if(prices == null)
            //{
            //   Console.WriteLine("No Product Price found with the specified date");
            //}
            // else
            // {
            //   Console.WriteLine($"Product Price is {prices.Price}");
            //  }







            //------GET PRODUCT WITH INVENTORY----------//
            //var r = productHelper.GetProductWithInventory();







            //------INSERT INVENTORY----------//
            // InventoryHelper inventoryHelper = new InventoryHelper();
            // var inventory = inventoryHelper.Insert(2, 2, 20000);
            // var inventory = inventoryHelper.Update(2, 1, 5000);
            //inventoryHelper.Delete(2); deleting frst recrd

            // var inventories = inventoryHelper.GetInventories();

            //foreach (var inventory in inventories)
            //{
            //   Console.WriteLine(inventory);
            //}









            //-----------------USING REPOSITORY PATTERN-------------//

            IProductRepository interfaceProduct;
            interfaceProduct = new ProductRepository(new Data.WebMallEntities());

           // ProductHelper productHelper = new ProductHelper();
            Product product = new Product
            {
                Name = "Iphone 12",
                Description = "apple mobile phone..",
                Size = 13,
                Weight = 200
            };
            interfaceProduct.InsertProduct(product);
            interfaceProduct.Save();


      

            IInventoryRepository interfaceInventory;
            interfaceInventory = new InterfaceRepository(new Data.WebMallEntities());

            // ProductHelper productHelper = new ProductHelper();
           Inventory inventory = new Inventory
            {
                ProductId= 50,
                WarehouseId= 10,
                Inventory1 = 100

            };
            interfaceInventory.Insert(inventory);
            interfaceInventory.Save();

        }
    }
}
