using AbpTailwindMvc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpTailwindMvc.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpTailwindMvcController : AbpControllerBase
    {
        protected AbpTailwindMvcController()
        {
            LocalizationResource = typeof(AbpTailwindMvcResource);
        }
    }
}