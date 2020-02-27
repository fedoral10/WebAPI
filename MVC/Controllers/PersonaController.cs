using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            IEnumerable<MvcPersonaModel> list;
            HttpResponseMessage r = GlobalVariables.WebApiClient.GetAsync("Persona").Result;
            list = r.Content.ReadAsAsync<IEnumerable<MvcPersonaModel>>().Result;
            return View(list);
        }
    }
}