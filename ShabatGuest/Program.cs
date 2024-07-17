using Microsoft.Extensions.Configuration;
using ShabatGuest.DAL;
using ShabatGuest.DAL.Model;
using ShabatGuest.DAL.Rpository;
using ShabatGuest.Services;

namespace ShabatGuest
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();
            string? conn = config["ConnectionString"];
            string? dbName = config["DefaultDB"];

            DBContext dbContext = new DBContext(conn);
            new SeedService(dbContext, dbName).EnsureTablesAndSeedData();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            new FormHandler(dbContext);
            Application.Run();
        }
    }
}