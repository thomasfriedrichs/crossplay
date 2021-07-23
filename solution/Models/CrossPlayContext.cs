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
            new Game 
            {
              GameId = 1,
              GameName = "Operation: Tango",
              Link = "http://www.operation-tango.com/",
            }
          );

          builder.Entity<Category>().HasData(
            new Category
            {

            }
          );

          builder.Entity<Console>().HasData(
            new Console 
            {
              ConsoleName = "Windows",
              ConsoleId = 1
            },
            new Console 
            {
              ConsoleName = "Playstation 2",
              ConsoleId = 2
            },
            new Console 
            {
              ConsoleName = "Xbox One",
              ConsoleId = 3
            },
            new Console 
            {
              ConsoleName = "Mac",
              ConsoleId = 4
            },
            new Console 
            {
              ConsoleName = "Playstation 2",
              ConsoleId = 5
            },
            new Console 
            {
              ConsoleName = "Switch",
              ConsoleId = 5
            },
            new Console 
            {
              ConsoleName = "Playstation Vita 6",
              ConsoleId = 6
            },
            new Console 
            {
              ConsoleName = "Playstation 3",
              ConsoleId = 7
            },
            new Console 
            {
              ConsoleName = "iOS",
              ConsoleId = 8
            },
            new Console 
            {
              ConsoleName = "Android",
              ConsoleId = 9
            },
            new Console 
            {
              ConsoleName = "Xbox Series X/S",
              ConsoleId = 10
            },
            new Console 
            {
              ConsoleName = "Playstation 5",
              ConsoleId = 11
            },
            new Console 
            {
              ConsoleName = "Linux",
              ConsoleId = 12
            },
            new Console 
            {
              ConsoleName = "Wii",
              ConsoleId = 13
            }
          );
        }
    }
}