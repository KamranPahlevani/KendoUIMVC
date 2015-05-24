using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class TransferController : Controller
    {
        //
        // GET: /Transfer/

        /// <summary>
        /// تغییر مقیاس و جایگاه المنت بر اساس المنت هدف
        /// </summary>
        /// المنت جاری و المنت هدف باید دارای خصیصه های یکسانی باشند
        /// <returns></returns>
        public ActionResult transfer()
        {
            return View();
        }

    }
}
