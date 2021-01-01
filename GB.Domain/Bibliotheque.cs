using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Bibliotheque
    {
      
        public int Id_Bibliotheque { get; set; }
        public  virtual ICollection<Adherent> Atherents { get; set; }
        public virtual ICollection<Document>  Documents { get; set; }
     public string g{ get; set; }
        public override string ToString()
        {
            return "id" + Id_Bibliotheque;
        }
    }
}
