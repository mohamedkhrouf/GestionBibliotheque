using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class BD : Volume
    {
        public string Dessinateur { get; set; }
        public override string ToString()
        {
            return  base.ToString() + "nom" + Dessinateur;
        }
    }
}
