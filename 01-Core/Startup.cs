using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Core.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace _01_Core
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProductDbContext>(option => option.UseSqlServer("Server = .; Database = OZamanDansCoreDB; uid = sa ; pwd = 123"));
            services.AddMvc();
            //noteservices.AddScoped<IProductRepository, EFProductRepository>();
            //noteservices.AddSingleton<IProductRepository, EFProductRepository>();
            services.AddTransient<IProductRepository, EFProductRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
            app.UseStatusCodePages();
        }
    }
}
