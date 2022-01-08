using Volo.Abp.Settings;

namespace AbpTailwindMvc.Settings
{
    public class AbpTailwindMvcSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpTailwindMvcSettings.MySetting1));
        }
    }
}
