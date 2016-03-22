using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_ResponsivePanelController : Controller
    {

        /// <summary>
        /// autoClose Boolean (default: true)
        /// If set to false the widget will not close when the page content is touched, after it was opened on a mobile device.
        /// You will need to call the close method when the panel needs to close.
        /// </summary>
        /// <returns></returns>
        public ActionResult autoClose()
        {
            return View();
        }
    }
}