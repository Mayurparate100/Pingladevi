using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pingladevi.Models;


namespace Pingladevi.Controllers
{
    public class Pavati1Controller : Controller
    {
        // GET: Pavati1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetPavati1List()
        {
            try
            {
                return Json(new { model = (new Pavati1Model().GetPavati1List()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

            public ActionResult GetEditData(int ID)
            {

                try
                {
                    return Json(new { model = (new Pavati1Model().EditData(ID)) }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception Ex)
                {
                    return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }

    


}
}