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
    }
}
