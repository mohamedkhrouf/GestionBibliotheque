using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Livre : Volume
    {
        public int NbPages { get; set; }
        public override string ToString()
        {
            return base.ToString() + "nbpg" + NbPages;
        }
    }
}
