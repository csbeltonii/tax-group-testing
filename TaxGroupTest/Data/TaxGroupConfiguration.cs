using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxGroupTest.Models;

namespace TaxGroupTest.Data
{
    public class TaxGroupConfiguration : IEntityTypeConfiguration<TaxGroup>
    {
        public void Configure(EntityTypeBuilder<TaxGroup> builder)
        {
            builder.HasKey(group => group.TaxGroupId);

            builder.HasMany(group => group.Rates);
        }
    }
}
