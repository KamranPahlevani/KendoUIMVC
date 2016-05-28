using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_ClassController : Controller
    {
        //
        // GET: /Kendo_Class/

        /// <summary>
        /// کلاس پایه بیشتر ابجکت ها که ارث بری ساده را فراهم می کند
        /// fn: یک استعاره از نمونه اصلی کلاس که اغلب به منظور صدا زدن متد های کلاس پایه مورد استفاده قرار می گیرد
        /// extend: کلاس موجود را با متد های جدید توسعه می دهد
        /// </summary>
        /// <returns></returns>
        public ActionResult ClassFields()
        {
            return View();
        }

        /// <summary>
        /// کلاس پایه بیشتر ابجکت ها که ارث بری ساده را فراهم می کند
        /// fn: یک استعاره از نمونه اصلی کلاس که اغلب به منظور صدا زدن متد های کلاس پایه مورد استفاده قرار می گیرد
        /// extend: کلاس موجود را با متد های جدید توسعه می دهد
        /// </summary>
        /// <returns></returns>
        public ActionResult ClassMethods()
        {
            return View();
        }

    }
}
