using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_MenuController : Controller
    {
      
        /// <summary>
        /// A collection of Animation objects, used to change default animations. A value of false will disable all animations in the widget.
        /// Available animations for the Menu are listed below. 
        /// Each animation has a reverse options which is used for the close effect by default,
        /// but can be over-ridden by setting the close animation.
        /// Each animation also has a direction which can be set off the animation (i.e. slideIn:Down).
        /// slideIn
        /// Menu content slides in from the top
        /// fadeIn
        /// Menu content fades in
        /// expand
        /// Menu content expands from the top down. Similar to slideIn.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation()
        {
            return View();
        }

        /// <summary>
        /// The animation that will be used when closing sub menus.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_close()
        {
            return View();
        }

        /// <summary>
        /// Effect to be used for closing of the popup.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_close_effects()
        {
            return View();
        }

        /// <summary>
        /// Defines the animation duration in milliseconds.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_close_duration()
        {
            return View();
        }

        /// <summary>
        /// The animation that will be used when opening sub menus.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open()
        {
            return View();
        }

        /// <summary>
        /// Effect to be used for opening of the popup
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open_effects()
        {
            return View();
        }

        /// <summary>
        /// Defines the animation duration in milliseconds.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open_duration()
        {
            return View();
        }

        /// <summary>
        /// Specifies that sub menus should close after item selection (provided they won't navigate).
        /// </summary>
        /// <returns></returns>
        public ActionResult closeOnClick()
        {
            return View();
        }

        /// <summary>
        /// dataSource Object|Array
        /// The data source of the widget which is used to render its items.
        /// Can be a JSON object/Array that contains an item or an Array of items to be rendered.
        /// Refer to the example below for a list of the supported properties.
        /// </summary>
        /// <returns></returns>
        public ActionResult dataSource()
        {
            return View();
        }

        /// <summary>
        /// direction String(default: "default")
        /// Specifies Menu opening direction.
        /// Can be "top", "bottom", "left", "right".
        /// You can also specify different direction for root and sub menu items, separating them with space.
        /// The example below will initialize the root menu to open upwards and its sub menus to the left.
        /// </summary>
        /// <returns></returns>
        public ActionResult direction()
        {
            return View();
        }

        /// <summary>
        /// hoverDelay Number(default: 100)
        /// Specifies the delay in ms before the menu is opened/closed - used to avoid accidental closure on leaving.
        /// </summary>
        /// <returns></returns>
        public ActionResult hoverDelay()
        {
            return View();
        }

        /// <summary>
        /// openOnClick Boolean(default: false)
        /// Specifies that the root sub menus will be opened on item click.
        /// </summary>
        /// <returns></returns>
        public ActionResult openOnClick()
        {
            return View();
        }

        /// <summary>
        /// orientation String(default: "horizontal")
        /// Root menu orientation. Could be horizontal or vertical.
        /// </summary>
        /// <returns></returns>
        public ActionResult orientation()
        {
            return View();
        }

        /// <summary>
        /// Specifies how Menu should adjust to screen boundaries.
        /// By default the strategy is "fit" for a sub menu with a horizontal parent,
        /// meaning it will move to fit in screen boundaries in all directions,
        /// and "fit flip" for a sub menu with vertical parent,
        /// meaning it will fit vertically and flip over its parent horizontally.
        /// You can also switch off the screen boundary detection completely if you set the popupCollision to false.
        /// </summary>
        /// <returns></returns>
        public ActionResult popupCollision()
        {
            return View();
        }

        /// <summary>
        /// Appends an item to a Menu in the specified referenceItem's sub menu.
        /// Parameters
        /// item Object|Array
        /// Item to be appended, specified as a JSON object. An array of objects can also be passed.
        /// referenceItem String|jQuery
        /// A reference item to append the new item in.
        /// Returns
        /// kendo.ui.Menu Returns the Menu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult append()
        {
            return View();
        }

        /// <summary>
        /// Closes a sub-menu of a specified item(s) in a Menu.
        /// Parameters
        /// element String|Element|jQuery
        /// Target item selector.
        /// Returns
        /// kendo.ui.Menu Returns the Menu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult close()
        {
            return View();
        }

        /// <summary>
        /// Prepares the Menu for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// Important: This method does not remove the Menu element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// Enables or disables an item of a Menu. 
        /// This can optionally be accomplished on initialization by setting the disabled="disabled" on the desired menu item html element.
        /// Parameters
        /// element String|Element|jQuery
        /// Target element
        /// enable Boolean
        /// Desired state
        /// Returns
        /// kendo.ui.Menu Returns the Menu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        /// <summary>
        /// Inserts an item into a Menu after the specified referenceItem.
        /// Parameters
        /// item String|Element|jQuery
        /// Target item, specified as a JSON object. Can also handle an array of such objects.
        /// referenceItem String|Element|jQuery
        /// A reference item to insert the new item after.
        /// Returns
        /// kendo.ui.Menu Returns the Menu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult insertAfter()
        {
            return View();
        }

        /// <summary>
        /// Inserts an item into a Menu before the specified referenceItem.
        /// Parameters
        /// item String|Element|jQuery
        /// Target item, specified as a JSON object. Can also handle an array of such objects.
        /// referenceItem String|Element|jQuery
        /// A reference item to insert the new item before
        /// Returns
        /// kendo.ui.Menu Returns the Menu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult insertBefore()
        {
            return View();
        }

        /// <summary>
        /// Opens a sub-menu of a specified item(s) in a Menu.
        /// Parameters
        /// element String|Element|jQuery
        /// Target item selector.
        /// Returns
        /// kendo.ui.Menu Returns the Menu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult open()
        {
            return View();
        }

        /// <summary>
        /// Removes a specified item(s) from a Menu.
        /// Parameters
        /// element String|Element|jQuery
        /// Target item selector.
        /// Returns
        /// kendo.ui.Menu Returns the Menu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult remove()
        {
            return View();
        }

        /// <summary>
        /// Fires before a sub menu gets closed. You can cancel this event to prevent closure.
        /// Event Data
        /// e.item Element
        /// The closed item
        /// </summary>
        /// <returns></returns>
        public ActionResult close_event()
        {
            return View();
        } 

        public ActionResult close_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fires before a sub menu gets opened. You can cancel this event to prevent opening the sub menu.
        /// Event Data
        /// e.item Element
        /// The opened item
        /// </summary>
        /// <returns></returns>
        public ActionResult open_event()
        {
            return View();
        }

        public ActionResult opent_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fires when a sub menu gets opened and its animation finished.
        /// Event Data
        /// e.item Element
        /// The activated item
        /// </summary>
        /// <returns></returns>
        public ActionResult activate()
        {
            return View();
        }

        public ActionResult activate_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fires when a sub menu gets closed and its animation finished.
        /// Event Data
        /// e.item Element
        /// The deactivated item
        /// </summary>
        /// <returns></returns>
        public ActionResult deactivate_event()
        {
            return View();
        }

        public ActionResult deactivate_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fires when a menu item gets selected.
        /// Event Data
        /// e.item Element
        /// The selected item
        /// </summary>
        /// <returns></returns>
        public ActionResult select_event()
        {
            return View();
        }

        public ActionResult select_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to create a Split Button using Kendo UI Menu.
        /// </summary>
        /// <returns></returns>
        public ActionResult Creating_Split_Button()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to execute a custom click action based on the class name of the clicked item.
        /// </summary>
        /// <returns></returns>
        public ActionResult Execute_custom_action_on_click_based_on_class_name()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to include custom FontAwesome icons in the Kendo UI Menu
        /// </summary>
        /// <returns></returns>
        public ActionResult Using_FontAwesome_icons_for_Kendo_UI_Menu()
        {
            return View();
        }

        public ActionResult Initializ_a_Kendo_UI_ContextMenu_using_HTML_markup()
        {
            return View();
        }

        public ActionResult Initialize_a_Kendo_UI_ContextMenu_using_JSON_data_object()
        {
            return View();
        }

        public ActionResult Change_ContextMenu_animation_and_open_event()
        {
            return View();
        }

        public ActionResult How_to_add_a_new_root_ContextMenu_item()
        {
            return View();
        }
	}
}