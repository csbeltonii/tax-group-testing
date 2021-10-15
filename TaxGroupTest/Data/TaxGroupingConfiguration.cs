using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxGroupTest.Models;

namespace TaxGroupTest.Data
{
    public class TaxGroupingConfiguration : IEntityTypeConfiguration<TaxGrouping>
    {
        public void Configure(EntityTypeBuilder<TaxGrouping> builder)
        {
            builder.HasKey(
                grouping => new
                {
                    grouping.TaxRateId,
                    grouping.TaxGroupId
                }
            );
        }
    }
}
