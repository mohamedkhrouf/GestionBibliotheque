using GB.Domain;
using System.Collections.Generic;

namespace GB.Service
{
   public interface IServiceLivre : ServicePattern.Iservice<Livre>
    {

        IEnumerable<Livre> GetAllLivres();
        IEnumerable<Livre> ChercherLivre( string s);
    }
}