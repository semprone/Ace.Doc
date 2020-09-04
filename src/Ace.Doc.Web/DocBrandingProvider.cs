using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Ace.Doc.Web
{
    [Dependency(ReplaceServices = true)]
    public class DocBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Doc";
    }
}
