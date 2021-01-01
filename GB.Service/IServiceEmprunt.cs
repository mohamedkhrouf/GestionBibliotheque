using GB.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public interface IServiceEmprunt : Iservice<Emprunt>
    {
        bool Empruntable(Document d);
        void Emprunter(Document d, Adherent a);
        void Rendre(Document d);
    }
}
