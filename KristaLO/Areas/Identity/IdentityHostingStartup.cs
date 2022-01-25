
using KristaLO.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(KristaLO.Areas.Identity.IdentityHostingStartup))]
namespace KristaLO.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<NourishDbContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<NourishDbContext>();

            });
        }
    }
}