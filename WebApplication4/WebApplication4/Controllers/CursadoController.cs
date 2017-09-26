using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class CursadoController : Controller
    {
        // GET: Cursado
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}