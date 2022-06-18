using System;
using System.Linq;


namespace FWC.WebMall.Data.ORMHelpers
{
    public class ProductPriceHelper
    {
        public void Insert(int productId, DateTime? StartFrom, DateTime? EndAt, int Price)
        {
            ProductPrice productPrice = new ProductPrice()
            {
                ProductId = productId,
                StartFrom = StartFrom,
                EndAt = EndAt,
                Price = Price
            };

            var db = new WebMallEntities();

            db.ProductPrices.Add(productPrice);
            db.SaveChanges();
            db.Dispose();
        }

        public ProductPrice GetPrice(int ProductId, DateTime dateTime)
        {
            var db = new WebMallEntities();

            var pricesQuery = db.ProductPrices.AsQueryable();
            pricesQuery = pricesQuery.Where(p => p.ProductId == ProductId && p.StartFrom <= dateTime && p.EndAt >= dateTime);
            pricesQuery = pricesQuery.OrderByDescending(p => p.StartFrom);

            //var prices = pricesQuery.ToList(); for multiple values
           // var prices = pricesQuery.First(); for first value
            var prices = pricesQuery.FirstOrDefault(); // if no value then return null

            return prices;
        }

        // QUERIES WE ARE USING
        // LINQ Language Integrated Query
        // Add, where, orderby
        // join -> inner join here 
    }

   
}
