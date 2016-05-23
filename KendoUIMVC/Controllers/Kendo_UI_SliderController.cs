using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_SliderController : Controller
    {
        /// <summary>
        /// destroy
        /// Prepares the Slider for safe removal from the DOM.
        /// Detaches event handlers and removes data entries in order to avoid memory leaks.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enable/Disable the Slider widget.
        /// Parameters
        /// enable Boolean
        /// The argument, which defines whether to enable/disable the Slider.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        /// <summary>
        /// value
        /// Gets or sets the value of a Slider. It accepts a string or number as parameters and returns a number representing the underlying value.
        /// Parameters
        /// value Number
        /// _optional, default: _
        /// The value to be set for a Slider.
        /// Returns
        /// Number The value of the Slider.
        /// </summary>
        /// <returns></returns>
        public ActionResult value()
        {
            return View();
        }

        /// <summary>
        /// resize
        /// Adjusts the Slider layout to match the size of the container.
        /// </summary>
        /// <returns></returns>
        public ActionResult resize()
        {
            return View();
        }
    }
}