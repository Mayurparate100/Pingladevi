using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pingladevi.Models;


namespace Pingladevi.Controllers
{
    public class PavatiController : Controller
    {
        //GET:Pavati
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult D2()
        {
            return View();
        }


        public ActionResult SavePavati(PavatiModel model)
        {
            try
            {
                return Json(new { message = (new PavatiModel().SavePavati(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { model = Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DetailData(int Id)
        {
            try
            {
                return Json(new { model = (new PavatiModel().DetailData(Id)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}




