using System.Threading.Tasks;

namespace AbpTailwindMvc.Data
{
    public interface IAbpTailwindMvcDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
