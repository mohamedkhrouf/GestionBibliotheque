using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Adherent
    {[Required(ErrorMessage ="le nom est obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "le prenom est obligatoire")]
        public string Prenom { get; set; }
        [Key]
        public int Id_Adherent { get; set; }
        [Required(ErrorMessage = "le prenom est obligatoire")]
        public string Login { get; set; }
        [Required(ErrorMessage = "le prenom est obligatoire")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public virtual ICollection<Emprunt> Emprunts { get; set; }
        public Bibliotheque Bibliotheque;
       
        public override string ToString()
        {
            return "nom" + Nom + "prenom" + Prenom + "id" + Id_Adherent + "login" + Login;
        }
        public Adherent()
        {
            Emprunts = new List<Emprunt>();
        }
    }
}
