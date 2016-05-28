using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_MaskedTextBoxController : Controller
    {
        //
        // GET: /Kendo_UI_MaskedTextBox/

        /// <summary>
        /// clearPromptChar Boolean(default: false)
        /// Specifies whether the widget will replace the prompt characters with spaces on blur.
        /// Prompt chars will be shown again on focus.
        /// </summary>
        /// <returns></returns>
        public ActionResult clearPromptChar()
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
        /// mask String(default: "")
        /// Specifies the input mask. The following mask rules are supported:
        /// 0 - Digit. Accepts any digit between 0 and 9.
        /// 9 - Digit or space. Accepts any digit between 0 and 9, plus space.
        /// # - Digit or space. Like 9 rule, but allows also (+) and (-) signs.
        /// L - Letter. Restricts input to letters a-z and A-Z. This rule is equivalent to [a-zA-Z] in regular expressions.
        /// ? - Letter or space. Restricts input to letters a-z and A-Z. This rule is equivalent to [a-zA-Z] in regular expressions.
        /// & - Character. Accepts any character. The rule is equivalent to \S in regular expressions.
        /// C - Character or space. Accepts any character. The rule is equivalent to . in regular expressions.
        /// A - Alphanumeric. Accepts letters and digits only.
        /// a - Alphanumeric or space. Accepts letters, digits and space only.
        /// . - Decimal placeholder. The decimal separator will be get from the current culture used by Kendo.
        /// , - Thousands placeholder. The display character will be get from the current culture used by Kendo.
        /// $ - Currency symbol. The display character will be get from the current culture used by Kendo.
        /// </summary>
        /// <returns></returns>
        public ActionResult mask()
        {
            return View();
        }

        /// <summary>
        /// promptChar String(default: "_")
        /// Specifies the character used to represent the absence of user input in the widget
        /// Note that the promptChar should not be equal to any of the used mask literals in the mask value.
        /// </summary>
        /// <returns></returns>
        public ActionResult promptChar()
        {
            return View();
        }

        /// <summary>
        /// rules Object
        /// Defines an object of custom mask rules.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_a_custom_rule_as_a_RegExp_instance()
        {
            return View();
        }

        public ActionResult specify_a_custom_rule_as_a_function()
        {
            return View();
        }

        public ActionResult specify_value_option()
        {
            return View();
        }

        public ActionResult specify_value_option_as_a_HTML_attribute()
        {
            return View();
        }

        /// <summary>
        /// An object, which holds the options of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_options_of_the_widget()
        {
            return View();
        }

        /// <summary>
        /// Prepares the MaskedTextBox for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks.
        /// Important: This method does not remove the MaskedTextBox element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }


        /// <summary>
        /// Enables or disables the widget.
        /// Parameters
        /// enable Boolean
        /// If set to true the widget will be enabled. If set to false the widget will be disabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_the_widget()
        {
            return View();
        }

        /// <summary>
        /// readonly
        /// Toggles the readonly state of the widget. When the widget is readonly it doesn't allow user input.
        /// There is a difference between disabled and readonly mode. The value of a disabled widget is not posted as part of a form whereas the value of a readonly widget is posted.
        /// Parameters
        /// readonly Boolean
        /// If set to true the widget will not allow user input. If set to false the widget will allow user input.
        /// </summary>
        /// <returns></returns>
        public ActionResult make_the_widget_readonly()
        {
            return View();
        }

        /// <summary>
        /// value
        /// Gets or sets the value of the maskedtextbox.
        /// Parameters
        /// value String
        /// The value to set.
        /// Returns
        /// String The value of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_value_of_the_maskedtextbox()
        {
            return View();
        }

        public ActionResult set_the_value_of_the_maskedtextbox()
        {
            return View();
        }

        /// <summary>
        /// change
        /// Fires when the value is changed
        /// Event Data
        /// e.sender kendo.ui.MaskedTextBox
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



	}
}