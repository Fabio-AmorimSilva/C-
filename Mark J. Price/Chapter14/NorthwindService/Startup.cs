using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NorthwindContextLib;
using NorthwindService.Repositories;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace NorthwindService
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

            string dataBasePath = Path.Combine("..", "Northwind.Sqlite3.db");

            services.AddDbContext<Northwind>(options => 
                options.UseSqlite($"Data Source={dataBasePath}"));

            services.AddControllers(options =>
                {
                    Console.WriteLine("Default output formatters:");
                    foreach(IOutputFormatter formatter in options.OutputFormatters){

                        var mediaFormatter = formatter as OutputFormatter;
                        if(mediaFormatter == null){
                            Console.WriteLine($"{formatter.GetType().Name}");

                        }else{ //OutputFormatter class has SupportedMediaTypes
                            Console.WriteLine("{0}, Media Types: {1}",
                                arg0: mediaFormatter.GetType().Name,
                                arg1: string.Join(", ",
                                    mediaFormatter.SupportedMediaTypes));
                        }
                    }
                })
                .AddXmlDataContractSerializerFormatters()
                .AddXmlSerializerFormatters()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NorthwindService", Version = "v1" });
            });

            //Register the CustomerRepository for use at runtime
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            //Register the Swagger generator and define a Swagger document
            //for Northwind service
            services.AddSwaggerGen(options => {
                options.SwaggerDoc(name: "v0", info: new OpenApiInfo{
                    Title = "Northwind Service API", Version="v1"
                });
            });

            services.AddCors();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", 
                    "NorthwindService Service API Version 1");
                    
                    c.SupportedSubmitMethods(new[] {
                        SubmitMethod.Get, SubmitMethod.Post,
                        SubmitMethod.Put, SubmitMethod.Delete });
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //must be after UseRouting and before UseEndpoints
            app.UseCors(configurePolicy: options =>{
                options.WithMethods("GET", "POST", "PUT", "DELETE");
                options.WithOrigins(
                    "https://localhost:5002"); //for MVC client
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
