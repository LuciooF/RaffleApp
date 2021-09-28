using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using RaffleApp.Services;

namespace RaffleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new RaffleContext())
            {
                db.Database.EnsureCreated();
                var personService = new PersonService();
                personService.PopulateDatabase();
            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
