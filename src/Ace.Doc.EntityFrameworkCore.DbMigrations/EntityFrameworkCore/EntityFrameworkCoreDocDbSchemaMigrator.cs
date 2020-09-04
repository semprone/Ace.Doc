using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ace.Doc.Data;
using Volo.Abp.DependencyInjection;

namespace Ace.Doc.EntityFrameworkCore
{
    public class EntityFrameworkCoreDocDbSchemaMigrator
        : IDocDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDocDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DocMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DocMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}