using Microsoft.EntityFrameworkCore;
using RythmSectionCDStore.Models;

namespace RythmSectionCDStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Pulling keys from the artist and album table to establish the Artist_Album table.
            modelBuilder.Entity<Artist_Album>().HasKey(am => new
            {
                am.ArtistId,
                am.AlbumId
            });

            //Establish relationships between ArtistId and AlbumId for the new Artist_Albums table
            modelBuilder.Entity<Artist_Album>().HasOne(m => m.Album).WithMany(am => am.Artists_Albums).HasForeignKey(m =>
                m.AlbumId);

            modelBuilder.Entity<Artist_Album>().HasOne(m => m.Artist_Band).WithMany(am => am.Artists_Albums).HasForeignKey(m =>
                m.ArtistId);



            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Artist_Band> Artists { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist_Album> Artists_Albums { get; set; }

        public DbSet<Stage> Stages { get; set; }

        public DbSet<RecordLabel> RecordLabels { get; set; }
    }
}
