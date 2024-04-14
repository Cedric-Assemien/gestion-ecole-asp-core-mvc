using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GRP7_GestionEcole.Models.ENTITIES;
using GRP7_GestionEcole.Models;

namespace GRP7_GestionEcole.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GRP7_GestionEcole.Models.ENTITIES.Absence> Absence { get; set; } = default!;
        public DbSet<GRP7_GestionEcole.Models.ENTITIES.Cahierdetexte> Cahierdetexte { get; set; } = default!;
        public DbSet<GRP7_GestionEcole.Models.ENTITIES.Classe> Classe { get; set; } = default!;
        public DbSet<GRP7_GestionEcole.Models.ENTITIES.Cours> Cours { get; set; } = default!;
        public DbSet<GRP7_GestionEcole.Models.ENTITIES.Etudiant> Etudiant { get; set; } = default!;
        public DbSet<GRP7_GestionEcole.Models.Professeur> Professeur { get; set; } = default!;
    }
}
