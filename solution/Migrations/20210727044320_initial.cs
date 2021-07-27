using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrossPlay.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "GameCategories",
                columns: table => new
                {
                    GameCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategories", x => x.GameCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "GamePlatforms",
                columns: table => new
                {
                    GamePlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatforms", x => x.GamePlatformId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GameName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Link = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlatformName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.PlatformId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "RPG" },
                    { 3, "Indie" },
                    { 4, "Strategy" },
                    { 5, "Sports" },
                    { 6, "Arcade" },
                    { 7, "Card & Board Game" },
                    { 8, "Racing" }
                });

            migrationBuilder.InsertData(
                table: "GameCategories",
                columns: new[] { "GameCategoryId", "CategoryId", "GameId" },
                values: new object[,]
                {
                    { 3, 2, 3 },
                    { 4, 2, 4 },
                    { 6, 1, 6 },
                    { 7, 8, 7 },
                    { 8, 5, 8 },
                    { 9, 1, 9 },
                    { 13, 1, 13 },
                    { 11, 3, 11 },
                    { 12, 3, 12 },
                    { 2, 2, 2 },
                    { 14, 1, 14 },
                    { 15, 1, 15 },
                    { 10, 1, 10 },
                    { 1, 4, 1 },
                    { 5, 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "GamePlatformId", "GameId", "PlatformId" },
                values: new object[,]
                {
                    { 39, 11, 10 },
                    { 22, 6, 10 },
                    { 23, 7, 1 },
                    { 24, 7, 3 },
                    { 25, 7, 10 },
                    { 26, 8, 1 },
                    { 27, 8, 3 },
                    { 28, 8, 10 },
                    { 29, 9, 1 },
                    { 30, 9, 3 },
                    { 31, 10, 1 },
                    { 32, 10, 2 },
                    { 33, 10, 11 },
                    { 34, 10, 3 },
                    { 35, 10, 10 },
                    { 38, 11, 3 },
                    { 36, 11, 2 },
                    { 52, 15, 2 },
                    { 51, 15, 1 },
                    { 50, 14, 10 },
                    { 49, 14, 3 },
                    { 48, 14, 11 },
                    { 47, 14, 2 },
                    { 46, 14, 1 },
                    { 45, 13, 10 },
                    { 44, 13, 11 },
                    { 43, 13, 1 },
                    { 21, 6, 3 },
                    { 42, 12, 10 },
                    { 41, 12, 3 },
                    { 40, 12, 1 },
                    { 37, 11, 11 },
                    { 20, 6, 5 },
                    { 14, 5, 1 },
                    { 18, 6, 2 },
                    { 19, 6, 11 },
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 11 },
                    { 4, 1, 3 },
                    { 5, 1, 10 },
                    { 7, 2, 2 },
                    { 8, 2, 11 },
                    { 6, 2, 1 },
                    { 10, 3, 11 },
                    { 11, 4, 1 },
                    { 12, 4, 2 },
                    { 13, 4, 3 },
                    { 15, 5, 10 },
                    { 16, 5, 3 },
                    { 17, 6, 1 },
                    { 9, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "GameName", "Link" },
                values: new object[,]
                {
                    { 6, "Overwatch", "http://battle.net/overwatch/" },
                    { 1, "Operation: Tango", "http://www.operation-tango.com/" },
                    { 2, "Hunter's Arena: Legends", "https://store.steampowered.com/news/app/1061100/view/2997690640726279509" },
                    { 3, "Godfall", "https://www.godfall.com/" },
                    { 4, "Blightbound", "https://store.steampowered.com/news/app/1263070/view/2971794942848931181" },
                    { 5, "Dungeons & Dragons: Dark Alliance", "https://www.darkalliance.com/" },
                    { 7, "Trailmakers", "http://www.playtrailmakers.com/" },
                    { 11, "Rust: Console Edition", "https://gamingbolt.com/rust-console-edition-7-things-you-need-to-know" },
                    { 9, "Bleeding Edge", "https://www.bleedingedge.com/" },
                    { 10, "Destiny 2", "https://www.destinythegame.com/" },
                    { 12, "Human: Fall Flat", "http://www.nobrakesgames.com/human/" },
                    { 13, "Enlisted", "https://enlisted.net/" },
                    { 14, "Chivalry 2", "https://www.chivalry2.com/" },
                    { 15, "Predator: Hunting Grounds", "https://www.gamerevolution.com/guides/644342-predator-hunting-grounds-crossplay-invites" },
                    { 8, "Football Manager 2021: Xbox Edition", "https://www.footballmanager.com/games/football-manager-2021-xbox" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "PlatformId", "PlatformName" },
                values: new object[,]
                {
                    { 11, "Playstation 5" },
                    { 10, "Xbox Series X/S" },
                    { 9, "Android" },
                    { 8, "iOS" },
                    { 7, "Playstation 3" },
                    { 3, "Xbox One" },
                    { 5, "Switch" },
                    { 4, "Mac" },
                    { 2, "Playstation 4" },
                    { 1, "Windows" },
                    { 12, "Linux" },
                    { 6, "Playstation Vita 6" },
                    { 13, "Wii" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "GameCategories");

            migrationBuilder.DropTable(
                name: "GamePlatforms");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
