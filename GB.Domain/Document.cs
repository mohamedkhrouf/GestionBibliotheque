using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Document
    {
       
        public int Id_Document { get; set; }
        public string Titre { get; set; }
        [DataType(DataType.MultilineText)]
        public string Resume { get; set; }
        public int BibliothequeFK { get; set; }

        public Bibliotheque Bibliotheque { get; set; }
        public virtual ICollection<Emprunt> Emprunts { get; set; }
        public override string ToString()
        {
            return "id" + Id_Document +"titre"+ Titre +"resume" + Resume ;
        }
    }
}
