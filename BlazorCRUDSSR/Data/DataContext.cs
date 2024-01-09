using BlazorCRUDSSR.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDSSR.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { Id = 1, Title = "Cyberpunk2077", Publisher = "CD Projekt", ReleaseYear = 2020 },
                new VideoGame { Id = 2, Title = "Destiny 2", Publisher = "Bungie", ReleaseYear = 2017 },
                new VideoGame { Id = 3, Title = "Destiny", Publisher = "Bungie", ReleaseYear = 2014 }
                );
        }
        public DbSet<VideoGame> VideoGames { get; set; }
    }
}
