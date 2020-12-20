using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Бипит9.Controllers
{
    public class DefaultController : Controller
    {

        BIPIT3Entities basa = new BIPIT3Entities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FIO()
        {
            IEnumerable<FIOs> fio = basa.FIOs;
            ViewBag.FIO = fio;
            return View("FIO");
        }

        public ActionResult Avto()
        {
            IEnumerable<Avtoes> avto = basa.Avtoes;
            ViewBag.Avto = avto;
            return View("Avto");
        }

        public ActionResult Arenda()
        {
            IEnumerable<Arendas> arenda = basa.Arendas;
            ViewBag.Arenda = arenda;
            return View("Arenda");
        }
    }
}