using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GRP7_GestionEcole.Data.Migrations
{
    /// <inheritdoc />
    public partial class ecole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Absence",
                columns: table => new
                {
                    AbsenceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomAbsent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAbsence = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotifAbsent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombreHeureAbsence = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absence", x => x.AbsenceID);
                });

            migrationBuilder.CreateTable(
                name: "Cahierdetexte",
                columns: table => new
                {
                    IDCahierdeTexte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomProf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomCours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeureCours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cahierdetexte", x => x.IDCahierdeTexte);
                });

            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    IDClasse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomClasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomCours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEtudiant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.IDClasse);
                });

            migrationBuilder.CreateTable(
                name: "Cours",
                columns: table => new
                {
                    IDCours = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreHeureCours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cours", x => x.IDCours);
                });

            migrationBuilder.CreateTable(
                name: "Etudiant",
                columns: table => new
                {
                    IDEtudiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEtudiant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrenomEtudiant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    EmailEtudiant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiant", x => x.IDEtudiant);
                });

            migrationBuilder.CreateTable(
                name: "Professeur",
                columns: table => new
                {
                    IDProfesseur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomProf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrenomProf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professeur", x => x.IDProfesseur);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absence");

            migrationBuilder.DropTable(
                name: "Cahierdetexte");

            migrationBuilder.DropTable(
                name: "Classe");

            migrationBuilder.DropTable(
                name: "Cours");

            migrationBuilder.DropTable(
                name: "Etudiant");

            migrationBuilder.DropTable(
                name: "Professeur");
        }
    }
}
