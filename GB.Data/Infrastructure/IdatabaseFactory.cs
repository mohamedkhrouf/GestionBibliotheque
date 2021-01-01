using GB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Data.Infrastructure
{
   public interface IdatabaseFactory :IDisposable
    {
        Context MyContext { get; }

    }
}
