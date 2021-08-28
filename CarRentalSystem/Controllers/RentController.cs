using CarRentalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalSystem.Controllers
{
    public class RentController : Controller
    {

        supercar db = new supercar();
        //
        // GET: Rent
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Getcar()
        {
            var car = db.carregs.ToList();

            return Json(car, JsonRequestBehavior.AllowGet);
        }
    }
}