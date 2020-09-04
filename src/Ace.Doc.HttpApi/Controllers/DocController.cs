using Ace.Doc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Ace.Doc.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DocController : AbpController
    {
        protected DocController()
        {
            LocalizationResource = typeof(DocResource);
        }
    }
}