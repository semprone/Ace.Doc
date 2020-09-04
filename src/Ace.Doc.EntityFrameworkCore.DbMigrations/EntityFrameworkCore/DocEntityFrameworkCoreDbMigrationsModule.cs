using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Ace.Doc.EntityFrameworkCore
{
    [DependsOn(
        typeof(DocEntityFrameworkCoreModule)
        )]
    public class DocEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DocMigrationsDbContext>();
        }
    }
}
