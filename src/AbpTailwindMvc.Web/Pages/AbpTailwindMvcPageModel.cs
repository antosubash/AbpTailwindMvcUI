using AbpTailwindMvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpTailwindMvc.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpTailwindMvcPageModel : AbpPageModel
    {
        protected AbpTailwindMvcPageModel()
        {
            LocalizationResourceType = typeof(AbpTailwindMvcResource);
        }
    }
}