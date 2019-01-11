using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuzOnCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuzOnCore.Data.Configurations
{
    public class SongConfig : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Name);
            builder.Property(e => e.Name)
                .IsRequired();
        }
    }
}
