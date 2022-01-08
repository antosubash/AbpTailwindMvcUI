using System;
using System.Collections.Generic;
using System.Text;
using AbpTailwindMvc.Localization;
using Volo.Abp.Application.Services;

namespace AbpTailwindMvc
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpTailwindMvcAppService : ApplicationService
    {
        protected AbpTailwindMvcAppService()
        {
            LocalizationResource = typeof(AbpTailwindMvcResource);
        }
    }
}
