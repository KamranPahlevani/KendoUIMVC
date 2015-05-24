using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_PagerController : Controller
    {
        /// <summary>
        /// autoBind Boolean(default: true)
        /// Indicates whether the pager refresh method will be called within its initialization.
        /// </summary>
        /// <returns></returns>
        public ActionResult autoBind()
        {
            return View();
        }

        /// <summary>
        /// buttonCount Number(default: 10)
        /// Defines the number of buttons displayed in the numeric pager.
        /// </summary>
        /// <returns></returns>
        public ActionResult buttonCount()
        {
            return View();
        }

        /// <summary>
        /// Instance of kendo DataSource. See the kendo.data.DataSource.
        /// This option is mandatory because the Pager is tightly connected with DataSource.
        /// The pager is UI widget for managing paging over the DataSource.
        /// The Pager gets values like page size or total count of items from DataSource.
        /// </summary>
        /// <returns></returns>
        public ActionResult standalone_pager()
        {
            return View();
        }

        /// <summary>
        /// If the Pager is used with another widget then we usually specify this Pager like object of options for given widget.
        /// In that case the DataSource is automatically injected to the Pager from the widget. See example for a Grid below.
        /// </summary>
        /// <returns></returns>
        public ActionResult grid_pager()
        {
            return View();
        }
    }
}