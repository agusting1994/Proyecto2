using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Datos;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class AcademiaController : Controller
    {
        // GET: Academia
        public ActionResult Index()
        {
            ModelContext db = new ModelContext();
            return View(db.academia.ToList());
        }
    }
}