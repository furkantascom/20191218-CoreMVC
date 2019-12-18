using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Core.Models.Repository
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        bool Insert(Product product);
        Product GetByID(int id);
        bool Update(Product product);
        bool Delete(int id);
    }
}
