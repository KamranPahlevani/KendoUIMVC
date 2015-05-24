using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class TileController : Controller
    {
        //
        // GET: /Tile/

        /// <summary>
        /// لغزیدن المنت از جهت تعیین شده به موقعیت المنت در صفحه و در همان حال لغزیدن المنت پارامتر در جهت تعیین شده به خاج از المنت اصلی
        /// </summary>
        /// <parameters>
        /// tile() direction: left or right or up or down - previous: element
        /// tileLeft() previous: element
        /// tileRight() previous: element           
        /// </parameters>
        /// <returns></returns>
        public ActionResult tile()
        {
            return View();
        }

    }
}
