using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using InternetShop.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using InternetShop.Data.Code;
using Microsoft.Extensions.Configuration;
using InternetShop.Service;
using InternetShop.Data.Repositories;

namespace InternetShop.Web
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ShopDBContext")));

           
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IDbFactory, DbFactory>();

           //services.AddTransient(typeof(IRepository<>), typeof(RepositoryBase<>));

            services.AddTransient<IGroupService, GroupService>();
            services.AddTransient<IGroupRepository, GroupRepository>();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICityRepository, CityRepository>();

            services.AddTransient<IFactorService, FactorService>();
            services.AddTransient<IFactorRepository, FactorRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IRoleRepository, RoleRepository>();

            services.AddTransient<IAgencyService, AgencyService>();
            services.AddTransient<IAgencyRepository, AgencyRepository>();

            services.AddTransient<IFactorItemService, FactorItemService>();
            services.AddTransient<IFactorItemRepository, FactorItemRepository>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    serviceScope.ServiceProvider.GetService<ShopDBContext>().Database.Migrate();
                    serviceScope.ServiceProvider.GetService<ShopDBContext>().EnsureSeedData();
                }
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
