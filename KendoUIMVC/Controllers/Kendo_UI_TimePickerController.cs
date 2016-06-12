using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_TimePickerController : Controller
    {
        // GET: Kendo_UI_TimePicker

        /// <summary>
        /// animation Object
        /// Configures the opening and closing animations of the popup.
        /// Setting the animation option to false will disable the opening and closing animations.
        /// As a result the popup will open and close instantly.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_open_and_close_animations()
        {
            return View();
        }

        public ActionResult configure_the_animation()
        {
            return View();
        }

        /// <summary>
        /// animation.close Object
        /// The animation played when the popup is closed.
        /// animation.close.effects String
        /// The effect(s) to use when playing the open animation. Multiple effects should be separated with a space.
        /// Complete list of available animations
        /// animation.close.duration Number
        /// The duration of the close animation in milliseconds.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_close()
        {
            return View();
        }

        /// <summary>
        /// animation.open Object
        /// The animation played when the calendar popup is opened.
        /// animation.open.effects String
        /// The effect(s) to use when playing the open animation. Multiple effects should be separated with a space.
        /// Complete list of available animations
        /// animation.open.duration Number
        /// The duration of the open animation in milliseconds.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open()
        {
            return View();
        }

        /// <summary>
        /// culture String(default: "en-US")
        /// Specifies the culture info used by the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult culture()
        {
            return View();
        }

        /// <summary>
        /// dates Array
        /// Specifies a list of dates, which are shown in the time drop-down list.
        /// If not set, the TimePicker will auto-generate the available times.
        /// </summary>
        /// <returns></returns>
        public ActionResult dates()
        {
            return View();
        }

        /// <summary>
        /// format String(default: "h:mm tt")
        /// Specifies the format, which is used to format the value of the TimePicker displayed in the input.
        /// The format also will be used to parse the input.
        /// </summary>
        /// <returns></returns>
        public ActionResult format()
        {
            return View();
        }

        /// <summary>
        /// interval Number(default: "30")
        /// Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        /// <returns></returns>
        public ActionResult interval()
        {
            return View();
        }

        /// <summary>
        /// max Date(default: "00:00")
        /// Specifies the end value in the popup list.
        /// </summary>
        /// <returns></returns>
        public ActionResult max()
        {
            return View();
        }

        /// <summary>
        /// min Date(default: "00:00")
        /// Specifies the start value in the popup list.
        /// </summary>
        /// <returns></returns>
        public ActionResult min()
        {
            return View();
        }

        /// <summary>
        /// parseFormats Array
        /// Specifies the formats, which are used to parse the value set with the value method or by direct input.
        /// If not set the value of the options.format will be used. Note that value of the format option is always used.
        /// Order of the provided parse formats is important and it should from stricter to less strict.
        /// </summary>
        /// <returns></returns>
        public ActionResult parseFormats()
        {
            return View();
        }

        /// <summary>
        /// value Date(default: null)
        /// Specifies the selected time.
        /// </summary>
        /// <returns></returns>
        public ActionResult value()
        {
            return View();
        }

        /// <summary>
        /// options Object
        /// An object, which holds the options of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult options()
        {
            return View();
        }

        /// <summary>
        /// close
        /// Closes the drop-down list of a TimePicker.
        /// </summary>
        /// <returns></returns>
        public ActionResult close()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Prepares the TimePicker for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks.
        /// Calls destroy method of any child Kendo widgets.
        /// Important: This method does not remove the TimePicker element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enables or disables a TimePicker.
        /// Parameters
        /// enable Boolean
        /// Enables (true or undefined) or disables (false) a TimePicker.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_TimePicker_widget()
        {
            return View();
        }

        public ActionResult enable_TimePicker_widget()
        {
            return View();
        }

        /// <summary>
        /// Toggles the readonly state of the widget. When the widget is readonly it doesn't allow user input.
        /// There is a difference between disabled and readonly mode.
        /// The value of a disabled widget is not posted as part of a form whereas the value of a readonly widget is posted.
        /// Parameters
        /// readonly Boolean
        /// The argument, which defines whether the TimePicker should be readonly or editable.
        /// </summary>
        /// <returns></returns>
        public ActionResult make_TimePicker_widget_readonly()
        {
            return View();
        }

        public ActionResult make_TimePicker_widget_editable()
        {
            return View();
        }

        /// <summary>
        /// max
        /// Gets or sets the maximum value of the TimePicker.
        /// Parameters
        /// value Date|String
        /// The maximum time value to set for a TimePicker, expressed as a Date object or as a string.
        /// Returns
        /// Date The maximum time value of a TimePicker.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_max_value_of_the_TimePicker()
        {
            return View();
        }

        public ActionResult set_the_max_value_of_the_TimePicker()
        {
            return View();
        }

        /// <summary>
        /// min
        /// Gets or sets the minimum value of the TimePicker.
        /// Parameters
        /// value Date|String
        /// The minimum time value to set for a TimePicker, expressed as a Date object or as a string.
        /// Returns
        /// Date The minimum time value of a TimePicker.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_min_value_of_the_TimePicker()
        {
            return View();
        }

        public ActionResult set_the_min_value_of_the_TimePicker()
        {
            return View();
        }

        /// <summary>
        /// open
        /// Opens the drop-down list of a TimePicker.
        /// </summary>
        /// <returns></returns>
        public ActionResult open()
        {
            return View();
        }

        /// <summary>
        /// setOptions
        /// Changes the initial TimePicker configuration. Will be included in Q3 2013 SP1.
        /// Currently available in Q3 2013 internal builds only.
        /// Parameters
        /// options Object
        /// The new configuration options.
        /// </summary>
        /// <returns></returns>
        public ActionResult setOptions()
        {
            return View();
        }

        /// <summary>
        /// value
        /// Gets or sets the value of the TimePicker.
        /// Parameters
        /// value Date|String
        /// The time value to set for a TimePicker, expressed as a Date object or as a string.
        /// Returns
        /// Date The time value of a TimePicker.
        /// </summary>
        /// <returns></returns>
        public ActionResult gets_the_value_of_the_widget()
        {
            return View();
        }

        public ActionResult sets_the_value_of_the_widget()
        {
            return View();
        }

        /// <summary>
        /// change
        /// Fires when the selected date is changed
        /// Event Data
        /// e.sender kendo.ui.TimePicker
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_change_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_change_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// close
        /// Fires when the time drop-down list is closed
        /// Event Data
        /// e.sender kendo.ui.TimePicker
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_close_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_close_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// open
        /// Fires when the time drop-down list is opened
        /// Event Data
        /// e.sender kendo.ui.TimePicker
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_open_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_open_event_after_initialization()
        {
            return View();
        }


    }
}