using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Storage.Models
{
    public class StorageContextFactory : IDesignTimeDbContextFactory<StorageContext>
    {
        StorageContext IDesignTimeDbContextFactory<StorageContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var builder = new DbContextOptionsBuilder<StorageContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new StorageContext(builder.Options);
        }
    }
}