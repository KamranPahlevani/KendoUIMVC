using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class PageTurnController : Controller
    {
        //
        // GET: /PageTurn/

        /// <summary>
        /// تا زدن المنت حول محوری خاص برای اشکار شدن پشت المنت 
        /// المنت باید دارای دو فرزند با ابعاد یکسان باشد
        /// </summary>
        /// <parameters>
        /// pageturn() parameters: المنت مقصد - المنت مبدا - عمودی یا افقی  
        /// pageturnHorizontal() parameters: المنت مقصد - المنت مبدا  
        /// pageturnVertical() parameters: المنت مقصد - المنت مبدا  
        /// </parameters>        
        /// <returns></returns>
        public ActionResult pageturn()
        {
            return View();
        }

    }
}
