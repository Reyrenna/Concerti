using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Concerti.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artistis",
                columns: table => new
                {
                    IdArtista = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistis", x => x.IdArtista);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    IdEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Luogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdArtista = table.Column<int>(type: "int", nullable: false),
                    ArtistiIdArtista = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.IdEvento);
                    table.ForeignKey(
                        name: "FK_Eventos_Artistis_ArtistiIdArtista",
                        column: x => x.ArtistiIdArtista,
                        principalTable: "Artistis",
                        principalColumn: "IdArtista");
                });

            migrationBuilder.CreateTable(
                name: "Bigliettos",
                columns: table => new
                {
                    IdBiglietto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEvento = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    DataAcquisto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventoIdEvento = table.Column<int>(type: "int", nullable: true),
                    UserIdUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bigliettos", x => x.IdBiglietto);
                    table.ForeignKey(
                        name: "FK_Bigliettos_Eventos_EventoIdEvento",
                        column: x => x.EventoIdEvento,
                        principalTable: "Eventos",
                        principalColumn: "IdEvento");
                    table.ForeignKey(
                        name: "FK_Bigliettos_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bigliettos_EventoIdEvento",
                table: "Bigliettos",
                column: "EventoIdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Bigliettos_UserIdUser",
                table: "Bigliettos",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_ArtistiIdArtista",
                table: "Eventos",
                column: "ArtistiIdArtista");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bigliettos");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Artistis");
        }
    }
}
