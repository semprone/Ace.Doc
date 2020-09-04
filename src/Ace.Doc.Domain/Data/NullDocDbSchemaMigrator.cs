using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Ace.Doc.Data
{
    /* This is used if database provider does't define
     * IDocDbSchemaMigrator implementation.
     */
    public class NullDocDbSchemaMigrator : IDocDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}