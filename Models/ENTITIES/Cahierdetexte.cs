using System.ComponentModel.DataAnnotations;

namespace GRP7_GestionEcole.Models.ENTITIES
{
    public class Cahierdetexte
    {
        [Key]
        public int IDCahierdeTexte { get; set; }
        public required string NomProf { get; set; }
        public required string NomCours { get; set; }
        public int HeureCours { get; set; }

       

       
    }
}
