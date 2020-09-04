using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Ace.Doc.EntityFrameworkCore
{
    public static class DocDbContextModelCreatingExtensions
    {
        public static void ConfigureDoc(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DocConsts.DbTablePrefix + "YourEntities", DocConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}