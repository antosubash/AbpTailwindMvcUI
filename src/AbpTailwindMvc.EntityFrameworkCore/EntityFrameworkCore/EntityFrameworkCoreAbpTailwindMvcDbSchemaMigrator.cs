using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpTailwindMvc.Data;
using Volo.Abp.DependencyInjection;

namespace AbpTailwindMvc.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpTailwindMvcDbSchemaMigrator
        : IAbpTailwindMvcDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpTailwindMvcDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpTailwindMvcDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpTailwindMvcDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
