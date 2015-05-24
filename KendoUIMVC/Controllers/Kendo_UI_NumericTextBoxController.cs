using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_NumericTextBoxController : Controller
    {
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
        /// decimals Number(default: null)
        /// Specifies the number precision.
        /// If not set precision defined by current culture is used.
        /// </summary>
        /// <returns></returns>
        public ActionResult decimals()
        {
            return View();
        }

        /// <summary>
        /// downArrowText String(default: "Decrease value")
        /// Specifies the text of the tooltip on the down arrow.
        /// </summary>
        /// <returns></returns>
        public ActionResult downArrowText()
        {
            return View();
        }

        /// <summary>
        /// format String(default: "n")
        /// Specifies the format of the number. Any valid number format is allowed.
        /// </summary>
        /// <returns></returns>
        public ActionResult format()
        {
            return View();
        }

        /// <summary>
        /// max Number(default: null)
        /// Specifies the largest value the user can enter.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_max_option()
        {
            return View();
        }

        public ActionResult specify_max_option_as_a_HTML_attribute()
        {
            return View();
        }

        /// <summary>
        /// min Number(default: null)
        /// Specifies the smallest value the user can enter.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_min_option()
        {
            return View();
        }

        public ActionResult specify_min_option_as_a_HTML_attribute()
        {
            return View();
        }

        /// <summary>
        /// placeholder String(default: "")
        /// The hint displayed by the widget when it is empty. Not set by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult placeholder()
        {
            return View();
        }

        /// <summary>
        /// spinners Boolean(default: true)
        /// Specifies whether the up and down spin buttons should be rendered
        /// </summary>
        /// <returns></returns>
        public ActionResult spinners()
        {
            return View();
        }

        /// <summary>
        /// step Number(default: 1)
        /// Specifies the value used to increment or decrement widget value.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_step_option()
        {
            return View();
        }

        public ActionResult specify_step_option_as_a_HTML_attribute()
        {
            return View();
        }

        /// <summary>
        /// upArrowText String(default: "Increase value")
        /// Specifies the text of the tooltip on the up arrow.
        /// </summary>
        /// <returns></returns>
        public ActionResult upArrowText()
        {
            return View();
        }

        /// <summary>
        /// value Number(default: null)
        /// Specifies the value of the NumericTextBox widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_value_option()
        {
            return View();
        }

        public ActionResult specify_value_option_as_a_HTML_attribute()
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
        /// destroy
        ///Prepares the NumericTextBox for safe removal from DOM.
        ///Detaches all event handlers and removes jQuery.
        ///data attributes to avoid memory leaks.
        ///Calls destroy method of any child Kendo widgets.
        ///mportant: This method does not remove the NumericTextBox element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enables or disables the widget.
        /// Parameters
        /// enable Boolean
        /// If set to true the widget will be enabled. If set to false the widget will be disabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        /// <summary>
        /// readonly
        /// Toggles the readonly state of the widget. When the widget is readonly it doesn't allow user input.
        /// There is a difference between disabled and readonly mode.
        /// The value of a disabled widget is not posted as part of a form whereas the value of a readonly widget is posted.
        /// Parameters
        /// readonly Boolean
        /// If set to true the widget will not allow user input. If set to false the widget will allow user input.
        /// </summary>
        /// <returns></returns>
        public ActionResult Readonly()
        {
            return View();
        }

        /// <summary>
        /// focus
        /// Focuses the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult focus()
        {
            return View();
        }

        /// <summary>
        /// max
        /// Gets or sets the max value of the widget.
        /// Parameters
        /// value Number | String
        /// The max value to set.
        /// Returns
        /// Number The max value of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_max_value_of_the_NumericTextBo()
        {
            return View();
        }

        public ActionResult set_the_max_value_of_the_NumericTextBox()
        {
            return View();
        }

        /// <summary>
        /// min
        /// Gets or sets the min value of the widget.
        /// Parameters
        /// value Number | String
        /// The min value to set.
        /// Returns
        /// Number The min value of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_min_value_of_the_NumericTextBox()
        {
            return View();
        }

        public ActionResult set_the_min_value_of_the_NumericTextBox()
        {
            return View();
        }

        /// <summary>
        /// step
        /// Gets or sets the step value of the widget.
        /// Parameters
        /// value Number | String
        /// The step value to set.
        /// Returns
        /// Number The step value of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_step_value_of_the_NumericTextBox()
        {
            return View();
        }

        public ActionResult set_the_step_value_of_the_NumericTextBox()
        {
            return View();
        }

        /// <summary>
        /// value
        /// Gets or sets the value of the NumericTextBox.
        /// Parameters
        /// value Number | String
        /// The value to set.
        /// Returns
        /// Number The value of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_value_of_the_NumericTextBox()
        {
            return View();
        }

        public ActionResult set_the_value_of_the_NumericTextBox()
        {
            return View();
        }

        /// <summary>
        /// change
        /// Fires when the value is changed
        /// Event Data
        /// e.sender kendo.ui.NumericTextBox
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
        /// spin
        /// Fires when the value is changed from the spin buttons
        /// Event Data
        /// e.sender kendo.ui.NumericTextBox
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_spin_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_spin_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to add a title attribute to the input element of Kendo UI NumericTextBox
        /// </summary>
        /// <returns></returns>
        public ActionResult Add_title_attribute()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to change the color of the Kendo UI NumericTextBox value
        /// </summary>
        /// <returns></returns>
        public ActionResult Change_text_color()
        {
            return View();                
        }

        /// <summary>
        /// The example below demonstrates how to focus Kendo UI NumericTextBox when click label element
        /// </summary>
        /// <returns></returns>
        public ActionResult Focus_widget_on_label_click()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to persist the old value the Kendo UI NumericTextBox widget
        /// </summary>
        /// <returns></returns>
        public ActionResult Persist_old_value()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to select whole input value on focus
        /// </summary>
        /// <returns></returns>
        public ActionResult Select_all_text_on_focus()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to extend an existing culture script, create a custom script and use it with Kendo UI NumericTextBox
        /// </summary>
        /// <returns></returns>
        public ActionResult Use_a_custom_culture_script()
        {
            return View();
        }


    }
}