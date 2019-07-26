using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oils.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oils.Data.Domains;
using Oils.Services;

namespace Oils
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
            
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<OilsDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDefaultIdentity<OilsUser>()
            //    .AddDefaultUI(UIFramework.Bootstrap4)
            //    .AddEntityFrameworkStores<OilsDbContext>();

            services.AddIdentity<OilsUser, IdentityRole>(o =>
            {
                o.Password.RequiredLength = 3;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequireDigit = false;

            })
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<OilsDbContext>()
                .AddDefaultTokenProviders(); ;


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //Password settings
            services.Configure<IdentityOptions>(o =>
            {



            });

            //Application services
            services.AddTransient<IOrdersService, OrdersService>();
            services.AddTransient<IProductsService, ProductsService>();
            services.AddTransient<IDataSeeder, SeedService>();
            services.AddTransient<INomenclaturesService, NomenclaturesServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Adding Roles
            //using (var serviceScope = app.ApplicationServices.CreateScope())
            //{
            //    using (var context = serviceScope.ServiceProvider.GetRequiredService<OilsDbContext>())
            //    {
            //        context.Database.EnsureCreated();
            //        if (!context.Roles.Any())
            //        {
            //            context.Roles.Add(new IdentityRole
            //            {
            //                Name = "Admin",
            //                NormalizedName = "ADMIN"
            //            });
            //            context.Roles.Add(new IdentityRole
            //            {
            //                Name = "User",
            //                NormalizedName = "USER"
            //            });
            //            context.SaveChanges();
            //        }
            //    }
            //}

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
  
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
