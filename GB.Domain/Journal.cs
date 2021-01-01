using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Journal : Document
    {
        public DateTime DateParution { get; set; }
        public override string ToString()
        {
            return base.ToString() + "parution" + DateParution ;
        }
    }
}
