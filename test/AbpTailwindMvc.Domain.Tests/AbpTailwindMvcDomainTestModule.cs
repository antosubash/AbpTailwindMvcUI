using AbpTailwindMvc.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpTailwindMvc
{
    [DependsOn(
        typeof(AbpTailwindMvcEntityFrameworkCoreTestModule)
        )]
    public class AbpTailwindMvcDomainTestModule : AbpModule
    {

    }
}