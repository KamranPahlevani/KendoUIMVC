using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_ButtonController : Controller
    {
        // GET: Kendo_UI_Button
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// enable Boolean (default: true)
        /// ndicates whether the Button should be enabled or disabled. By default, it is enabled, unless a disabled="disabled" attribute is detected.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        /// <summary>
        /// Defines a name of an existing icon in the Kendo UI theme sprite.
        /// The icon will be applied as background image of a span element inside the Button.
        /// The span element can be added automatically by the widget, or an existing element can be used,
        /// if it has a k-icon CSS class applied. For a list of available icon names, please refer to the Icons demo.
        /// </summary>
        /// <returns></returns>
        public ActionResult icon()
        {
            return View();
        }

        public ActionResult icon_Example_with_an_existing_span_element()
        {
            return View();
        }

        /// <summary>
        /// imageUrl String
        /// Defines a URL, which will be used for an img element inside the Button.
        /// The URL can be relative or absolute. In case it is relative, it will be evaluated with relation to the web page URL.
        /// The img element can be added automatically by the widget, or an existing element can be used, if it has a k-image CSS class applied.
        /// </summary>
        /// <returns></returns>
        public ActionResult imageUrl()
        {
            return View();
        }

        public ActionResult imageUrl_Example_with_an_existing_img_element()
        {
            return View();
        }

        /// <summary>
        /// spriteCssClass String
        /// Defines a CSS class (or multiple classes separated by spaces), which will be used for applying a background image to a span element inside the Button.
        /// In case you want to use an icon from the Kendo UI theme sprite background image, it is easier to use the icon property.
        /// The span element can be added automatically by the widget, or an existing element can be used, if it has a k-sprite CSS class applied.
        /// </summary>
        /// <returns></returns>
        public ActionResult spriteCssClass()
        {
            return View();
        }

        public ActionResult spriteCssClass_Example_with_an_existing_span_element()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enables or disables the Button.
        /// Parameters
        /// toggle Boolean
        /// Indicates whether the Button should be enabled or disabled. true and false arguments are accepted.
        /// If no argument is supplied, the Button will assume true and will be enabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_method() 
        {
            return View();
        }

        /// <summary>
        /// Fires when the Button is clicked with the mouse, touched on a touch device, or ENTER (or SPACE) is pressed while the Button is focused.
        /// Event Data
        /// e.event Object
        /// The original DOM event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_click_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_click_event_after_initialization()
        {
            return View();
        }


    }
}