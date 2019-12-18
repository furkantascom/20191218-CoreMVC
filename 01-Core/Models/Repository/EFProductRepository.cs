using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Core.Models.Repository
{
    public class EFProductRepository : IProductRepository
    {
        private ProductDbContext _context;
        public EFProductRepository(ProductDbContext context)
        {
            _context = context;
        }
        public IQueryable<Product> Products => _context.Products;

        public bool Delete(int id)
        {
            _context.Products.Remove(GetByID(id));
            return _context.SaveChanges() > 0;
        }

        public Product GetByID(int id)
        {
            return _context.Products.Find(id);
        }

        public bool Insert(Product product)
        {
            _context.Products.Add(product);
            return _context.SaveChanges() > 0;
        }

        public bool Update(Product product)
        {
            _context.Products.Update(product);
            return _context.SaveChanges() > 0;
        }
    }
}
