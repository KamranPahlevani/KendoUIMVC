using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class CommonEffectsAPIController : Controller
    {
        //
        // GET: /common/

        /// <summary>
        /// تنظیم مدت زمان محو شدن
        /// </summary>
        /// <parameters>
        /// duration Number
        /// </parameters>
        /// <returns>Effect the effect instance for further usage</returns>
        public ActionResult duration()
        {
            return View();
        }

        /// <summary>
        /// تنظیم جهت افکت
        /// </summary>
        /// <parameters>
        /// direction string
        /// </parameters>
        /// <returns>Effect the effect instance for further usage</returns>
        public ActionResult direction()
        {
            return View();
        }

        /// <summary>
        /// نمایش افکت
        /// </summary>
        /// <returns>Promise a jQuery promise instance, which can be used for callbacks, or passed to jQuery.when</returns>
        public ActionResult play()
        {
            return View();
        }

        /// <summary>
        /// نمایش افکت در جهت معکوس 
        /// </summary>
        /// <returns>Promise a jQuery promise instance, which can be used for callbacks, or passed to jQuery.when.</returns>
        public ActionResult reverse()
        {
            return View();
        }

        /// <summary>
        /// توقف افکت در وضعیت جاری
        /// </summary>
        /// <returns></returns>
        public ActionResult stop()
        {
            return View();
        }

    }
}
