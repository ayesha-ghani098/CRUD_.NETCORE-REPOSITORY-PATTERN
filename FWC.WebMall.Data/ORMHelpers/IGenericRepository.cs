using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWC.WebMall.Data.ORMHelpers
{
    public interface IRepository<T> where T : BaseEntity
    {
        Product GetProductById(int productId);
       void DeleteProduct(int productId);
   IEnumerable<Product> GetProducts();
      void InsertProduct(Product product);
       void Save();
        void UpdateProduct(Product product);
    }
}
