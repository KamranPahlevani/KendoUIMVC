using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class FadeController : Controller
    {
        //
        // GET: /Fade/

        /// <summary>
        /// محو نمودن یا ظاهر نمودن المنت
        /// <parameters>
        /// پارامتر in یا متد fadeIn()
        /// پارامتر out یا متد fadeOut()
        /// </parameters>
        /// </summary>
        /// <returns></returns>
        public ActionResult fade()
        {
            return View();
        }

    }
}
