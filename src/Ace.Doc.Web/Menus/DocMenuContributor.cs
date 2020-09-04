using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Ace.Doc.Localization;
using Ace.Doc.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Ace.Doc.Web.Menus
{
    public class DocMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<DocResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Doc.Home", l["Menu:Home"], "~/"));
            context.Menu.Items.Add(new ApplicationMenuItem("Doc.Docs", l["Menu:Docs"], "/Documents"));
        }

    }
}
