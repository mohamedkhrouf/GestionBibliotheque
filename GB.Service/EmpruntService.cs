using GB.Data;
using GB.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public class EmpruntService : Service<Emprunt>, IServiceEmprunt
    {
        public bool Empruntable(Document d)
        {
            bool em = true;
            if (d is Livre)
            {

                foreach (Emprunt emprunt in d.Emprunts)
                {
                    if (emprunt.DateRetour == null)
                    {
                        em = false;
                    }
                }
            }
            else
            {
                em = false;
            }



            return em;
        }
        public void Emprunter(Document d, Adherent a)
        {
           
            if (Empruntable(d))
            {
                Emprunt emprunt = new Emprunt(a,d,DateTime.Now);

                Add(emprunt);
                Commit();
             
            }
        }
       public void Rendre(Document d)
        {
            var D = new DocumentService();
            foreach (Emprunt emprunt in d.Emprunts)
            {
                if (emprunt.DateRetour == null)
                {
                    emprunt.DateRetour = DateTime.Now;
                    emprunt.DureeEmprunt =   DateTime.Now.Second - emprunt.DateEmprunt.Second;
                    D.Update(d);
                }
            }
        }
        
}
    }

