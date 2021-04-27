using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryApp.Core.AppService;
using GroceryApp.Core.AppService.Services;
using GroceryApp.Core.DomainService;
using GroceryApp.Data;
using GroceryApp.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GroceryApp.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GroceryAppContext>(
                opt =>
                {
                    opt.UseSqlite("Data Source= GroceryLocatorApp.db");
                });


            services.AddScoped<IStoreRepo, StoreRepo>();
            services.AddScoped<IStoreService, StoreService>();
            services.AddTransient<IDBInitialiser, DBInitialiser>();
            services.AddControllers();

           
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GroceryApp.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GroceryApp.WebApi v1"));
                using var scope = app.ApplicationServices.CreateScope();
                var ctx = scope.ServiceProvider.GetRequiredService<GroceryAppContext>();
                var DBInitialiser = scope.ServiceProvider.GetRequiredService<IDBInitialiser>();

                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();
                DBInitialiser.SeedDB(ctx);



            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
