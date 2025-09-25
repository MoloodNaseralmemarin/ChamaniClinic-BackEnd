using ChamaniClinic.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MadWin.Infrastructure.Context
{
    public class ChamaniClinicDBContextFactory : IDesignTimeDbContextFactory<ChamaniClinicDBContext>
    {
        public ChamaniClinicDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // ← محل EF CLI
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ChamaniClinicDBContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Development"));

            return new ChamaniClinicDBContext(optionsBuilder.Options);
        }
    }
}
