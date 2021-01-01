using GB.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public class AdherentService : Service<Adherent>, IServiceAdherent
    {
        public bool login(string username, string password)
        {
            return GetMany(a => a.Login == username && a.Password==password).Count()==1;
        }
        public Adherent GetUser(string username, string password)
        {
            return GetMany(a => a.Login == username && a.Password == password).First() ;
        }
        public Adherent GetUserById(int id)
        {
            return GetMany(a => a.Id_Adherent == id ).First();
        }


    }
}
