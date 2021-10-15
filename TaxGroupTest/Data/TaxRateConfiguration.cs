using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxGroupTest.Models;

namespace TaxGroupTest.Data
{
    public class TaxRateConfiguration : IEntityTypeConfiguration<TaxRate>
    {
        public void Configure(EntityTypeBuilder<TaxRate> builder)
        {
            builder.HasKey(tax => tax.TaxRateId);

            builder.HasMany(tax => tax.Groups);
        }
    }
}
