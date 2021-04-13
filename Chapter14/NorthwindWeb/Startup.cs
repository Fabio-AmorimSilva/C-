using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Routing;
using System.IO;
using Microsoft.EntityFrameworkCore;
using NorthwindContextLib;
using Packt.CS7;

namespace NorthwindWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            string dataBasePath = Path.Combine("..", "Northwind.Sqlite3.db");

            services.AddEntityFrameworkSqlite().AddDbContext<Northwind>(options => 
                options.UseSqlite($"Data Source={dataBasePath}"));            
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseDefaultFiles(); //index.html, default.html and so on
            app.UseStaticFiles();

            app.Use(async (HttpContext context, Func<Task> next) => {
                var rep = context.GetEndpoint() as RouteEndpoint;
                if(rep != null){
                    Console.WriteLine($"Endpoint name: {rep.DisplayName}");
                    Console.WriteLine($"Endpoint route patern: {rep.RoutePattern.RawText}");

                }

                if(context.Request.Path == "/bonjour"){
                    // in the case of a match on URL path, this becomes a terminating
                    // delegate that returns so does not call the next delegate
                    await context.Response.WriteAsync("Bonjour Monde!");

                }

                // we could modify the request before calling the next delegate
                await next();
                // we could modify the request after calling the next delegate

            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapGet("/hello", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
