using GB.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public interface IServiceDocument : Iservice<Document>
    {
        IEnumerable<Document> ChercherDocument(Bibliotheque biblio, string s);
        IEnumerable<Document> GetLivres(Bibliotheque b);
        Document GetDocumentById(int id);
    }
}
