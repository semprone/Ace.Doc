using System;
using System.Collections.Generic;
using System.Text;
using Ace.Doc.Localization;
using Volo.Abp.Application.Services;

namespace Ace.Doc
{
    /* Inherit your application services from this class.
     */
    public abstract class DocAppService : ApplicationService
    {
        protected DocAppService()
        {
            LocalizationResource = typeof(DocResource);
        }
    }
}
