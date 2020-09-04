using System.Threading.Tasks;

namespace Ace.Doc.Data
{
    public interface IDocDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
