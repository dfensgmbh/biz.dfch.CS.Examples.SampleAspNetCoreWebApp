using biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Data
{
    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        public MusicContext() : base() { }
        public MusicContext(DbContextOptions opts) : base(opts) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Album>().HasMany(a => a.Songs).WithOne(s => s.Album); // One-To-Many
            builder.Entity<Album>().HasData(new Album
            {
                Id = 1,
                Name = "The Court of the Crimson King"
            });

            builder.Entity<Song>().HasData(
                new { Id = 1, AlbumId = 1, Name = "21st Century Schzoid Man" },
                new { Id = 2, AlbumId = 1, Name = "I Talk to the Wind" }
            );
        }
    }
}
