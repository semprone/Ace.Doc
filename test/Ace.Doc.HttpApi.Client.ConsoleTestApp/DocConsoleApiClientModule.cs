using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Ace.Doc.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(DocHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DocConsoleApiClientModule : AbpModule
    {
        
    }
}
