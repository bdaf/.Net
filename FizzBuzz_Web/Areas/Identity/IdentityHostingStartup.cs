using System;
using FizzBuzz_Web.Areas.Identity.Data;
using FizzBuzz_Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FizzBuzz_Web.Areas.Identity.IdentityHostingStartup))]
namespace FizzBuzz_Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FizzBuzzDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FizzBuzzDBContextConnection")));

                services.AddDefaultIdentity<FizzBuzz_User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FizzBuzzDBContext>();
            });
        }
    }
}