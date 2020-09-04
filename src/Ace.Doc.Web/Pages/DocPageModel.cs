using Ace.Doc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Ace.Doc.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DocPageModel : AbpPageModel
    {
        protected DocPageModel()
        {
            LocalizationResourceType = typeof(DocResource);
        }
    }
}