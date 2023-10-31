using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.data.Concrete;
using cv.entity.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace cv.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllersWithViews();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Login/Index"; // Giriş yapma sayfasının URL'sini belirtin
            });

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); //wwwroot

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapGet("/", async context =>
                // {
                //     await context.Response.WriteAsync("Hello World!");
                // });
                endpoints.MapControllerRoute(
                   name: "start",
                   pattern: "/",
                   defaults: new { controller = "Home", action = "Index" }
               );
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "admin",
                    defaults: new { controller = "Admin", action = "Index" }
                );
                endpoints.MapControllerRoute(
                    name: "experiences",
                    pattern: "admin/experiences",
                    defaults: new { controller = "Admin", action = "Experiences" }
                );
                endpoints.MapControllerRoute(
                    name: "experiences",
                    pattern: "admin/addExperience",
                    defaults: new { controller = "Admin", action = "ExperienceAdd" }
                );
                endpoints.MapControllerRoute(
                    name: "login",
                    pattern: "Login/Index",
                    defaults: new { controller = "Login", action = "Index" }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
