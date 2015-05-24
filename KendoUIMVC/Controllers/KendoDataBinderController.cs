using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class KendoDataBinderController : Controller
    {
        //
        // GET: /KendoDataBinder/

        /// <summary>
        /// کلاس پایه ایجاد MVVM-style bindings
        /// </summary>
        /// <returns></returns>
        public ActionResult binder()
        {
            return View();
        }

    }
}
