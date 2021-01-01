using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Volume : Document
    {
        public string Auteur { get; set; }
        public override string ToString()
        {
            return base.ToString() + "auteur" + Auteur;
        }
    }
}
