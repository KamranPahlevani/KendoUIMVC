using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class FXController : Controller
    {
        //
        // GET: /FX/

        public ActionResult kendoAnimate()
        {
            return View();
        }

        public ActionResult kendoAddClass()
        {
            return View("kendoAddAndRemoveClass");
        }

        public ActionResult kendoRemoveClass()
        {
            return View("kendoAddAndRemoveClass");
        }

        public ActionResult kendoToggleClass()
        {
            return View();
        }

        public ActionResult Effects()
        {
            return View();
        }

    }
}
