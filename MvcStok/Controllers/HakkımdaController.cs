using MvcStok.Models.Enty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStok.Controllers
{
    public class HakkımdaController : Controller
    {
		// GET: Hakkımda
		MvcDbStokEntities db = new MvcDbStokEntities();
		public ActionResult Index()
        {
            var degerler=db.TBLHAKKIMDA.ToList();
            return View(degerler);
        }
    }
}