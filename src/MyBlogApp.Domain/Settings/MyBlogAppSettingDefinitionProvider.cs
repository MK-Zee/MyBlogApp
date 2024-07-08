using Volo.Abp.Settings;

namespace MyBlogApp.Settings;

public class MyBlogAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyBlogAppSettings.MySetting1));
    }
}
