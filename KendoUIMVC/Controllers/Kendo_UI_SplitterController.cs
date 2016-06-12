using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_SplitterController : Controller
    {
        /// <summary>
        /// orientation String (default: "horizontal")
        /// Specifies the orientation of the widget. Supported values are "horizontal" and "vertical".
        /// </summary>
        /// <returns></returns>
        public ActionResult orientation()
        {
            return View();
        }

        /// <summary>
        /// panes.collapsed Boolean (default: false)
        /// Specifies whether a pane is initially collapsed (true) or expanded (true).
        /// </summary>
        /// <returns></returns>
        public ActionResult panes_collapsed()
        {
            return View();
        }

        /// <summary>
        /// panes.collapsedSize String
        /// Specifies the size of a collapsible pane when collapsed, defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").
        /// When the pane is collapsed a .k-state-collapsed class is added to it to ease its styling. Note: This value must not exceed panes.max or be less then panes.min.
        /// </summary>
        /// <returns></returns>
        public ActionResult panes_collapsedSize()
        {
            return View();
        }

        /// <summary>
        /// panes.collapsible Boolean (default: false)
        /// Specifies whether a pane is collapsible (true) or not collapsible (false)
        /// </summary>
        /// <returns></returns>
        public ActionResult panes_collapsible()
        {
            return View();
        }

        /// <summary>
        /// panes.contentUrl String
        /// Specifies the URL from which to load the content of a pane.
        /// </summary>
        /// <returns></returns>
        public ActionResult panes_contentUrl()
        {
            return View();
        }

        /// <summary>
        /// panes.max String
        /// Specifies the maximum size of a pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").
        /// The size of a resized pane cannot exceed the defined maximum size.
        /// </summary>
        /// <returns></returns>
        public ActionResult panes_max()
        {
            return View();
        }

        /// <summary>
        /// panes.min String
        /// Specifies the minimum size of a pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").
        /// The size of a resized pane cannot be less than the defined minimum size.
        /// </summary>
        /// <returns></returns>
        public ActionResult panes_min()
        {
            return View();
        }

        /// <summary>
        /// panes.resizable Boolean (default: true)
        /// Specifies whether a pane is resizable (true) or not resizable (false).
        /// </summary>
        /// <returns></returns>
        public ActionResult panes_resizable()
        {
            return View();
        }

        /// <summary>
        /// panes.scrollable Boolean (default: true)
        /// Specifies whether a pane is scrollable (true) or not scrollable (false).
        /// </summary>
        /// <returns></returns>
        public ActionResult panes_scrollable()
        {
            return View();
        }

        /// <summary>
        /// panes.size String
        /// Specifies the size of a pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").
        /// It is recommended that one pane is left without size in order to compensate for changes in the viewport size.
        /// Note: This value must not exceed panes.max or be less then panes.min.
        /// </summary>
        /// <returns></returns>
        public ActionResult panes_size()
        {
            return View();
        }

        /// <summary>
        /// ajaxRequest
        /// Loads the content of a pane from a local or remote URL.
        /// Parameters
        /// pane String|Element|jQuery
        /// The targeted pane whose content is to be loaded via a URL.
        /// url String
        /// A local or remote URL from which the content of the pane is to be loaded.
        /// data Object | String
        /// Any data that is necessary to be sent to the server.
        /// </summary>
        /// <returns></returns>
        public ActionResult ajaxRequest()
        {
            return View();
        }

        /// <summary>
        /// append
        /// Appends a new pane. The method returns the pane element, so it can be populated with arbitrary content,
        /// if contentUrl is not set. Invoking this method will force the widget to redraw and it will trigger the resize event.
        /// Parameters
        /// config Object (optional)
        /// The new pane configuration
        /// Returns
        /// jQuery the pane element.
        /// </summary>
        /// <returns></returns>
        public ActionResult append()
        {
            return View();
        }

        /// <summary>
        /// collapse
        /// Collapses a specified pane. Invoking this method will force the widget to redraw and it will trigger the resize event.
        /// Note: Invoking the method will not trigger a collapse event.
        /// Parameters
        /// pane String|Element|jQuery
        /// The pane to be collapsed.
        /// </summary>
        /// <returns></returns>
        public ActionResult collapse()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Prepares the widget for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks.
        /// Calls destroy method of any child Kendo widgets.
        /// Important: This method does not remove the widget element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// expand
        /// Expands a specified pane. Invoking this method will force the widget to redraw and it will trigger the resize event.
        /// Note: Invoking the method will not trigger an expand event.
        /// Parameters
        /// pane String|Element|jQuery
        /// The pane to be expanded.
        /// </summary>
        /// <returns></returns>
        public ActionResult expand()
        {
            return View();
        }

        /// <summary>
        /// insertAfter
        /// Inserts a new pane after the specified one. The method returns the pane element, so it can be populated with arbitrary content,
        /// if contentUrl is not set. Invoking this method will force the widget to redraw and it will trigger the resize event.
        /// Parameters
        /// config Object
        /// The new pane configuration.
        /// referencePane String|Element|jQuery
        /// The existing pane after which the new one will be inserted.
        /// Returns
        /// jQuery the pane element.
        /// </summary>
        /// <returns></returns>
        public ActionResult insertAfter()
        {
            return View();
        }

        /// <summary>
        /// insertBefore
        /// Inserts a new pane before the specified one. The method returns the pane element, so it can be populated with arbitrary content,
        /// if contentUrl is not set. Invoking this method will force the widget to redraw and it will trigger the resize event.
        /// Parameters
        /// config Object
        /// The new pane configuration.
        /// referencePane String|Element|jQuery
        /// The existing pane before which the new one will be inserted.
        /// Returns
        /// jQuery the pane element.
        /// </summary>
        /// <returns></returns>
        public ActionResult insertBefore()
        {
            return View();
        }

        /// <summary>
        /// max
        /// Sets the maximum size of a pane. Setting this value will not cause the widget to redraw, nor will it trigger any events.
        /// Parameters
        /// pane String|Element|jQuery
        /// The pane being targeted for a new minimum size configuration value.
        /// value String
        /// The maximum size value of the pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").
        /// </summary>
        /// <returns></returns>
        public ActionResult max()
        {
            return View();
        }

        /// <summary>
        /// min
        /// Sets the minimum size of a pane. Setting this value will not cause the widget to redraw, nor will it trigger any events.
        /// Parameters
        /// pane String|Element|jQuery
        /// The pane being targeted for a new minimum size configuration value.
        /// value String
        /// The minimum size value of the pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").
        /// </summary>
        /// <returns></returns>
        public ActionResult min()
        {
            return View();
        }

        /// <summary>
        /// remove
        /// Removes one or more panes. The method returns the Splitter instance.
        /// Invoking this method will force the widget to redraw and it will trigger the resize event.
        /// Parameters
        /// pane String|Element|jQuery
        /// The pane(s) to be removed.
        /// </summary>
        /// <returns></returns>
        public ActionResult remove()
        {
            return View();
        }

        /// <summary>
        /// size
        /// Set the size of the pane. Setting this value will cause the widget to redraw and it will trigger the resize event.
        /// Parameters
        /// pane String|Element|jQuery
        /// The pane to be resized.
        /// value String
        /// The new size of the pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").
        /// Note: This value must not exceed panes.max or be less then panes.min.
        /// </summary>
        /// <returns></returns>
        public ActionResult size()
        {
            return View();
        }

        /// <summary>
        /// toggle
        /// Toggles the state of a specified pane (i.e. collapsed or expanded). Invoking this method will force the widget to redraw and it will trigger the resize event.
        /// Note: Invoking the method will not trigger collapse or expand events.
        /// Parameters
        /// pane String|Element|jQuery
        /// The pane to be collapsed.
        /// expand Boolean (optional)
        /// Represents the desired state of the specified pane; to be expanded (true) or collapsed (false). If undefined, toggle() will collapse the pane if it is expanded or will expand the pane if it is collapsed.
        /// </summary>
        /// <returns></returns>
        public ActionResult toggle()
        {
            return View();
        }

        /// <summary>
        /// collapse
        /// Triggered when a pane of a Splitter is collapsed.
        /// Event Data
        /// e.pane Element
        /// The collapsing pane of the Splitter.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_collapse_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_collapse_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// contentLoad
        /// Triggered when the content for a pane has finished loading.
        /// Event Data
        /// e.pane Element
        /// The pane whose content has been loaded.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_contentLoad_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_contentLoad_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// error
        /// Triggered when the AJAX request that fetches a pane content has failed.
        /// Event Data
        /// e.xhr jqXHR
        /// The XHR request object, as returned from jQuery.ajax
        /// e.status String
        /// The status of the request, as returned from jQuery.ajax
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_error_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_error_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// expand
        /// Triggered when a pane of a Splitter is expanded.
        /// Event Data
        /// e.pane Element
        /// The expanding pane of the Splitter.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_expand_event_durin_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_expand_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// layoutChange
        /// This event is now obsolete and will be removed in the future. Please use the resize event instead.
        /// Fires when the splitter layout has changed
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_layoutChange_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_layoutChange_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// resize
        /// Triggered when a pane is resized.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_resize_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_resize_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to keep the splitter pane sizes in percentages upon user resizes
        /// </summary>
        /// <returns></returns>
        public ActionResult Keep_pane_size_in_percentages()
        {
            return View();
        }
    }
}