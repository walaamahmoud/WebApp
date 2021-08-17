using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using WebApp.BL.Interfaces;
using WebApp.BL.Repository;
using WebApp.DAL.Database;
using Microsoft.EntityFrameworkCore;
using WebApp.BL.Mapper;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace WebApp
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddNewtonsoftJson(opt => {
                opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
            services.AddScoped<IDepartmentsRepo, DepartmentsRepo>();
            services.AddScoped<IEmployeesRepo, EmployeesRepo>();
            services.AddScoped<IDistrictsRepo, DistrictsRepo>();
            services.AddScoped<ICitiesRepo, CitiesRepo>();
            services.AddScoped<ICountriesRepo, CountriesRepo>();
            services.AddDbContextPool<WebAppDBContext>(opts =>
           opts.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<WebAppDBContext>();
            services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
