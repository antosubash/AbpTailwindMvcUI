using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpTailwindMvc.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpTailwindMvcBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpTailwindMvc";
    }
}
