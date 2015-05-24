using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class FlipController : Controller
    {
        //
        // GET: /Flip/

        /// <summary>
        /// چرخش المنت بصورت عمودی یا افقی    
        /// المنت باید دارای دو فرزند با ابعاد یکسان باشد
        /// </summary>
        /// <parameters>
        /// flip() parameters: المنت مقصد - المنت مبدا - عمودی یا افقی  
        /// flipHorizontal() parameters: المنت مقصد - المنت مبدا  
        /// flipVertical() parameters: المنت مقصد - المنت مبدا  
        /// </parameters>
        /// <returns></returns>
        public ActionResult flip()
        {
            return View();
        }

    }
}
