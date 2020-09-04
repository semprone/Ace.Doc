using Volo.Abp.Modularity;

namespace Ace.Doc
{
    [DependsOn(
        typeof(DocApplicationModule),
        typeof(DocDomainTestModule)
        )]
    public class DocApplicationTestModule : AbpModule
    {

    }
}