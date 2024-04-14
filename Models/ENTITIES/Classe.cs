using System.ComponentModel.DataAnnotations;

namespace GRP7_GestionEcole.Models.ENTITIES
{
    public class Classe
    {
        [Key]
        public int IDClasse{ get; set; }
        public required string NomClasse { get; set; }
        public required string NomCours { get; set; }
        public int NombreEtudiant { get; set; }


    
    }
}
