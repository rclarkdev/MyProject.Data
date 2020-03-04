using System.IO;
using MyProject.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LendmarkLoader.Data.Context
{
    public class MigrationMyProjectDbContextFactory : IDesignTimeDbContextFactory<MyProjectDbContext>
    {
        public MyProjectDbContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<MyProjectDbContext>();

           // var connectionString = configuration.GetConnectionString("DefaultConnection");

           // If using Posgres
           // builder.UseNpgsql(connectionString);

            return new MyProjectDbContext(builder.Options);
        }
    }
}
