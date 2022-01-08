using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpTailwindMvc.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AbpTailwindMvcDbContextFactory : IDesignTimeDbContextFactory<AbpTailwindMvcDbContext>
    {
        public AbpTailwindMvcDbContext CreateDbContext(string[] args)
        {
            AbpTailwindMvcEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpTailwindMvcDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AbpTailwindMvcDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpTailwindMvc.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
