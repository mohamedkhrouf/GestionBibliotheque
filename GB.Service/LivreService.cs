using GB.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public class LivreService : Service<Livre>, IServiceLivre
    {
        public IEnumerable<Livre> GetAllLivres()
        {
            return GetMany(l => l is Livre).ToList();
        }
        public IEnumerable<Livre> ChercherLivre( string s)
        {
            return GetMany(l => l.Titre.Contains(s)).ToList();

        }
    }
}
