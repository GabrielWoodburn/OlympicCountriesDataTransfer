using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicGamesDataTransfer.Migrations
{
    public partial class initial : Migration
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
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GameID = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true),
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
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "GameID", "LogoImage", "Name" },
                values: new object[,]
                {
                    { "ca", "indoor", "winter", "ca.png", "Canada" },
                    { "pt", "outdoor", "youth", "pt.png", "Portugal" },
                    { "fr", "indoor", "youth", "fr.png", "France" },
                    { "fi", "outdoor", "youth", "fi.png", "Finland" },
                    { "cy", "indoor", "youth", "cy.png", "Cyprus" },
                    { "zw", "outdoor", "paralympics", "zw.png", "Zimbabwe" },
                    { "uy", "indoor", "paralympics", "uy.png", "Uruguay" },
                    { "ua", "indoor", "paralympics", "ua.png", "Ukraine" },
                    { "th", "indoor", "paralympics", "th.png", "Thailand" },
                    { "pk", "outdoor", "paralympics", "pk.png", "Pakistan" },
                    { "at", "outdoor", "paralympics", "at.png", "Austria" },
                    { "us", "outdoor", "summer", "us.png", "USA" },
                    { "nl", "outdoor", "summer", "nl.png", "Netherlands" },
                    { "mx", "indoor", "summer", "mx.png", "Mexico" },
                    { "de", "indoor", "summer", "de.png", "Germany" },
                    { "cn", "indoor", "summer", "cn.png", "China" },
                    { "br", "outdoor", "summer", "br.png", "Brazil" },
                    { "se", "indoor", "winter", "se.png", "Sweden" },
                    { "jp", "outdoor", "winter", "jp.png", "Japan" },
                    { "jm", "outdoor", "winter", "jm.png", "Jamaica" },
                    { "it", "outdoor", "winter", "it.png", "Italy" },
                    { "gb", "indoor", "winter", "gb.png", "Great Britain" },
                    { "ru", "indoor", "youth", "ru.png", "Russia" },
                    { "sk", "outdoor", "youth", "sk.png", "Slovakia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryID",
                table: "Countries",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
