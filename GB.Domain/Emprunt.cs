using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace GB.Domain
{
    [Table("Emprunt")]
    public class Emprunt
    {

        [ForeignKey("Adherent")]
        [Column(Order = 2)]
        [Key]

        public int AdherentFK { get; set; }
        [ForeignKey("Document")]
        [Column(Order = 3)]
        [Key]
        public int DocumentFK { get; set; }
        public Adherent Adherent { get; set; }
            public Document Document { get; set; }
        [Column(Order =1)]
        [Key]
        [DataType(DataType.Date)]
        public DateTime DateEmprunt { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateRetour { get; set; }
        public int DureeEmprunt { get; set; }
        public Emprunt(Adherent a, Document d , DateTime de  )
        {
            AdherentFK = a.Id_Adherent;
            DocumentFK = d.Id_Document;
            Document = d;
            Adherent = a;

            DateEmprunt = de;
            DureeEmprunt = 0;
            DateRetour = null;
        }
        public Emprunt() { }
    }
    }

