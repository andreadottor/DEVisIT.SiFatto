namespace DEVisIT.SiFatto.Web
{
    using DEVisIT.SiFatto.ApplicationCore;
    using DEVisIT.SiFatto.ApplicationCore.Settings;
    using DEVisIT.SiFatto.Infrastructure;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.HttpsPolicy;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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
            services.AddRazorPages();
            services.AddApplicationCore();
            services.AddInfrastructure();

            var cs1 = Configuration.GetConnectionString("DefaultConnection");
            var cs2 = Configuration.GetSection("ConnectionStrings")["DefaultConnection"];
            var cs3 = Configuration.GetValue<string>("ConnectionStrings:DefaultConnection");

            //services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddOptions<MailSettings>()
                    .Bind(Configuration.GetSection("MailSettings"))
                    .ValidateDataAnnotations();

            var mailSettings = new MailSettings();
            Configuration.GetSection("MailSettings").Bind(mailSettings);
            services.AddSingleton(mailSettings);
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
