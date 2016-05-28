using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_ContextMenuController : Controller
    {
        /// <summary>
        /// alignToAnchor Boolean(default: false)
        /// Specifies that ContextMenu should be shown aligned to the target or the filter element if specified.
        /// </summary>
        /// <returns></returns>
        public ActionResult alignToAnchor()
        {
            return View();
        }

        /// <summary>
        /// animation Object
        /// A collection of Animation objects, used to change default animations. A value of false will disable all animations in the widget.
        /// Available animations for the ContextMenu are listed below. Each animation has a reverse options which is used for the close effect by default, but can be over-ridden by setting the close animation. Each animation also has a direction which can be set off the animation (i.e. slideIn:Down).
        /// slideIn
        /// ContextMenu content slides in from the top.
        /// fadeIn
        /// ContextMenu content fades in.
        /// expand
        /// ContextMenu content expands from the top down. Similar to slideIn.
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
        /// animation.close.effects String
        /// Effect to be used when closing the popup.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_close_effects()
        {
            return View();
        }

        /// <summary>
        /// animation.close.duration Number
        /// Defines the close animation duration in milliseconds.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_close_duration()
        {
            return View();
        }

        /// <summary>
        /// animation.open Object
        /// The animation that will be used when opening sub menus.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open()
        {
            return View();
        }

        /// <summary>
        /// animation.open.effects String
        /// Effect to be used when opening the popup.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open_effects()
        {
            return View();
        }

        /// <summary>
        /// animation.open.duration Number
        /// Defines the open animation duration in milliseconds.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open_duration()
        {
            return View();
        }

        /// <summary>
        /// closeOnClick Boolean(default: true)
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
        /// Specifies ContextMenu's sub menu opening direction. Can be "top", "bottom", "left", "right".
        /// The example below will initialize the sub menus to open to the left.
        /// </summary>
        /// <returns></returns>
        public ActionResult direction()
        {
            return View();
        }

        /// <summary>
        /// filter String
        /// Specifies ContextMenu filter selector - the ContextMenu will only be shown on items that satisfy the provided selector.
        /// </summary>
        /// <returns></returns>
        public ActionResult filter()
        {
            return View();
        }

        /// <summary>
        /// hoverDelay Number(default: 100)
        /// Specifies the delay in ms before the sub menus are opened/closed - used to avoid accidental closure on leaving.
        /// </summary>
        /// <returns></returns>
        public ActionResult hoverDelay()
        {
            return View();
        }

        /// <summary>
        /// orientation String(default: "vertical")
        /// Root menu orientation. Could be horizontal or vertical.
        /// </summary>
        /// <returns></returns>
        public ActionResult orientation()
        {
            return View();
        }

        /// <summary>
        /// popupCollision String
        /// Specifies how ContextMenu should adjust to screen boundaries.
        /// By default the strategy is "fit" for a sub menu with a horizontal parent or the root menu,
        /// meaning it will move to fit in screen boundaries in all directions, and "fit flip" for a sub menu with vertical parent,
        /// meaning it will fit vertically and flip over its parent horizontally.
        /// You can also switch off the screen boundary detection completely if you set the popupCollision to false.
        /// </summary>
        /// <returns></returns>
        public ActionResult popupCollision()
        {
            return View();
        }

        /// <summary>
        /// Specifies the event or events on which ContextMenu should open.
        /// By default ContextMenu will show on contextmenu event on desktop and hold event on touch devices.
        /// Could be any pointer/mouse/touch event, also several, separated by spaces.
        /// </summary>
        /// <returns></returns>
        public ActionResult showOn()
        {
            return View();
        }

        /// <summary>
        /// target String|jQuery(default: "body")
        /// Specifies the element on which ContextMenu should open. The default element is the document body.
        /// </summary>
        /// <returns></returns>
        public ActionResult target()
        {
            return View();
        }

        /// <summary>
        /// append
        /// Appends an item to a ContextMenu in the specified referenceItem's sub menu (or the root context menu if not specified).
        /// Parameters
        /// item Object|Array
        /// Item to be appended, specified as a JSON object. An array of objects can also be passed.
        /// referenceItem String|jQuery
        /// A reference item to append the new item in. Root context menu if not specified.
        /// Returns
        /// kendo.ui.ContextMenu Returns the ContextMenu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult append()
        {
            return View();
        }

        /// <summary>
        /// close
        /// Closes the ContextMenu. This method can be prevented to stop the closure.
        /// Parameters
        /// element Element|jQuery
        /// If called without arguments, will close the ContextMenu. If passed an item, it will be closed (if opened).
        /// Returns
        /// kendo.ui.ContextMenu Returns the ContextMenu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult close()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Prepares the ContextMenu for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks.
        /// Calls destroy method of any child Kendo widgets.
        /// Important: This method does not remove the ContextMenu element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enables or disables an item of a ContextMenu.
        /// This can optionally be accomplished on initialization by setting the disabled="disabled" on the desired menu item html element.
        /// Parameters
        /// element String|Element|jQuery
        /// Target element
        /// enable Boolean
        /// Desired state
        /// Returns
        /// kendo.ui.ContextMenu Returns the ContextMenu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        /// <summary>
        /// insertAfter
        /// Inserts an item into a ContextMenu after the specified referenceItem.
        /// Parameters
        /// item String|Element|jQuery
        /// Target item, specified as a JSON object. Can also handle an array of such objects.
        /// referenceItem String|Element|jQuery
        /// A reference item to insert the new item after.
        /// Returns
        /// kendo.ui.ContextMenu Returns the ContextMenu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult insertAfter()
        {
            return View();
        }

        /// <summary>
        /// insertBefore
        /// Inserts an item into a ContextMenu before the specified referenceItem.
        /// Parameters
        /// item String|Element|jQuery
        /// Target item, specified as a JSON object. Can also handle an array of such objects.
        /// referenceItem String|Element|jQuery
        /// A reference item to insert the new item before
        /// Returns
        /// kendo.ui.ContextMenu Returns the ContextMenu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult insertBefore()
        {
            return View();
        }

        /// <summary>
        /// open
        /// Shows the ContextMenu at the specified coordinates in pixels or aligned to the specified anchor.
        /// If passed an item, it will be opened. This method can be prevented to stop the ContextMenu from opening.
        /// Parameters
        /// x Number|Element|jQuery
        /// X coordinate in pixels or the anchor element to which to align. If passed an item - jQuery object or element - it will be opened.
        /// y Number
        /// Y coordinate in pixels. If not specified, ContextMenu will assume the first parameter is an anchor element.
        /// Returns
        /// kendo.ui.ContextMenu Returns the ContextMenu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult open()
        {
            return View();
        }

        /// <summary>
        /// remove
        /// Removes a specified item(s) from a ContextMenu.
        /// Parameters
        /// element String|Element|jQuery
        /// Target item selector.
        /// Returns
        /// kendo.ui.ContextMenu Returns the ContextMenu object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult remove()
        {
            return View();
        }

        /// <summary>
        /// close
        /// Fires before a sub menu or the ContextMenu gets closed. You can cancel this event to prevent closure.
        /// Event Data
        /// e.item Element
        /// The closed item
        /// e.type String
        /// The event type as a string - "close".
        /// e.target Element
        /// The current target of the ContextMenu - either the init target or the current element chosen through filter, if specified.
        /// e.event jQuery.Event
        /// The jQuery event that triggered this one - only available for the close event of the whole ContextMenu and not for its items.
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
        /// open
        /// Fires before a sub menu or the ContextMenu gets opened. You can cancel this event to prevent opening the sub menu.
        /// Event Data
        /// e.item Element
        /// The opened item
        /// e.type String
        /// The event type as a string - "open".
        /// e.target Element
        /// The current target of the ContextMenu - either the init target or the current element chosen through filter, if specified.
        /// e.event jQuery.Event
        /// The jQuery event that triggered this one - only available for the open event of the whole ContextMenu and not for its items.
        /// </summary>
        /// <returns></returns>
        public ActionResult open_event()
        {
            return View();
        }

        public ActionResult open_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// activate
        /// Fires when a sub menu or the ContextMenu gets opened and its animation finished.
        /// Event Data
        /// e.item Element
        /// The activated item
        /// e.type String
        /// The event type as a string - "activate".
        /// e.target Element
        /// The current target of the ContextMenu - either the init target or the current element chosen through filter, if specified.
        /// </summary>
        /// <returns></returns>
        public ActionResult activate_event()
        {
            return View();
        }

        public ActionResult activate_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// deactivate
        /// Fires when a sub menu or the ContextMenu gets closed and its animation finished.
        /// Event Data
        /// e.item Element
        /// The deactivated item
        /// e.type String
        /// The event type as a string - "deactivate".
        /// e.target Element
        /// The current target of the ContextMenu - either the init target or the current element chosen through filter, if specified.
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
        /// select
        /// Fires when a menu item gets selected.
        /// Event Data
        /// e.item Element
        /// The selected item
        /// e.type String
        /// The event type as a string - "select".
        /// e.target Element
        /// The current target of the ContextMenu - either the init target or the current element chosen through filter, if specified.
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



    }
}