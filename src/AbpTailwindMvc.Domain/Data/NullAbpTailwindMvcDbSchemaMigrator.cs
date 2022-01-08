using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpTailwindMvc.Data
{
    /* This is used if database provider does't define
     * IAbpTailwindMvcDbSchemaMigrator implementation.
     */
    public class NullAbpTailwindMvcDbSchemaMigrator : IAbpTailwindMvcDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}