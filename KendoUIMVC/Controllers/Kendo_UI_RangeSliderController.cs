using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_RangeSliderController : Controller
    {
        /// <summary>
        /// largeStep Number(default: 5)
        /// The delta with which the value will change when the user presses the Page Up or Page Down key (the drag handle must be focused). Note: The allied largeStep will also set large tick for every large step.
        /// max Number(default: 10)
        /// The maximum value of the RangeSlider.
        /// min Number(default: 0)
        /// The minimum value of the RangeSlider.
        /// orientation String(default: "horizontal")
        /// The orientation of a RangeSlider; "horizontal" or "vertical".
        /// selectionEnd Number
        /// The selection end value of the RangeSlider.
        /// selectionStart Number
        /// The selection start value of the RangeSlider.
        /// smallStep Number(default: 1)
        /// The small step value of the RangeSlider. The underlying value will be changed when the end user (1) clicks on the increase or decrease buttons of the RangeSlider, (2) presses the arrow keys (the drag handle must be focused), or (3) drags the drag handle.
        /// tickPlacement String(default: "both")
        /// Denotes the location of the tick marks in the RangeSlider. The available options are:
        /// "topLeft"
        /// Tick marks are located on the top of the horizontal widget or on the left of the vertical widget.
        /// "bottomRight"
        /// Tick marks are located on the bottom of the horizontal widget or on the right side of the vertical widget.
        /// "both"
        /// Tick marks are located on both sides of the widget.
        /// "none"
        /// Tick marks are not visible.
        /// tooltip Object
        /// Configuration of the RangeSlider tooltip.
        /// tooltip.enabled Boolean(default: true)
        /// Disables (false) or enables (true) the tooltip of the RangeSlider.
        /// tooltip.format String(default: "{0}")
        /// Format string for the text of the tooltip. Note: The applied format will also influence the appearance of the RangeSlider tick labels.
        /// tooltip.template String
        /// Template of the tooltip.
        /// selectionStart - the current selectionStart.
        /// selectionEnd - the current selectionEnd.
        /// </summary>
        /// <returns></returns>
        public ActionResult Configuration()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Prepares the RangeSlider for safe removal from the DOM.
        /// Detaches event handlers and removes data entries in order to avoid memory leaks.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enable/Disable the RangeSlider widget.
        /// Parameters
        /// enable Boolean
        /// The argument, which defines whether to enable/disable the RangeSlider.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        /// <summary>
        /// The value method gets or sets the start and end values of the RangeSlider.
        /// It accepts an array as parameter, and returns an object array with the start and end selection values.
        /// Parameters
        /// selectionStart Number
        /// The selection start value of the RangeSlider.
        /// selectionEnd Number
        /// The selection end value of the RangeSlider.
        /// Returns
        /// Array The value of the RangeSlider.
        /// </summary>
        /// <returns></returns>
        public ActionResult value()
        {
            return View();
        }

        /// <summary>
        /// resize
        /// Adjusts the RangeSlider layout to match the size of the container.
        /// </summary>
        /// <returns></returns>
        public ActionResult resize()
        {
            return View();
        }

        /// <summary>
        /// change
        /// Fires when the RangeSlider value changes as a result of selecting a new value with one of the drag handles or the keyboard.
        /// Event Data
        /// e.value Number
        /// Represents the updated array of values of the first and second drag handle.
        /// </summary>
        /// <returns></returns>
        public ActionResult change()
        {
            return View();
        }

        /// <summary>
        ///  slide
        /// Fires when the user drags the drag handle to a new position.
        /// Event Data
        /// e.value Number
        /// Represents an array of values of the current positions of the first and second drag handle.
        /// </summary>
        /// <returns></returns>
        public ActionResult slide()
        {
            return View();
        }
    }
}