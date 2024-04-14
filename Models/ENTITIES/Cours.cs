using System.ComponentModel.DataAnnotations;

namespace GRP7_GestionEcole.Models.ENTITIES
{
    public class Cours
    {
        [Key]
        public int IDCours { get; set; }
        public required string NomCours { get; set; }
        public int NombreHeureCours { get; set; }



       


    }
}
