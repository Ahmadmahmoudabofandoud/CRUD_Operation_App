 using CRUD.BLL.Interfaces;
using CRUD.BLL.Repositories;
using CRUD.DAL.Data;
using CRUD.DAL.Models;
using CRUD_Operation_App.Extensions;
using CRUD_Operation_App.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Operation_App
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
            services.AddControllersWithViews();

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            // ApplicationServicesExtensions.AddApplicationServices(services); // Call as Static Method

            services.AddApplicationServices(); // Call as Extension Method 
            
            services.AddAutoMapper(M =>M.AddProfile(new MappingProfiles()));
            
    
            services.AddIdentity<ApplicationUser,IdentityRole>(config=>
            {
				config.Password.RequiredUniqueChars = 2; // عدد الأحرف الفريدة المطلوبة
				config.Password.RequireNonAlphanumeric = true; // إلزامية وجود أحرف غير ألفانوميرية (مثل @#$%)
				config.Password.RequireDigit = true; // إلزامية وجود أرقام
				config.Password.RequiredLength = 8; // الحد الأدنى لطول كلمة المرور
				config.Password.RequireLowercase = true; // إلزامية وجود أحرف صغيرة
				config.Password.RequireUppercase = true; // إلزامية وجود أحرف كبيرة


			})
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = "/Account/SignIn";
                config.ExpireTimeSpan = TimeSpan.FromMinutes(10);   
            });

            //services.AddAuthentication("Cookies")
            //    .AddCookie("Hamada", config =>
            //    {
            //        config.LoginPath = "/Account/SignIn";
            //        config.AccessDeniedPath = "/Home/Error";

            //    });

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

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
