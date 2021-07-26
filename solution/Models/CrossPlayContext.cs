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
            },
            new Game 
            {
              GameId = 2,
              GameName = "Hunter's Arena: Legends",
              Link = "https://store.steampowered.com/news/app/1061100/view/2997690640726279509",
            },
            new Game 
            {
              GameId = 3,
              GameName = "Godfall",
              Link = "https://www.godfall.com/",
            },
            new Game 
            {
              GameId = 4,
              GameName = "Blightbound",
              Link = "https://store.steampowered.com/news/app/1263070/view/2971794942848931181",
            },
            new Game 
            {
              GameId = 5,
              GameName = "Dungeons & Dragons: Dark Alliance",
              Link = "https://www.darkalliance.com/",
            },
            new Game 
            {
              GameId = 6,
              GameName = "Overwatch",
              Link = "http://battle.net/overwatch/",
            },
            new Game 
            {
              GameId = 7,
              GameName = "Trailmakers",
              Link = "http://www.playtrailmakers.com/",
            },
            new Game 
            {
              GameId = 8,
              GameName = "Football Manager 2021: Xbox Edition",
              Link = "https://www.footballmanager.com/games/football-manager-2021-xbox",
            },
            new Game 
            {
              GameId = 9,
              GameName = "Bleeding Edge",
              Link = "https://www.bleedingedge.com/",
            },
            new Game 
            {
              GameId = 10,
              GameName = "Destiny 2",
              Link = "https://www.destinythegame.com/",
            },
            new Game 
            {
              GameId = 11,
              GameName = "Rust: Console Edition",
              Link = "https://gamingbolt.com/rust-console-edition-7-things-you-need-to-know",
            },
            new Game 
            {
              GameId = 12,
              GameName = "Human: Fall Flat",
              Link = "http://www.nobrakesgames.com/human/",
            },
            new Game 
            {
              GameId = 13,
              GameName = "Enlisted",
              Link = "https://enlisted.net/",
            },
            new Game 
            {
              GameId = 14,
              GameName = "Chivalry 2",
              Link = "https://www.chivalry2.com/",
            },
            new Game 
            {
              GameId = 15,
              GameName = "Predator: Hunting Grounds",
              Link = "https://www.gamerevolution.com/guides/644342-predator-hunting-grounds-crossplay-invites",
            }
          );

          builder.Entity<Category>().HasData(
            new Category
            {
              CategoryId = 1,
              CategoryName = "Action"
            },
            new Category
            {
              CategoryId = 2,
              CategoryName = "RPG"
            },
            new Category
            {
              CategoryId = 3,
              CategoryName = "Indie"
            },
            new Category
            {
              CategoryId = 4,
              CategoryName = "Strategy"
            },
            new Category
            {
              CategoryId = 5,
              CategoryName = "Sports"
            },
            new Category
            {
              CategoryId = 6,
              CategoryName = "Arcade"
            },
            new Category
            {
              CategoryId = 7,
              CategoryName = "Card & Board Game"
            },
            new Category
            {
              CategoryId = 8,
              CategoryName = "Racing"
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
              ConsoleName = "Playstation 4",
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

          builder.Entity<GameCategory>().HasData(
            new GameCategory
            {
              GameCategoryId = 1,
              GameId = 1,
              CategoryId = 4
            },
            new GameCategory
            {
              GameCategoryId = 2,
              GameId = 2,
              CategoryId = 2
            },
            new GameCategory
            {
              GameCategoryId = 3,
              GameId = 3,
              CategoryId = 2
            },
            new GameCategory
            {
              GameCategoryId = 4,
              GameId = 4,
              CategoryId = 2
            },
            new GameCategory
            {
              GameCategoryId = 5,
              GameId = 5,
              CategoryId = 2
            },
            new GameCategory
            {
              GameCategoryId = 6,
              GameId = 6,
              CategoryId = 1
            },
            new GameCategory
            {
              GameCategoryId = 7,
              GameId = 7,
              CategoryId = 8
            },
            new GameCategory
            {
              GameCategoryId = 8,
              GameId = 8,
              CategoryId = 5
            },
            new GameCategory
            {
              GameCategoryId = 9,
              GameId = 9,
              CategoryId = 1
            },
            new GameCategory
            {
              GameCategoryId = 10,
              GameId = 10,
              CategoryId = 1
            },
            new GameCategory
            {
              GameCategoryId = 11,
              GameId = 11,
              CategoryId = 3
            },
            new GameCategory
            {
              GameCategoryId = 12,
              GameId = 12,
              CategoryId = 3
            },
            new GameCategory
            {
              GameCategoryId = 13,
              GameId = 13,
              CategoryId = 1
            },
            new GameCategory
            {
              GameCategoryId = 14,
              GameId = 14,
              CategoryId = 1
            },
            new GameCategory
            {
              GameCategoryId = 15,
              GameId = 15,
              CategoryId = 1
            }          
          );

          builder.Entity<GameConsole>().HasData(
            new GameConsole
            {
              GameConsoleId = 1,
              GameId = 1,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 2,
              GameId = 1,
              ConsoleId = 2
            },
            new GameConsole
            {
              GameConsoleId = 3,
              GameId = 1,
              ConsoleId = 11
            },
            new GameConsole
            {
              GameConsoleId = 4,
              GameId = 1,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 5,
              GameId = 1,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 6,
              GameId = 2,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 7,
              GameId = 2,
              ConsoleId = 2
            },
            new GameConsole
            {
              GameConsoleId = 8,
              GameId = 2,
              ConsoleId = 11
            },
            new GameConsole
            {
              GameConsoleId = 9,
              GameId = 3,
              ConsoleId = 2
            },
            new GameConsole
            {
              GameConsoleId = 10,
              GameId = 3,
              ConsoleId = 11
            },
            new GameConsole
            {
              GameConsoleId = 11,
              GameId = 4,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 12,
              GameId = 4,
              ConsoleId = 2
            },
            new GameConsole
            {
              GameConsoleId = 13,
              GameId = 4,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 14,
              GameId = 5,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 15,
              GameId = 5,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 16,
              GameId = 5,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 17,
              GameId = 6,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 18,
              GameId = 6,
              ConsoleId = 2
            },
            new GameConsole
            {
              GameConsoleId = 19,
              GameId = 6,
              ConsoleId = 11
            },
            new GameConsole
            {
              GameConsoleId = 20,
              GameId = 6,
              ConsoleId = 5
            },
            new GameConsole
            {
              GameConsoleId = 21,
              GameId = 6,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 22,
              GameId = 6,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 23,
              GameId = 7,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 24,
              GameId = 7,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 25,
              GameId = 7,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 26,
              GameId = 8,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 27,
              GameId = 8,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 28,
              GameId = 8,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 29,
              GameId = 9,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 30,
              GameId = 9,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 31,
              GameId = 10,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 32,
              GameId = 10,
              ConsoleId = 2
            },
            new GameConsole
            {
              GameConsoleId = 33,
              GameId = 10,
              ConsoleId = 11
            },
            new GameConsole
            {
              GameConsoleId = 34,
              GameId = 10,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 35,
              GameId = 10,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 36,
              GameId = 11,
              ConsoleId = 2
            },
            new GameConsole
            {
              GameConsoleId = 37,
              GameId = 11,
              ConsoleId = 11
            },
            new GameConsole
            {
              GameConsoleId = 38,
              GameId = 11,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 39,
              GameId = 11,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 40,
              GameId = 12,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 41,
              GameId = 12,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 42,
              GameId = 12,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 43,
              GameId = 13,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 44,
              GameId = 13,
              ConsoleId = 11
            },
            new GameConsole
            {
              GameConsoleId = 45,
              GameId = 13,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 46,
              GameId = 14,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 47,
              GameId = 14,
              ConsoleId = 2
            },
            new GameConsole
            {
              GameConsoleId = 48,
              GameId = 14,
              ConsoleId = 11
            },
            new GameConsole
            {
              GameConsoleId = 49,
              GameId = 14,
              ConsoleId = 3
            },
            new GameConsole
            {
              GameConsoleId = 50,
              GameId = 14,
              ConsoleId = 10
            },
            new GameConsole
            {
              GameConsoleId = 51,
              GameId = 15,
              ConsoleId = 1
            },
            new GameConsole
            {
              GameConsoleId = 52,
              GameId = 15,
              ConsoleId = 2
            }
          );
        }
    }
}