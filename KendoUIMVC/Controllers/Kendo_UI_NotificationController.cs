using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_NotificationController : Controller
    {
        /// <summary>
        /// allowHideAfter Number (default: 0)
        /// Indicates the period in milliseconds after which a notification can be dismissed (hidden) by the user.
        /// </summary>
        /// <returns></returns>
        public ActionResult allowHideAfter()
        {
            return View();                 
        }

        /// <summary>
        /// animation Object|Boolean
        /// Defines custom show and hide animations via an Kendo UI Animation object. Setting the value to false disables animations.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_animations()
        {
            return View();
        }

        public ActionResult slide_animations()
        {
            return View();
        }

        /// <summary>
        /// appendTo String|Element|jQuery (default: null)
        /// Defines the element to which the notifications will be appended or prepended (depending on the stacking direction).
        /// </summary>
        /// <returns></returns>
        public ActionResult set_appendTo_as_a_selector_string()
        {
            return View();
        }

        public ActionResult set_appendTo_as_a_DOM_element()
        {
            return View();
        }

        public ActionResult set_appendTo_as_a_jQuery_object()
        {
            return View();
        }

        /// <summary>
        /// autoHideAfter Number (default: 5000)
        ///Indicates the period in milliseconds after which a notification disappears automatically.
        ///Setting a zero value disables this behavior.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_autoHideAfter_to_3_seconds()
        {
            return View();
        }

        public ActionResult disable_automatic_hiding()
        {
            return View();
        }

        /// <summary>
        /// button Boolean (default: false)
        /// Determines whether the notifications will include a hide button.
        /// This setting works with the built-in templates only.
        /// </summary>
        /// <returns></returns>
        public ActionResult button()
        {
            return View();
        }

        /// <summary>
        /// height Number|String (default: null)
        /// Defines the notifications' height. Numbers are treated as pixels.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_height_as_a_number()
        {
            return View();
        }

        public ActionResult set_height_as_a_string()
        {
            return View();
        }

        /// <summary>
        /// hideOnClick Boolean (default: true)
        /// Determines whether notifications can be hidden by clicking anywhere on their content.
        /// </summary>
        /// <returns></returns>
        public ActionResult hideOnClick()
        {
            return View();
        }

        /// <summary>
        /// position Object
        /// This setting applies to popup notifications only, i.e.
        /// in cases when appendTo is not set.
        /// It determines the position of the first notification on the screen,
        /// as well as whether the notifications will move together with the page content during scrolling.
        /// top takes precedence over bottom and left takes precedence over right.
        /// </summary>
        /// <returns></returns>
        public ActionResult Default_position_settings()
        {
            return View();
        }

        /// <summary>
        /// position.bottom Number (default: 20)
        /// Determines the pixel position of the first popup notification with regard to the viewport's bottom edge.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_position_bottom()
        {
            return View();
        }

        /// <summary>
        /// position.left Number (default: null)
        /// Determines the pixel position of the first popup notification with regard to the viewport's left edge.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_position_left()
        {
            return View();
        }

        /// <summary>
        /// position.pinned Boolean (default: true)
        /// Determines whether the popup notifications will move together with the other page content during scrolling.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_pinned_notifications()
        {
            return View();
        }

        /// <summary>
        /// position.right Number (default: 20)
        /// Determines the pixel position of the first popup notification with regard to the viewport's right edge.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_position_right()
        {
            return View();
        }

        /// <summary>
        /// position.top Number (default: null)
        /// Determines the position of the first popup notification with regard to the viewport's top edge.
        /// Numeric values are treated as pixels.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_position_top()
        {
            return View();
        }

        /// <summary>
        /// stacking String (default: "default")
        /// Determines the direction in which multiple notification will stack (arrange) with regard to the first one.
        /// Possible values are "up", "right", "down", "left" and "default".
        /// The "default" setting takes into consideration the applied position settings and is evaluated to "up" or "down".
        /// </summary>
        /// <returns></returns>
        public ActionResult stacking()
        {
            return View();
        }

        /// <summary>
        /// templates Array (default: [])
        /// Describes the HTML markup of the different notification types as Kendo UI template strings. The built-in types are "info", "success", "warning" and "error".
        /// templates.type String (default: "")
        /// Required. Specified a unique identifier, which is used to retrieve the correct template when a notification of this type is shown.
        /// templates.template String (default: "")
        /// Defines a Kendo UI template to be used with the corresponding notification type.
        /// </summary>
        /// <returns></returns>
        public ActionResult templates()
        {
            return View();
        }

        /// <summary>
        /// width Number|String (default: null)
        /// Defines the notifications' width. Numbers are treated as pixels.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_width_as_a_number()
        {
            return View();
        }

        public ActionResult set_width_as_a_string()
        {
            return View();
        }

        /// <summary>
        /// getNotifications
        /// Returns a jQuery collection of all visible notifications, displayed by the given widget instance.
        /// Each item in the collection is a div.k-notification element.
        /// Returns
        /// jQuery A collection of all visible notifications.
        /// </summary>
        /// <returns></returns>
        public ActionResult getNotifications()
        {
            return View();
        }

        /// <summary>
        /// hide
        /// Hides all notifications from the given widget instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult hide()
        {
            return View();
        }

        /// <summary>
        /// show
        /// Displays a notification.
        /// Parameters
        /// data Object|String|Function
        /// Required. The string content for the notification; or the object with the values for the variables inside the notification template; or the function, which returns the required string or an object.
        /// type String
        /// The notification type. Built-in types include "info", "success", "warning" and "error".
        /// Custom types should match the types from the template configuration. If this argument is not supplied, then "info" is assumed.
        /// </summary>
        /// <returns></returns>
        public ActionResult use_the_show_method_with_a_string_argument()
        {
            return View();
        }

        public ActionResult use_the_show_method_with_an_object_argument()
        {
            return View();
        }


        public ActionResult use_the_show_method_with_a_function_argument()
        {
            return View();
        }

        /// <summary>
        /// hide
        /// Fires when a notification's hiding animation starts.
        /// Event Data
        /// e.element jQuery
        /// The jQuery object, which wraps the element being hidden.
        /// </summary>
        /// <returns></returns>
        public ActionResult hide_event()
        {
            return View();
        }

        /// <summary>
        /// show
        /// Fires when a notification's showing animation starts.
        /// Event Data
        /// e.element jQuery
        /// The jQuery object, which wraps the element being displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult show_event()
        {
            return View();
        }

        /// <summary>
        /// The following demo shows how to stack static notifications to the left or to the right
        /// </summary>
        /// <returns></returns>
        public ActionResult Stack_static_notifications_to_the_left_or_right()
        {
            return View();
        }



    }
}