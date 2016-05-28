using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_ObservableController : Controller
    {
        //
        // GET: /Kendo_Observable/

        /// <summary>
        /// ایجاد ارتباط بین رویداد و هندلر
        /// </summary>
        /// <returns></returns>
        public ActionResult bind()
        {
            return View();
        }

        /// <summary>
        /// ایجاد ارتباط بین رویداد و هندلر که هندلر فقط یکبار اجرا می شود
        /// </summary>
        /// <returns></returns>
        public ActionResult one()
        {
            return View();
        }

        /// <summary>
        /// اجرای هندلر مرتبط با رویداد
        /// </summary>
        /// <returns></returns>
        public ActionResult trigger()
        {
            return View();
        }

        /// <summary>
        /// قطع ارتباط بین رویداد و هندلر
        /// </summary>
        /// <returns></returns>
        public ActionResult unbind()
        {
            return View();
        }

    }
}
