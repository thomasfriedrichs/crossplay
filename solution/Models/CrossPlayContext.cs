using Microsoft.EntityFrameworkCore;

namespace CrossPlay.Models
{
    public class CrossPlayContext : DbContext
    {
        public CrossPlayContext(DbContextOptions<CrossPlayContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Game>()
          .HasData(
            new Game {
              GameId = 1,
              Name = "Operation: Tango",
              Category = "Strategy",
              Link = "http://www.operation-tango.com/",
              

            }
          );

          builder.Entity<Console>().HasData(
            new Console {
              
            }
          );
        }
    }
}