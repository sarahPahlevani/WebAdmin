using System;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace RealEstateAdmin
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
            services.Configure<CookiePolicyOptions>(o =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                o.CheckConsentNeeded = context => true;
                o.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.Configure<CookieTempDataProviderOptions>(options => {
                options.Cookie.IsEssential = true;
            });

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.Configure<AppSetting>(Configuration.GetSection(nameof(AppSetting)));
            services.AddTransient<ApiCaller, ApiCaller>();
            services.AddTransient<CurrentUser, CurrentUser>();
            services.AddTransient<Langs, Langs>();
            services.AddTransient<MenuLayout, MenuLayout>();

            services.AddMemoryCache();
            services.AddSession();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            //var cultureInfo = new CultureInfo("en-US");
            //var cultureInfo = new CultureInfo("hu-HU");
            var cultureInfo = new CultureInfo("de-DE");
            //cultureInfo.DateTimeFormat.DateSeparator = "-";
            //cultureInfo.DateTimeFormat.FullDateTimePattern = "yyyy-MM-dd h:mm tt";
            cultureInfo.NumberFormat.CurrencySymbol = "€";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            app.UseCookiePolicy();
            app.UseSession();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
