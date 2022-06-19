using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWC.WebMall.Data.ORMHelpers
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly WebMallEntities _context;
        public Repository(WebMallEntities context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void DeleteProduct(int productId)
        {
            Product product = _context.Products.Find(productId);
            _context.Products.Remove(product);
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
