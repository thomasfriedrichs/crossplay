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
              Name = "Windows",
              ConsoleId = 1
            },
            new Console {
              Name = "Playstation 2",
              ConsoleId = 2
            },
            new Console {
              Name = "Xbox One",
              ConsoleId = 3
            },
            new Console {
              Name = "Mac",
              ConsoleId = 4
            },
            new Console {
              Name = "Playstation 2",
              ConsoleId = 5
            },
            new Console {
              Name = "Switch",
              ConsoleId = 5
            },
            new Console {
              Name = "Playstation Vita 6",
              ConsoleId = 6
            },
            new Console {
              Name = "Playstation 3",
              ConsoleId = 7
            },
            new Console {
              Name = "iOS",
              ConsoleId = 8
            },
            new Console {
              Name = "Android",
              ConsoleId = 9
            },
            new Console {
              Name = "Xbox Series X/S",
              ConsoleId = 10
            },
            new Console {
              Name = "Playstation 5",
              ConsoleId = 11
            },
            new Console {
              Name = "Linux",
              ConsoleId = 12
            },
            new Console {
              Name = "Wii",
              ConsoleId = 13
            }
          );
        }
    }
}