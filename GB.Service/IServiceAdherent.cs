using GB.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public interface IServiceAdherent : Iservice<Adherent>
    {
        bool login(string username, string password);
        Adherent GetUserById(int v);
        Adherent GetUser(string username, string password);
    }
}
