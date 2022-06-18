using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWC.WebMall.Data.ORMHelpers
{
    public interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productId);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        void Save();
    }
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetProducts();
        T GetProductById(int productId);
        void InsertProduct(T product);
        void UpdateProduct(T product);
        void DeleteProduct(int productId);
        void Save();
    }
}
