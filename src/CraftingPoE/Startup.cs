using System;
using CraftingPoE.Models;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Data.Entity;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;

namespace CraftingPoE
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            // Setup configuration sources.
            Configuration = new Configuration().AddJsonFile("config.json").AddEnvironmentVariables();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            // Add EF services to the services container.
            services.AddEntityFramework()
                        .AddSqlServer()
                        .AddDbContext<CraftingDbContext>(
                        //options =>
                        //{
                        //    options.UseSqlServer(Startup.Configuration.Get("Data:DefaultConnection:ConnectionString"));
                        //}
                        );
            services.AddEntityFramework().AddSqlServer().AddDbContext<CraftingDbContext>();

            services.AddMvc();

            //Resolve dependency injection
            services.AddScoped<ICraftingRepo, CraftingRepo>();
            services.AddScoped<CraftingDbContext, CraftingDbContext>();
        }
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
            app.UseMvc();

            app.UseWelcomePage();

        }
    }
}
