using Ace.Doc.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Ace.Doc.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DocEntityFrameworkCoreDbMigrationsModule),
        typeof(DocApplicationContractsModule)
        )]
    public class DocDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
