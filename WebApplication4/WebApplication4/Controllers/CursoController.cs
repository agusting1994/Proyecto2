using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CursoController : Controller
    {
        // GET: Cursos
        //Lista todos los cursos
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //Lista los cursos filtrando por id de academia
        public ActionResult Index(int id)
        {
            return View();
        }
        public ActionResult Ver(int id)
        {
           
            return View();
        }
    }
}