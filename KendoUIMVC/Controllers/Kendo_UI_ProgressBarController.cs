using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_ProgressBarController : Controller
    {

        /// <summary>
        /// animation Object
        /// Configures the progress animation. Currently only the duration of the animation could be set.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_the_duration_of_the_progress_animation()
        {
            return View();
        }

        public ActionResult disable_the_progress_animation()
        {
            return View();
        }

        /// <summary>
        /// animation.duration Number (default: 400)
        /// The duration of each progress animation in milliseconds.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_duration()
        {
            return View();
        }

        /// <summary>
        /// chunkCount Number (default: 5)
        /// Specifies the number of chunks.
        /// Important This property is applicable only when the type of the ProgressBar is set to chunk.
        /// </summary>
        /// <returns></returns>
        public ActionResult chunkCount()
        {
            return View();
        }

        /// <summary>
        /// enable Boolean (default: true)
        /// If set to false the widget will be disabled. It will still allow changing the value. The widget is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        /// <summary>
        /// max Number (default: 100)
        /// The maximum value of the ProgressBar.
        /// </summary>
        /// <returns></returns>
        public ActionResult max() 
        {
            return View();
        }

        /// <summary>
        /// min Number (default: 0)
        /// The minimum value of the ProgressBar.
        /// </summary>
        /// <returns></returns>
        public ActionResult min()
        {
            return View();
        }

        /// <summary>
        /// orientation String (default: "horizontal")
        /// The orientation of the ProgressBar. Possible values are horizontal and vertical.
        /// </summary>
        /// <returns></returns>
        public ActionResult orientation()
        {
            return View();
        }

        /// <summary>
        /// reverse Boolean (default: false)
        /// Specifies if the progress direction will be reversed.
        /// </summary>
        /// <returns></returns>
        public ActionResult reverse()
        {
            return View();
        }

        /// <summary>
        /// showStatus Boolean (default: true)
        /// Specifies if the progress status will be shown
        /// </summary>
        /// <returns></returns>
        public ActionResult showStatus()
        {
            return View();
        }

        /// <summary>
        /// type String (default: "value")
        /// Specifies the type of the ProgressBar. The supported types are value, percent and chunk.
        /// Important The chunk progress type is not supported in Internet Explorer 7.
        /// </summary>
        /// <returns></returns>
        public ActionResult type()
        {
            return View();
        }

        /// <summary>
        /// value Number
        /// The underlying value of the ProgressBar.
        /// </summary>
        /// <returns></returns>
        public ActionResult value()
        {
            return View();
        }

        /// <summary>
        /// progressStatus jQuery
        /// The jQuery object which represents the progress status fields.
        /// This object could be empty if no progress status fields are currently existing in the DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult progressStatus()
        {
            return View();
        }

        /// <summary>
        /// progressWrapper jQuery
        /// The jQuery object which represents the progress wrapper.
        /// This object could be empty if the progress has not started yet and the value is equal to the minimum value.
        /// </summary>
        /// <returns></returns>
        public ActionResult progressWrapper()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enables/Disables the ProgressBar widget.
        /// Parameters
        /// enable Boolean
        /// The argument, which defines whether to enable/disable the ProgressBar.
        /// If no argument is passed, the widget will be enabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_method()
        {
            return View();
        }

        /// <summary>
        /// value
        /// Gets or sets the value of the ProgressBar. It accepts a number, a string or false as a parameter. Setting the value to false will set the state of the ProgressBar to indeterminate. If no parameter is passed, it returns the underlying value.
        /// Parameters
        /// value Number
        /// The value to be set.
        /// Returns
        /// Number the value of the widget.
        /// </summary>
        public ActionResult getting_the_current_ProgressBar_value()
        {
            return View();
        }

        public ActionResult setting_the_value_of_the_ProgressBar()
        {
            return View();
        }

        /// <summary>
        /// change
        /// Fired when the value of the ProgressBar has changed. If the progress animation is enabled, the event will be fired after the animation has completed (does not applies to chunk ProgressBar).
        /// Event Data
        /// e.value Number
        /// The current value of the ProgressBar.
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
        /// complete
        /// Fired when the value of the ProgressBar reaches the maximum value.
        /// Important The event is not fired during the initialization of the widget, even when the initial value is equal to the maximum value.
        /// Event Data
        /// e.value Number
        /// The current value of the ProgressBar.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_complete_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_complete_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// By default, the ProgressBar is 27em wide inline-block element.
        /// The easiest cross-browser technique to make it expand and resize automatically is to apply a couple of CSS styles to the originating element.
        /// </summary>
        /// <returns></returns>
        public ActionResult Making_the_ProgressBar_100percent_wide_and_automatically_resizable()
        {
            return View();
        }

    }
}