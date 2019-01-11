using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuzOnCore.Data.Entities;

namespace MuzOnCore.Data.Configurations
{
    public class ArtistConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.FullName);
            builder.Property(e => e.FullName)
                .IsRequired();
        }
    }
}
