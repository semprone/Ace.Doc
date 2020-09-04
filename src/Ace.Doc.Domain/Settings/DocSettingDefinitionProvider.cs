using Volo.Abp.Settings;

namespace Ace.Doc.Settings
{
    public class DocSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DocSettings.MySetting1));
        }
    }
}
