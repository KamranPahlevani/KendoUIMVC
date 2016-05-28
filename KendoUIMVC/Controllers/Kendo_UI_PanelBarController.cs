using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_PanelBarController : Controller
    {
        // GET: Kendo_UI_PanelBar

        /// <summary>
        /// animation Object|Boolean
        /// A collection of visual animations used when PanelBar items are expand or collapsed through user interactions.
        /// Setting this option to false will disable all animations.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation()
        {
            return View();
        }

        /// <summary>
        /// animation.collapse Object
        /// The visual animation(s) that will be used when PanelBar items are closed.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_collapse()
        {
            return View();
        }

        /// <summary>
        /// animation.collapse.duration Number(default: 200)
        /// The number of milliseconds used for the visual animation when a PanelBar item is closed.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_collapse_duration()
        {
            return View();
        }

        /// <summary>
        /// animation.collapse.effects String
        /// A whitespace-delimited string of animation effects that are utilized when a PanelBar item is closed.
        /// Options include "fadeOut".
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_collapse_effects()
        {
            return View();
        }

        /// <summary>
        /// animation.expand Object
        /// The visual animation(s) that will be used when opening items.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_expand()
        {
            return View();
        }

        /// <summary>
        /// animation.expand.duration Number(default: 200)
        /// The number of milliseconds used for the visual animation when an item is opened.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_expand_duration()
        {
            return View();
        }

        /// <summary>
        /// animation.expand.effects String(default: "expandVertical")
        /// A whitespace-delimited string of animation effects that are used when an item is expanded.
        /// Options include "expandVertical" and "fadeIn".
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_expand_effects()
        {
            return View();
        }

        /// <summary>
        /// contentUrls Array
        /// Sets an array with the URLs from which the PanelBar items content to be loaded from.
        /// If only specific items should be loaded via Ajax,
        /// then you should set the URLs to the corresponding positions in the array and set the other elements to null.
        /// </summary>
        /// <returns></returns>
        public ActionResult contentUrls()
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
        /// expandMode String(default: "multiple")
        /// Specifies how the PanelBar items are displayed when opened and closed. The following values are available:
        /// "single"
        /// Display one item at a time when an item is opened; opening an item will close the previously opened item.
        /// "multiple"
        /// Display multiple values at one time; opening an item has no visual impact on any other items in the PanelBar.
        /// </summary>
        /// <returns></returns>
        public ActionResult expandMode()
        {
            return View();
        }

        /// <summary>
        /// append
        /// Appends an item(s) to the PanelBar.
        /// Parameters
        /// item String|Element|jQuery|Array
        /// Target item, specified as the JSON representation of an object. You can pass item text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.
        /// referenceItem String|Element|jQuery
        /// A reference item to append the new item in the PanelBar, can be omitted.
        /// Returns
        /// kendo.ui.PanelBar Returns the PanelBar object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult append()
        {
            return View();
        }

        /// <summary>
        /// clearSelection
        /// Clears the currently selected PanelBar items.
        /// </summary>
        /// <returns></returns>
        public ActionResult clearSelection()
        {
            return View();
        }

        /// <summary>
        /// collapse
        /// Collapses the specified item(s) of a PanelBar.
        /// Parameters
        /// element String|Element|jQuery
        /// The PanelBar item(s) to be collapsed, expressed as a string containing a selector expression or represented by a jQuery selector.
        /// useAnimation Boolean
        /// _optional, default: _
        /// Temporarily enables (true) or disables (false) any visual animation(s) when collapsing items.
        /// Returns
        /// kendo.ui.PanelBar Returns the PanelBar object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult collapse()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Prepares the PanelBar for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// Important: This method does not remove the PanelBar element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enables (true) or disables (false) the specified item(s) of the PanelBar.
        /// Parameters
        /// element String|Element|jQuery
        /// The PanelBar item(s) to be enabled (true) or disabled (false), expressed as a string containing a selector expression or represented by a jQuery selector.
        /// enable Boolean
        /// The desired state - enabled (true) or disabled (false) - of the target element(s).
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        /// <summary>
        /// expand
        /// Expands the specified item(s) of a PanelBar.
        /// Parameters
        /// element String|Element|jQuery
        /// The PanelBar item(s) to be expanded, expressed as a selector.
        /// useAnimation Boolean
        /// _optional, default: _
        /// Temporarily enables (true) or disables (false) any visual animation(s) when expanding items.
        /// Returns
        /// kendo.ui.PanelBar Returns the PanelBar object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult expand_method()
        {
            return View();
        }

        /// <summary>
        /// insertAfter
        /// Inserts a PanelBar item after the specified referenceItem
        /// Parameters
        /// item String|Element|jQuery|Array
        /// Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.
        /// referenceItem String|Element|jQuery
        /// A reference item to insert the new item after
        /// </summary>
        /// <returns></returns>
        public ActionResult insertAfter()
        {
            return View();
        }

        /// <summary>
        /// insertBefore
        /// Inserts a PanelBar item before the specified referenceItem
        /// Parameters
        /// item String|Element|jQuery|Array
        /// Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an TML string or array of such strings or JSON.
        /// referenceItem String|Element|jQuery
        /// A reference item to insert the new item before.
        /// Returns
        /// kendo.ui.PanelBar Returns the PanelBar object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult insertBefore()
        {
            return View();
        }

        /// <summary>
        /// reload
        /// Reloads the content of a PanelBar from an AJAX request.
        /// Parameters
        /// element String|Element|jQuery
        /// Target element
        /// </summary>
        /// <returns></returns>
        public ActionResult reload()
        {
            return View();
        }

        /// <summary>
        /// remove
        /// Removes the specified PanelBar item(s).
        /// Parameters
        /// element String|Element|jQuery
        /// The PanelBar item(s) to be removed, expressed as a selector string, DOM element or a jQuery object.
        /// </summary>
        /// <returns></returns>
        public ActionResult remove_method()
        {
            return View();
        }

        /// <summary>
        /// select
        /// Gets or sets the selected item.
        /// Parameters
        /// element String|Element|jQuery (optional)
        /// The PanelBar item to be selected, expressed as a string containing a selector expression or represented by a jQuery selector.
        /// Returns
        /// jQuery the selected item if called without arguments. kendo.ui.PanelBar if called with arguments.
        /// </summary>
        /// <returns></returns>
        public ActionResult select()
        {
            return View();
        }

        /// <summary>
        /// activate
        /// Triggered when an item of a PanelBar is activated.
        /// Event Data
        /// e.item Element
        /// The activated item of the PanelBar.
        /// </summary>
        /// <returns></returns>
        public ActionResult Attach_activate_event_handler_during_initialization_detach_via_unbind()
        {
            return View();
        }

        public ActionResult Attach_activate_event_handler_via_bind_detach_via_unbind()
        {
            return View();
        }

        /// <summary>
        /// collapse
        /// Triggered when an item of a PanelBar is collapsed.
        /// Event Data
        /// e.item Element
        /// The collapsing item of the PanelBar.
        /// </summary>
        /// <returns></returns>
        public ActionResult Attach_collapse_event_handler_during_initialization_detach_via_unbind()
        {
            return View();
        }

        public ActionResult Attach_collapse_event_handler_via_bind_detach_via_unbind()
        {
            return View();
        }

        /// <summary>
        /// contentLoad
        /// Fires when content is fetched from an AJAX request.
        /// Event Data
        /// e.item Element
        /// The selected item
        /// e.contentElement Element
        /// The loaded content element
        /// </summary>
        /// <returns></returns>
        public ActionResult contentLoad_event()
        {
            return View();
        }

        public ActionResult contentLoad_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// error
        /// Fires when AJAX request results in an error.
        /// Event Data
        /// e.xhr jqXHR
        /// The jqXHR object used to load the content
        /// e.status String
        /// The returned status.
        /// </summary>
        /// <returns></returns>
        public ActionResult error_event()
        {
            return View();
        }

        public ActionResult error_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// expand
        /// Triggered when an item of a PanelBar is expanded.
        /// Event Data
        /// e.item Element
        /// The expanding item of the PanelBar.
        /// </summary>
        /// <returns></returns>
        public ActionResult Attach_expand_event_handler_during_initialization_detach_via_unbind()
        {
            return View();
        }

        public ActionResult Attach_expand_event_handler_via_bind_detach_via_unbind()
        {
            return View();
        }

        /// <summary>
        /// select
        /// Triggered when an item of a PanelBar is selected.
        /// Event Data
        /// e.item Element
        /// The selected item of the PanelBar.
        /// </summary>
        /// <returns></returns>
        public ActionResult Attach_select_event_handler_during_initialization_detach_via_unbind()
        {
            return View();
        }

        public ActionResult Attach_select_event_handler_via_bind_detach_via_unbind()
        {
            return View();
        }



    }
}