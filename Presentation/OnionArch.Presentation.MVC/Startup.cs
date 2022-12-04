using OnionArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace OnionArch.Presentation.MVC
{
    public class Startup
    {
        IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddControllersWithViews();
            services.AddDbContext<OnionArchDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("OnionArchCnnString"));
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("defaultRoute", "{Controller=Home}/{Action=Index}");
            });
        }
    }
}