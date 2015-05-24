using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class SlideInController : Controller
    {
        //
        // GET: /SlideIn/

        /// <summary>
        /// لغزیدن المنت از جهت تعیین شده به موقعیت المنت در صفحه
        /// </summary>
        /// <parameters>
        /// slideIn() direction: left or right or up or down
        /// slideInLeft()   
        /// slideInRight()   
        /// </parameters>        
        /// <returns></returns>
        public ActionResult slidein()
        {
            return View();
        }

    }
}
