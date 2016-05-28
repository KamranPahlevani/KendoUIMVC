using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_LayoutController : Controller
    {
        //
        // GET: /Kendo_Layout/

        /// <summary>
        /// المنت ویو را در المنت مشخص سده ایجاد می کند
        /// </summary>
        /// <returns></returns>
        public ActionResult showIn()
        {
            return View();
        }

    }
}
