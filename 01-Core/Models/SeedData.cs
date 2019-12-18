using _01_Core.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Core.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                ProductDbContext context = serviceScope.ServiceProvider.GetService<ProductDbContext>();

                context.Database.Migrate();
                if (context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product() { ProductName = "Chai", Description = "Delicious", Price = 4 },
                        new Product() { ProductName = "Chang", Description = "Delicious", Price = 14 },
                        new Product() { ProductName = "Ikura", Description = "Delicious", Price = 42 },
                        new Product() { ProductName = "Kombu", Description = "Delicious", Price = 43 }
                        );
                }
                context.SaveChanges();
            }
        }
    }
}
