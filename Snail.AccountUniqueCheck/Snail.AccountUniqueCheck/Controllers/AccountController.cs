using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Snail.AccountUniqueCheck.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult AccountCheck()
        {
            string value = Request["value"];
            string property = Request["property"];
            if (value == "www.upsnail.com")
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}