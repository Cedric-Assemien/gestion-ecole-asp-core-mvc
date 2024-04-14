using System.ComponentModel.DataAnnotations;

namespace GRP7_GestionEcole.Models.ENTITIES
{
    public class Absence
    {
        [Key]
        public int AbsenceID { get; set; }
        public required string NomAbsent { get; set; }
        public DateTime DateAbsence { get; set; }
        [MaxLength(50)]

        public required string MotifAbsent { get; set; }

        public int NombreHeureAbsence { get; set; }
       


       
    }
}


