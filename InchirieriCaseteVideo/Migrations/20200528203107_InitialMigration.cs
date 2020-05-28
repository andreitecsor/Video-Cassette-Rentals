using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InchirieriCaseteVideo.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    IdClient = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    DataNastere = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Inchierieri",
                columns: table => new
                {
                    CodTranzactie = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idClient = table.Column<int>(nullable: false),
                    dataTranzactie = table.Column<DateTime>(nullable: false),
                    sfarsitPerioada = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inchierieri", x => x.CodTranzactie);
                });

            migrationBuilder.CreateTable(
                name: "FilmInchiriat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titlu = table.Column<string>(nullable: true),
                    InchiriereCodTranzactie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmInchiriat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmInchiriat_Inchierieri_InchiriereCodTranzactie",
                        column: x => x.InchiriereCodTranzactie,
                        principalTable: "Inchierieri",
                        principalColumn: "CodTranzactie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmInchiriat_InchiriereCodTranzactie",
                table: "FilmInchiriat",
                column: "InchiriereCodTranzactie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropTable(
                name: "FilmInchiriat");

            migrationBuilder.DropTable(
                name: "Inchierieri");
        }
    }
}
