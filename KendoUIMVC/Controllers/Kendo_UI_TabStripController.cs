using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_TabStripController : Controller
    {
        // GET: Kendo_UI_TabStrip

        /// <summary>
        /// animation Object|Boolean
        /// A collection of visual animations used when TabStrip tab are selected through user interactions.
        /// Setting this option to false will disable all animations.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation()
        {
            return View();
        }

        /// <summary>
        /// animation.close Object
        /// The visual animation(s) that will be used when the current tab is closed.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_close()
        {
            return View();
        }

        /// <summary>
        /// animation.close.duration Number(default: 200)
        /// The number of milliseconds used for the visual animation when the current tab is closed.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_close_duration()
        {
            return View();
        }

        /// <summary>
        /// animation.close.effects String
        /// A whitespace-delimited string of animation effects that are utilized when the current tab is closed.
        /// By default not specified - uses the opening animation with reverse.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_close_effects()
        {
            return View();
        }

        /// <summary>
        /// animation.open Object
        /// The visual animation(s) that will be used when the new tab is shown.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open()
        {
            return View();
        }

        /// <summary>
        /// animation.open.duration Number(default: 200)
        /// The number of milliseconds used for the visual animation when a new tab is shown.
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open_duration()
        {
            return View();
        }

        /// <summary>
        /// animation.open.effects String(default: "expand:vertical fadeIn")
        /// A whitespace-separated string of animation effects that are used when a new tab is shown. Options include "expand:vertical" and "fadeIn".
        /// </summary>
        /// <returns></returns>
        public ActionResult animation_open_effects()
        {
            return View();
        }

        /// <summary>
        /// collapsible Boolean(default: false)
        /// Specifies whether the TabStrip should be able to collapse completely when clicking an expanded tab.
        /// </summary>
        /// <returns></returns>
        public ActionResult collapsible()
        {
            return View();
        }

        /// <summary>
        /// contentUrls Array
        /// Sets an array with the URLs from which the tabs content to be loaded from.
        /// If only specific tabs should be loaded via Ajax,
        /// then you should set the URLs to the corresponding positions in the array and set the other elements to null.
        /// </summary>
        /// <returns></returns>
        public ActionResult contentUrls()
        {
            return View();
        }

        /// <summary>
        /// dataContentField String(default: "")
        /// Sets the field of the data item that provides the text content of the tab content element.
        /// </summary>
        /// <returns></returns>
        public ActionResult dataContentField()
        {
            return View();
        }

        /// <summary>
        /// dataContentUrlField String(default: "")
        /// Sets the field of the data item that provides the URL for the Ajax loaded tab content.
        /// </summary>
        /// <returns></returns>
        public ActionResult dataContentUrlField()
        {
            return View();
        }

        /// <summary>
        /// dataImageUrlField String(default: "")
        /// Sets the field of the data item that provides the image URL of the tab.
        /// </summary>
        /// <returns></returns>
        public ActionResult dataImageUrlField()
        {
            return View();
        }

        /// <summary>
        /// dataSpriteCssClass String(default: "")
        /// Sets the field of the data item that provides the CSS class of the tab.
        /// </summary>
        /// <returns></returns>
        public ActionResult dataSpriteCssClass()
        {
            return View();
        }

        /// <summary>
        /// dataTextField String(default: "")
        /// Sets the field of the data item that provides the text name of the tab.
        /// </summary>
        /// <returns></returns>
        public ActionResult dataTextField()
        {
            return View();
        }

        /// <summary>
        /// dataUrlField String(default: "")
        /// Sets the field of the data item that provides the link URL for the tab.
        /// </summary>
        /// <returns></returns>
        public ActionResult dataUrlField()
        {
            return View();
        }

        /// <summary>
        /// navigatable Boolean(default: true)
        /// Specifies whether the TabStrip should be keyboard navigatable.
        /// </summary>
        /// <returns></returns>
        public ActionResult navigatable()
        {
            return View();
        }

        /// <summary>
        /// activateTab
        /// Activates a tab specified as a selector. Note: Invoking this method will not trigger any events.
        /// Parameters
        /// item jQuery
        /// The target tab, specified as a selector, to be activated.
        /// </summary>
        /// <returns></returns>
        public ActionResult activateTab()
        {
            return View();
        }

        /// <summary>
        /// append
        /// Appends a tab to the collection of tabs in a TabStrip.
        /// Parameters
        /// tab Array|Object
        /// Target tab, specified as a JSON object. You can pass tab text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.
        /// Returns
        /// kendo.ui.TabStrip Returns the TabStrip object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult append()
        {
            return View();
        }

        /// <summary>
        /// contentElement
        /// Obtains the DOM element that encloses tab content by its tab index in the TabStrip.
        /// Important: To remove the tab contents safely, use contentHolder to get the element to empty.
        /// Parameters
        /// itemIndex Number
        /// The index of the tab in the TabStrip.
        /// Returns
        /// Element The DOM element enclosing tab content by its tab index in the TabStrip.
        /// </summary>
        /// <returns></returns>
        public ActionResult contentElement()
        {
            return View();
        }

        /// <summary>
        /// contentHolder
        /// Obtains the DOM element that holds tab content by its tab index in the TabStrip. The difference between contentElement and contentHolder is that contentHolder returns the DOM element that really holds the content, which on mobile is the scroll container.
        /// Important: To remove the tab contents safely, use this method to get the element to empty.
        /// Parameters
        /// itemIndex Number
        /// The index of the tab in the TabStrip.
        /// Returns
        /// Element The DOM element holding tab content by its tab index in the TabStrip.
        /// </summary>
        /// <returns></returns>
        public ActionResult contentHolder()
        {
            return View();
        }

        /// <summary>
        /// deactivateTab
        /// Deactivates a tab specified as a selector. Note: Invoking this method will not trigger any events.
        /// Parameters
        /// item jQuery
        /// The target tab, specified as a selector, to be deactivated.
        /// </summary>
        /// <returns></returns>
        public ActionResult deactivateTab()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Prepares the TabStrip for safe removal from DOM. Detaches all event handlers and removes jQuery.
        /// data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// Important: This method does not remove the TabStrip element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// disable
        /// Disables a tab(s) of a TabStrip.
        /// Parameters
        /// element String|Element|jQuery
        /// The target tab(s), specified as a selector, to be disabled.
        /// Returns
        /// kendo.ui.TabStrip Returns the TabStrip object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Disables (false) or enables (true) a tab(s) of a TabStrip.
        /// Parameters
        /// element String|Element|jQuery
        /// The target tab(s), specified as a selector, to be enabled (true) or disabled (false).
        /// enable Boolean (optional)
        /// Desired state of the tab(s) specified by the selector; enabled (true) or disabled (false).
        /// Returns
        /// kendo.ui.TabStrip Returns the TabStrip object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable()
        {
            return View();
        }

        /// <summary>
        /// insertAfter
        /// Inserts a newly-created tab after a specified tab.
        /// Parameters
        /// item String|Element|jQuery
        /// Target tab, specified as a JSON object. You can pass tab text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.
        /// referenceTab String|Element|jQuery
        /// A reference tab to insert the new item after.
        /// Returns
        /// kendo.ui.TabStrip Returns the TabStrip object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult insertAfter()
        {
            return View();
        }

        /// <summary>
        /// insertBefore
        /// Inserts a newly-created tab before a specified tab.
        /// Parameters
        /// item String|Element|jQuery
        /// Target tab, specified as a JSON object. You can pass tab text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.
        /// referenceTab String|Element|jQuery
        /// A reference tab to insert the new item before
        /// Returns
        /// kendo.ui.TabStrip Returns the TabStrip object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult insertBefore()
        {
            return View();
        }

        /// <summary>
        /// items
        /// Gets the list of DOM elements that represent the tabs.
        /// Returns
        /// HTMLCollection the tabs as an HTML collection of elements.
        /// </summary>
        /// <returns></returns>
        public ActionResult items()
        {
            return View();
        }

        /// <summary>
        /// reload
        /// Reloads TabStrip tab(s) via AJAX.
        /// Parameters
        /// element String|Element|jQuery
        /// The target tab(s), specified as a selector or jQuery object, to be reloaded via AJAX.
        /// Returns
        /// kendo.ui.TabStrip Returns the TabStrip object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult reload()
        {
            return View();
        }

        /// <summary>
        /// remove
        /// Removes a specified tab from a TabStrip.
        /// Parameters
        /// element String|Number
        /// The target tab(s), specified as a selector or jQuery object, to be removed.
        /// Returns
        /// kendo.ui.TabStrip Returns the TabStrip object to support chaining.
        /// </summary>
        /// <returns></returns>
        public ActionResult remove()
        {
            return View();
        }

        /// <summary>
        /// select
        /// Get/set the selected tab. If called without arguments, it returns the currently selected tab.
        /// Parameters
        /// element String|Element|jQuery|Number
        /// The target tab(s), specified as a selector, jQuery object or index in the tab group.
        /// Returns
        /// jQuery the selected tab if called without arguments. kendo.ui.TabStrip if called with arguments.
        /// </summary>
        /// <returns></returns>
        public ActionResult select()
        {
            return View();
        }

        /// <summary>
        /// Sets the data source of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult setDataSource()
        {
            return View();
        }

        /// <summary>
        /// activate
        /// Triggered after a tab is being made visible and its animation complete.
        /// Before Q2 2014 this event was invoked after tab show, but before the end of the animation.
        /// Event Data
        /// e.item Element
        /// The activated tab.
        /// e.contentElement Element
        /// The content element of the activated tab.
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
        /// contentLoad
        /// Triggered when content is fetched from an AJAX request.
        /// Event Data
        /// e.item Element
        /// The selected item
        /// e.contentElement Element
        /// The loaded content element that is retrieved via AJAX.
        /// </summary>
        /// <returns></returns>
        public ActionResult Attach_contentLoad_event_handler_during_initialization_detach_via_unbind()
        {
            return View();
        }

        /// <summary>
        /// error
        /// Triggered when an AJAX request results in an error.
        /// Event Data
        /// e.xhr jqXHR
        /// The jqXHR object used to load the content
        /// e.status String
        /// The returned status.
        /// </summary>
        /// <returns></returns>
        public ActionResult Attach_error_event_handler_during_initialization_detach_via_unbind()
        {
            return View();
        }

        /// <summary>
        /// select
        /// Triggered before a tab is selected.
        /// Event Data
        /// e.item Element
        /// The selected item chosen by a user.
        /// e.contentElement Element
        /// The content element of the tab going to be selected.
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

        /// <summary>
        /// show
        /// Triggered just after a tab is being made visible, but before the end of the animation. Before Q2 2014 this event was called activate.
        /// Event Data
        /// e.item Element
        /// The activated tab.
        /// e.contentElement Element
        /// The content element of the activated tab.
        /// </summary>
        /// <returns></returns>
        public ActionResult Attach_show_event_handler_during_initialization_detach_via_unbind()
        {
            return View();
        }

        public ActionResult Attach_show_event_handler_via_bind_detach_via_unbind()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to expand the tab heigh to 100% of the parent container.
        /// </summary>
        /// <returns></returns>
        public ActionResult Expand_the_tab_heigh_to_100_percent()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to display the tab buttons at the bottom of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult Display_tab_buttons_at_the_bottom()
        {
            return View();
        }

        public ActionResult Scroll_the_TabStrip_with_the_keyboard()
        {
            return View();
        }
    }
}