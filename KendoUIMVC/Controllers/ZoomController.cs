using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class ZoomController : Controller
    {
        //
        // GET: /Zoom/

        /// <summary>
        /// بزرگ نمایی و کوچک نمایی
        /// <parameters>
        /// zoom() direction: in or out
        /// zoomIn()
        /// zoomOut()
        /// </parameters>
        /// </summary>
        /// <returns></returns>
        public ActionResult zoom()
        {
            return View();
        }

    }
}
