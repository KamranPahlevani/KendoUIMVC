using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_UI_DateTimePickerController : Controller
    {
        //
        // GET: /Kendo_UI_DateTimePicker/

        public ActionResult animation()
        {
            return View();
        }

        public ActionResult ARIATemplate()
        {
            return View();
        }

        public ActionResult culture()
        {
            return View();
        }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template of the DateView.
        /// All dates, which match the date portion of the selected date will be used to re-bind the TimeView.
        /// </summary>
        /// <returns></returns>
        public ActionResult dates()
        {
            return View();
        }

        /// <summary>
        /// Specifies the navigation depth of the calendar. The following settings are available for the depth value:
        /// </summary>
        /// <returns></returns>
        public ActionResult depth()
        {
            return View();
        }

        /// <summary>
        /// Template to be used for rendering the footer of the calendar.
        /// </summary>
        /// <returns></returns>
        public ActionResult footer()
        {
            return View();
        }

        /// <summary>
        /// default: "MM/dd/yyyy h:mm tt"
        /// Specifies the format, which is used to format the value of the DateTimePicker displayed in the input.
        /// The format also will be used to parse the input.
        /// </summary>
        /// <returns></returns>
        public ActionResult format()
        {
            return View();
        }

        /// <summary>
        /// default: 30
        /// Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        /// <returns></returns>
        public ActionResult interval()
        {
            return View();
        }

        /// <summary>
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
        /// Template to be used for rendering the cells in the calendar "month" view, which are in range.
        /// </summary>
        /// <returns></returns>
        public ActionResult month_content()
        {
            return View();
        }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with value() method or by direct input.
        /// If not set the value of the options.format and options.timeFormat will be used.
        /// Note that value of the format option is always used.
        /// </summary>
        /// <returns></returns>
        public ActionResult parseFormats()
        {
            return View();
        }

        /// <summary>
        /// Specifies the start view of the calendar. The following settings are available for the start value
        /// </summary>
        /// <returns></returns>
        public ActionResult start()
        {
            return View();
        }

        /// <summary>
        /// Specifies the format, which is used to format the values in the time drop-down list.
        /// </summary>
        /// <returns></returns>
        public ActionResult timeFormat()
        {
            return View();
        }

        /// <summary>
        /// Specifies the selected value.
        /// </summary>
        /// <returns></returns>
        public ActionResult value()
        {
            return View();
        }

        public ActionResult close()
        {
            return View();
        }

        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// Enables or disables a DateTimePicker.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        public ActionResult readOnly()
        {
            return View();
        }

        public ActionResult open()
        {
            return View();
        }

        public ActionResult toggle()
        {
            return View();
        }

        public ActionResult change_event()
        {
            return View();
        }

        public ActionResult close_event()
        {
            return View();
        }

        public ActionResult open_event()
        {
            return View();
        }

        public ActionResult RTL()
        {
            return View();
        }


        /// <summary>
        /// Example that shows how to create custom date validation
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_create_custom_date_validation()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to override hours in the popup
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_override_hours_in_the_popup()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to prevent invalid values in Kendo UI DateTimePicker
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_prevent_invalid_values()
        {
            return View();
        }


    }
}
