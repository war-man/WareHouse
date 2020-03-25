using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Linq;
using System.Reflection;
using WareHouse.Core.Data;

namespace WareHouse.Web
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
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            var baseType = typeof(IService);
            Assembly.Load("WareHouse.Service").GetTypes()
                .Where(type => type.IsClass && !type.IsAbstract && !type.IsNested && !type.IsSealed)
                .Where(type => type.BaseType != null)
                .Where(type => type.GetInterface(baseType.FullName) != null)
                .ToList().ForEach(t =>
                {
                    var interfaceList = t.GetInterfaces().Where(c => c != baseType);
                    foreach (var inter in interfaceList)
                    {
                        services.TryAddScoped(inter, t);
                    }
                });

            services.AddSession();

            services.AddDbContext<WareHouseDbContext>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}