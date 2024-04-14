using System.ComponentModel.DataAnnotations;

namespace GRP7_GestionEcole.Models.ENTITIES
{
    public class Etudiant
    {
        [Key]
        public int IDEtudiant { get; set; }
        public required string NomEtudiant { get; set; }
        public required string PrenomEtudiant { get; set; }
        public int Age { get; set; }
        public required string EmailEtudiant{ get; set; }


        



      
    }
}
