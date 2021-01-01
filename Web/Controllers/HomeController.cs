using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GB.Data;
using GB.Domain;
using GB.Service;
namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IServiceEmprunt ES = new EmpruntService();
        IServiceLivre LS = new LivreService();
        IServiceAdherent AS = new AdherentService();
        IServiceBibliotheque BS = new BibliothequeService();
        IServiceDocument DS = new DocumentService();
        public ActionResult Index()
        {
            var DS = new DocumentService();
            
            return View();
        }
         [Route("/Home/{username}/{password}")]
        [HttpPost]

        public ActionResult Index(string username, string password)
        {
           

            
            if (AS.login(username,password))
            {
               
                Session["UserId"] = AS.GetUser(username, password).Id_Adherent;
                return RedirectToAction("List");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //[Route("/Home/List/{recherche}")]

        public ActionResult List()
        {
         
            ViewData["id"] = AS.GetUserById((int)Session["UserId"]).Login;
           
      
            return View("list", LS.GetAllLivres());
        }
        [HttpPost]

        public ActionResult Search(string recherche)
        {
            var AS = new AdherentService();
            ViewData["id"] = AS.GetUserById((int)Session["UserId"]).Login;
            var LS = new LivreService();
          
           
                return View("list", LS.ChercherLivre(recherche));
         
        }


        public ActionResult Emprunt(int id)
        {
            if (Session["UserId"] != null)
            {
                
               

                ES.Emprunter(DS.GetDocumentById(id),AS.GetUserById((int)Session["UserId"]));
            }

            return RedirectToAction("list");

        }


    }
}