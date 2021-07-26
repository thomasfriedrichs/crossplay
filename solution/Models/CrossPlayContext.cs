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
        }
    }
}