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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<GameCategory> GameCategories { get; set; }
        public DbSet<GamePlatform> GamePlatforms { get; set; }
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

          builder.Entity<Platform>().HasData(
            new Platform 
            {
              PlatformName = "Windows",
              PlatformId = 1
            },
            new Platform 
            {
              PlatformName = "Playstation 4",
              PlatformId = 2
            },
            new Platform 
            {
              PlatformName = "Xbox One",
              PlatformId = 3
            },
            new Platform 
            {
              PlatformName = "Mac",
              PlatformId = 4
            },
            new Platform 
            {
              PlatformName = "Switch",
              PlatformId = 5
            },
            new Platform 
            {
              PlatformName = "Playstation Vita 6",
              PlatformId = 6
            },
            new Platform 
            {
              PlatformName = "Playstation 3",
              PlatformId = 7
            },
            new Platform 
            {
              PlatformName = "iOS",
              PlatformId = 8
            },
            new Platform 
            {
              PlatformName = "Android",
              PlatformId = 9
            },
            new Platform 
            {
              PlatformName = "Xbox Series X/S",
              PlatformId = 10
            },
            new Platform 
            {
              PlatformName = "Playstation 5",
              PlatformId = 11
            },
            new Platform 
            {
              PlatformName = "Linux",
              PlatformId = 12
            },
            new Platform 
            {
              PlatformName = "Wii",
              PlatformId = 13
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

          builder.Entity<GamePlatform>().HasData(
            new GamePlatform
            {
              GamePlatformId = 1,
              GameId = 1,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 2,
              GameId = 1,
              PlatformId = 2
            },
            new GamePlatform
            {
              GamePlatformId = 3,
              GameId = 1,
              PlatformId = 11
            },
            new GamePlatform
            {
              GamePlatformId = 4,
              GameId = 1,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 5,
              GameId = 1,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 6,
              GameId = 2,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 7,
              GameId = 2,
              PlatformId = 2
            },
            new GamePlatform
            {
              GamePlatformId = 8,
              GameId = 2,
              PlatformId = 11
            },
            new GamePlatform
            {
              GamePlatformId = 9,
              GameId = 3,
              PlatformId = 2
            },
            new GamePlatform
            {
              GamePlatformId = 10,
              GameId = 3,
              PlatformId = 11
            },
            new GamePlatform
            {
              GamePlatformId = 11,
              GameId = 4,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 12,
              GameId = 4,
              PlatformId = 2
            },
            new GamePlatform
            {
              GamePlatformId = 13,
              GameId = 4,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 14,
              GameId = 5,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 15,
              GameId = 5,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 16,
              GameId = 5,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 17,
              GameId = 6,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 18,
              GameId = 6,
              PlatformId = 2
            },
            new GamePlatform
            {
              GamePlatformId = 19,
              GameId = 6,
              PlatformId = 11
            },
            new GamePlatform
            {
              GamePlatformId = 20,
              GameId = 6,
              PlatformId = 5
            },
            new GamePlatform
            {
              GamePlatformId = 21,
              GameId = 6,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 22,
              GameId = 6,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 23,
              GameId = 7,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 24,
              GameId = 7,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 25,
              GameId = 7,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 26,
              GameId = 8,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 27,
              GameId = 8,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 28,
              GameId = 8,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 29,
              GameId = 9,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 30,
              GameId = 9,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 31,
              GameId = 10,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 32,
              GameId = 10,
              PlatformId = 2
            },
            new GamePlatform
            {
              GamePlatformId = 33,
              GameId = 10,
              PlatformId = 11
            },
            new GamePlatform
            {
              GamePlatformId = 34,
              GameId = 10,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 35,
              GameId = 10,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 36,
              GameId = 11,
              PlatformId = 2
            },
            new GamePlatform
            {
              GamePlatformId = 37,
              GameId = 11,
              PlatformId = 11
            },
            new GamePlatform
            {
              GamePlatformId = 38,
              GameId = 11,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 39,
              GameId = 11,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 40,
              GameId = 12,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 41,
              GameId = 12,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 42,
              GameId = 12,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 43,
              GameId = 13,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 44,
              GameId = 13,
              PlatformId = 11
            },
            new GamePlatform
            {
              GamePlatformId = 45,
              GameId = 13,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 46,
              GameId = 14,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 47,
              GameId = 14,
              PlatformId = 2
            },
            new GamePlatform
            {
              GamePlatformId = 48,
              GameId = 14,
              PlatformId = 11
            },
            new GamePlatform
            {
              GamePlatformId = 49,
              GameId = 14,
              PlatformId = 3
            },
            new GamePlatform
            {
              GamePlatformId = 50,
              GameId = 14,
              PlatformId = 10
            },
            new GamePlatform
            {
              GamePlatformId = 51,
              GameId = 15,
              PlatformId = 1
            },
            new GamePlatform
            {
              GamePlatformId = 52,
              GameId = 15,
              PlatformId = 2
            }
          );
        }
    }
}