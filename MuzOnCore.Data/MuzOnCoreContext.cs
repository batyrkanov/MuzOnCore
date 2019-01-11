using Microsoft.EntityFrameworkCore;
using MuzOnCore.Data.Configurations;
using MuzOnCore.Data.Entities;

namespace MuzOnCore.Data
{
    public class MuzOnCoreContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Image> Images { get; set; }

        public MuzOnCoreContext(DbContextOptions<MuzOnCoreContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ArtistConfig());
            builder.ApplyConfiguration(new ImageConfig());
            builder.ApplyConfiguration(new BandConfig());
            builder.ApplyConfiguration(new SongConfig());
        }
    }
}
