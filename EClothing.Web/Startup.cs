using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EClothing.Infra;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace EClothing.Web
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
            services.AddDbContext<EClothingContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("ConnectionStringDocker")));

            // services.AddAuthentication(options =>
            // {
            //     options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //     options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;

            // })
            // .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
            // .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
            //     {

            //         options.Authority = "http://localhost:5001";

            //         //habilita o uso do http // sem httpS
            //         options.RequireHttpsMetadata = false;
            //         options.ClientId = "mvc";
            //         options.SaveTokens = true;
            //         options.ClientSecret = "super-secret";
            //         options.ResponseType = OpenIdConnectResponseType.Code;
            //         options.Scope.Add("openid");
            //         options.Scope.Add("profile");
            //     });


            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Cookies";
                options.DefaultChallengeScheme = "oidc";

            })
            .AddCookie("Cookies")
            .AddOpenIdConnect("oidc", options =>
            {
                options.ClientId = "mvc";
                options.ResponseType = OpenIdConnectResponseType.IdTokenToken;
                options.SignInScheme = "Cookies";
                options.RequireHttpsMetadata = false;
                options.Authority = "http://localhost:5001";
                options.ClientSecret = "super-secret";

                options.SaveTokens = true;
                options.GetClaimsFromUserInfoEndpoint = true;


                options.Scope.Add("openid");
                options.Scope.Add("profile");
                options.Scope.Add("roles");
                options.ClaimActions.MapUniqueJsonKey("role", "role");

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    RoleClaimType = "role"
                };



            });
            services.AddAuthorization();


            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
                endpoints.MapDefaultControllerRoute()
                    .RequireAuthorization();
            });

            //  app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapControllerRoute(
            //         name: "default",
            //         pattern: "{controller=Home}/{action=Index}/{id?}");
            // });
        }
    }
}
