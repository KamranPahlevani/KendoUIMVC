using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class ExpandController : Controller
    {
        //
        // GET: /Expand/

        /// <summary>
        /// المنت را از 0 تا مقداری معین بسط می دهد
        /// </summary>
        /// <parameters>
        /// duration(vertical or horizontal)
        /// </parameters>
        /// <returns></returns>
        public ActionResult expand()
        {
            return View();
        }

    }
}
