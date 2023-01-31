using AbbyWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AbbyWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            //add db service 
            builder.Services.AddDbContext<ApplicationDbContext>(Options => Options.UseSqlServer(
                builder.Configuration.GetConnectionString("connectDatabase"))
            );
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}