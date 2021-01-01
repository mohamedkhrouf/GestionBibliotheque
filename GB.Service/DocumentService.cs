using GB.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public class DocumentService : Service<Document>, IServiceDocument
    {
       
        public IEnumerable<Document> GetLivres(Bibliotheque biblio)
        {
            return GetMany(d => d.Bibliotheque.Id_Bibliotheque == biblio.Id_Bibliotheque).ToList().Where(d => d is Livre);
        }

        public IEnumerable<Document> ChercherDocument(Bibliotheque biblio, string s)
        {
            return GetMany(d => d.Bibliotheque.Id_Bibliotheque == biblio.Id_Bibliotheque && d.Titre.Contains(s)).ToList();

        }
        public Document GetDocumentById(int id)
        {
            return GetMany(d => d.Id_Document == id).First();
        }
    }
  
}
