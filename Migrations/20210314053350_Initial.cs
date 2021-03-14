using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicGamesDataTransfer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GameID = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true),
                    SportID = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "winter", "Winter" },
                    { "summer", "Summer" },
                    { "paralympics", "Paralympics" },
                    { "youth", "Youth" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "Name" },
                values: new object[,]
                {
                    { "curling", "Curling" },
                    { "bobsleigh", "Bobsleigh" },
                    { "diving", "Diving" },
                    { "road cycling", "Road Cycling" },
                    { "archery", "Archery" },
                    { "canoe sprint", "Canoe Sprint" },
                    { "breakdancing", "Breakdancing" },
                    { "skateboarding", "Skateboarding" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "GameID", "LogoImage", "Name", "SportID" },
                values: new object[,]
                {
                    { "ca", "indoor", "winter", "ca.png", "Canada", "curling" },
                    { "fi", "outdoor", "youth", "fi.png", "Finland", "skateboarding" },
                    { "ru", "indoor", "youth", "ru.png", "Russia", "breakdancing" },
                    { "fr", "indoor", "youth", "fr.png", "France", "breakdancing" },
                    { "cy", "indoor", "youth", "cy.png", "Cyprus", "breakdancing" },
                    { "zw", "outdoor", "paralympics", "zw.png", "Zimbabwe", "canoe sprint" },
                    { "pk", "outdoor", "paralympics", "pk.png", "Pakistan", "canoe sprint" },
                    { "at", "outdoor", "paralympics", "at.png", "Austria", "canoe sprint" },
                    { "uy", "indoor", "paralympics", "uy.png", "Uruguay", "archery" },
                    { "ua", "indoor", "paralympics", "ua.png", "Ukraine", "archery" },
                    { "th", "indoor", "paralympics", "th.png", "Thailand", "archery" },
                    { "us", "outdoor", "summer", "us.png", "USA", "road cycling" },
                    { "nl", "outdoor", "summer", "nl.png", "Netherlands", "road cycling" },
                    { "br", "outdoor", "summer", "br.png", "Brazil", "road cycling" },
                    { "mx", "indoor", "summer", "mx.png", "Mexico", "diving" },
                    { "de", "indoor", "summer", "de.png", "Germany", "diving" },
                    { "cn", "indoor", "summer", "cn.png", "China", "diving" },
                    { "jp", "outdoor", "winter", "jp.png", "Japan", "bobsleigh" },
                    { "jm", "outdoor", "winter", "jm.png", "Jamaica", "bobsleigh" },
                    { "it", "outdoor", "winter", "it.png", "Italy", "bobsleigh" },
                    { "se", "indoor", "winter", "se.png", "Sweden", "curling" },
                    { "gb", "indoor", "winter", "gb.png", "Great Britain", "curling" },
                    { "pt", "outdoor", "youth", "pt.png", "Portugal", "skateboarding" },
                    { "sk", "outdoor", "youth", "sk.png", "Slovakia", "skateboarding" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryID",
                table: "Countries",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportID",
                table: "Countries",
                column: "SportID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
