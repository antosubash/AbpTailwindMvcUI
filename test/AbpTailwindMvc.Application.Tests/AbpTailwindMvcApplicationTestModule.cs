using Volo.Abp.Modularity;

namespace AbpTailwindMvc
{
    [DependsOn(
        typeof(AbpTailwindMvcApplicationModule),
        typeof(AbpTailwindMvcDomainTestModule)
        )]
    public class AbpTailwindMvcApplicationTestModule : AbpModule
    {

    }
}