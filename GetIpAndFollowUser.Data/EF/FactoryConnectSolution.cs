using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GetIpAndFollowUser.Data.EF
{
    public class FactoryConnectSolution : IDesignTimeDbContextFactory<ConnectDatabaseContext>
    {
        public ConnectDatabaseContext CreateDbContext(string[] args)
        {
            // EF Core uses this method at design time to access the DbContext
           IConfigurationRoot configuration = new ConfigurationBuilder()
                                               .SetBasePath(Directory.GetCurrentDirectory())
                                               .AddJsonFile("appsettings.json")
                                               .Build();

            var connectionString = configuration.GetConnectionString("ConnectDatabaseContextString");
            var optionsBuilder = new DbContextOptionsBuilder<ConnectDatabaseContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ConnectDatabaseContext(optionsBuilder.Options);
        }
    }
}
