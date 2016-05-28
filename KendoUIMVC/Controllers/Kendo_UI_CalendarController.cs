using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_UI_CalendarController : Controller
    {
        public ActionResult culture()
        {
            return View();
        }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template.
        /// </summary>
        /// <returns></returns>
        public ActionResult dates()
        {
            return View();
        }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        /// <returns></returns>
        public ActionResult depth()
        {
            return View();
        }

        /// <summary>
        /// Template to be used for rendering the footer. If false, the footer will not be rendered.
        /// </summary>
        /// <returns></returns>
        public ActionResult footer()
        {
            return View();
        }

        /// <summary>
        /// Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        /// <returns></returns>
        public ActionResult format() 
        {
            return View();
        }

        /// <summary>
        /// Specifies the maximum date, which the calendar can show.
        /// default: Date(2099, 11, 31)
        /// </summary>
        /// <returns></returns>
        public ActionResult max()
        {
            return View();
        }

        /// <summary>
        /// default: Date(1900, 0, 1)
        /// </summary>
        /// <returns></returns>
        public ActionResult min()
        {
            return View();
        }

        /// <summary>
        /// Template to be used for rendering the cells in the "month" view, which are in range.
        /// </summary>
        /// <returns></returns>
        public ActionResult month_content()
        {
            return View();
        }

        /// <summary>
        /// Specifies the start view.
        /// </summary>
        /// <returns></returns>
        public ActionResult start()
        {
            return View();
        }

        /// <summary>
        /// Specifies the selected date.
        /// </summary>
        /// <returns></returns>
        public ActionResult value()
        {
            return View();
        }

        /// <summary>
        /// Prepares the Calendar for safe removal from DOM. Detaches all event handlers and removes jQuery.
        /// data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        ///Important: This method does not remove the Calendar element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// Navigates to view
        /// </summary>
        /// <returns></returns>
        public ActionResult navigate()
        {
            return View();
        }

        /// <summary>
        /// Navigates to the lower view
        /// </summary>
        /// <returns></returns>
        public ActionResult navigateDown()
        {
            return View();
        }

        public ActionResult navigateToFuture()
        {
            return View();
        }

        public ActionResult navigateToPast()
        {
            return View();
        }

        public ActionResult navigateUp()
        {
            return View();
        }

        /// <summary>
        /// Gets currently focused date.
        /// </summary>
        /// <returns></returns>
        public ActionResult current()
        {
            return View();
        }

        public ActionResult view()
        {
            return View();
        }

        public ActionResult subscribe_to_the_change_event_during_initialization()
        {
            return view();
        }

        public ActionResult subscribe_to_the_change_event_after_initialization()
        {
            return view();
        }

        public ActionResult subscribe_to_the_navigate_event_during_initialization()
        {
            return view();
        }

        public ActionResult subscribe_to_the_navigate_event_after_initialization()
        {
            return view();
        }

        public ActionResult RTL()
        {
            return view();
        }

        /// <summary>
        /// The example below demonstrates how to control header format of the Kendo UI Calendar based on the selected culture
        /// </summary>
        /// <returns></returns>
        public ActionResult Control_header_format_based_on_selected_culture()
        {
            return view();
        }


    }
}
