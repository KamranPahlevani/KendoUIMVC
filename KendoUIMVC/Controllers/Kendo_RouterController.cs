using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_RouterController : Controller
    {
        //
        // GET: /Kendo_Router/

        /// <summary>
        /// فعال سازی ارتباط مابین روتر و تغییرات قسمت یوارال فراگمنت
        /// </summary>
        /// <returns></returns>
        public ActionResult start()
        {
            return View();
        }

        /// <summary>
        /// مشخص نمودن کال بک برای مسیر
        /// </summary>
        /// <returns></returns>
        public ActionResult route()
        {
            return View();
        }

        public ActionResult routeMissing()
        {
            return View();
        }

    }
}
