using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_ViewController : Controller
    {
        //
        // GET: /Kendo_View/

        /// <summary>
        /// مدل ام وی وی ام به منظور برقراری ارتباط با المنت 
        /// </summary>
        /// <returns></returns>
        public ActionResult model()
        {
            return View();
        }

        /// <summary>
        /// مورد استفاده برای مسیریابی المنت
        /// </summary>
        /// <returns></returns>
        public ActionResult tagName()
        {
            return View();
        }

        /// <summary>
        /// If set to false, the view will not wrap its contents in a root element. In that case, the view element will point to the root element in the template.
        /// </summary>
        /// <returns></returns>
        public ActionResult wrap()
        {
            return View();
        }

        public ActionResult destroy()
        {
            return View();
        }

        public ActionResult render()
        {
            return View();
        }

        public ActionResult hide()
        {
            return View();
        }

        public ActionResult init()
        {
            return View();
        }

        public ActionResult show()
        {
            return View();
        }

    }
}
