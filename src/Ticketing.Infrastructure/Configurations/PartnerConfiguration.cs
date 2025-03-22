using Ticketing.Domain.Partner;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ticketing.Infrastructure.Configurations;

internal class PartnerConfiguration: IEntityTypeConfiguration<Partner>
{
    public void Configure(EntityTypeBuilder<Partner> builder)
    {
        builder.HasKey(partner => partner.Id);
        builder.Property(partner => partner.Name)
            .IsRequired()
            .HasMaxLength(255);
        builder.Property(category => category.CreatedAt);
        builder.Property(category => category.UpdatedAt);
    }
}