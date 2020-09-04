using Ace.Doc.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Ace.Doc
{
    [DependsOn(
        typeof(DocEntityFrameworkCoreTestModule)
        )]
    public class DocDomainTestModule : AbpModule
    {

    }
}