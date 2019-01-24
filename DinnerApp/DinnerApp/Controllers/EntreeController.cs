using DinnerApp.HelperClasses;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DinnerApp.Controllers
{
    public class EntreeController : Controller
    {
        // GET: Entree
        public ActionResult Index()
        {
            var entree = EntreeManager.GetAll();
            return View(entree);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            try
            {
                var entree = EntreeManager.GetAll().First(e => e.ID == id);
                    return View(entree);
            }
            catch(Exception)
            {
                TempData["Error Message"] = "No Entree with Id " + id.ToString() + "exists";
                return RedirectToAction ("Index");
            }
        }
    }
}