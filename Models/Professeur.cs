using System.ComponentModel.DataAnnotations;
using GRP7_GestionEcole.Models.ENTITIES;

namespace GRP7_GestionEcole.Models
{
    public class Professeur
    {
        [Key]
        public int IDProfesseur { get; set; }
        public required string NomProf { get; set; }
        public required string PrenomProf { get; set; }

        public required string Email { get; set; }


    
    }
}
