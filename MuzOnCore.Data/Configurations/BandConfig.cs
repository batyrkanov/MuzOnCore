using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuzOnCore.Data.Entities;

namespace MuzOnCore.Data.Configurations
{
    public class BandConfig : IEntityTypeConfiguration<Band>
    {
        public void Configure(EntityTypeBuilder<Band> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Name);
            builder.Property(e => e.Name)
                .IsRequired();
        }
    }
}
