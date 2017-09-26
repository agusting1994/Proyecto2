using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Areas.Cursado.Controllers
{
    public class HomeController : Controller
    {
        // GET: Cursado/Home
        [Authorize(Roles =("Alumno Activo"))]
        public ActionResult Index()
        {
            return View();
        }
    }
}