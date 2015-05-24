using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class KendoController : Controller
    {
        //
        // GET: /Kendo/

        /// <summary>
        /// بایند کردن اچ تی ام ال ویو به ویو مدل
        /// </summary>
        /// <returns></returns>
        public ActionResult bind()
        {
            return View();
        }

        public ActionResult observableHierarchy()
        {
            return View();
        }

        /// <summary>
        /// ایجاد یا اخذ کالچر جاری
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult culture()
        {
            return View();
        }

        /// <summary>
        /// فرمت دهی به رشته ها
        /// </summary>
        /// <returns></returns>
        public ActionResult format()
        {
            return View();
        }

        /// <summary>
        /// رمز نگاری کاراکترهای اچ تی ام ال
        /// </summary>
        /// <returns></returns>
        public ActionResult htmlEncode()
        {
            return View();
        }

        public ActionResult parseDate()
        {
            return View();
        }

        public ActionResult parseFloat()
        {
            return View();
        }

        public ActionResult parseInt() {
            return View();
        }

        public ActionResult parseColor()
        {
            return View();
        }

        /// <summary>
        /// الگوی مشخص شده را با دیتای فراهم شده برای آن بر روی صفحه ایجاد می کند
        /// </summary>
        /// <returns></returns>
        public ActionResult render()
        {
            return View();
        }

        /// <summary>
        /// ایجاد رشته جیسون
        /// </summary>
        /// <returns></returns>
        public ActionResult stringify()
        {
            return View();
        }

        /// <summary>
        /// ترجمه الگو به تابعی که کد اچ تی ام ال ایجاد می کند
        /// </summary>
        /// <returns></returns>
        public ActionResult template()
        {
            return View();
        }

        public ActionResult FormattingNumbersAndDates() 
        {
            return View();
        }

        public ActionResult ColorObjects()
        {
            return View();
        }

    }
}
