using AbpTailwindMvc.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpTailwindMvc.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpTailwindMvcEntityFrameworkCoreModule),
        typeof(AbpTailwindMvcApplicationContractsModule)
        )]
    public class AbpTailwindMvcDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
