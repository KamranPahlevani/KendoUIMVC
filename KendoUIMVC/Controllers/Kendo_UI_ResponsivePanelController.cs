using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_ResponsivePanelController : Controller
    {

        /// <summary>
        /// autoClose Boolean (default: true)
        /// If set to false the widget will not close when the page content is touched, after it was opened on a mobile device.
        /// You will need to call the close method when the panel needs to close.
        /// </summary>
        /// <returns></returns>
        public ActionResult autoClose()
        {
            return View();
        }

        /// <summary>
        /// breakpoint Number (default: 640)
        /// Specifies the page width at which the widget will be hidden and its toggle button will become visible.
        /// </summary>
        /// <returns></returns>
        public ActionResult breakpoint()
        {
            return View();
        }

        /// <summary>
        /// orientation String (default: "left")
        /// Specifies the direction from which the hidden element will open up, once the toggle button has been activated. Valid values are "left", "right", and "top".
        /// </summary>
        /// <returns></returns>
        public ActionResult orientation()
        {
            return View();
        }

        /// <summary>
        /// Closes the responsive panel.
        /// </summary>
        /// <returns></returns>
        public ActionResult close()
        {
            return View();
        }

        /// <summary>
        /// Prepares the widget for safe removal from DOM. Detaches all event handlers and removes jQuery.
        /// data attributes to avoid memory leaks. Calls the destroy method of any child Kendo widgets.
        /// This method does not remove the widget element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// open
        /// Opens the responsive panel.
        /// </summary>
        /// <returns></returns>
        public ActionResult open()
        {
            return View();
        }

        /// <summary>
        /// close
        /// Triggered before the responsive panel is closed. Cancellable.
        /// </summary>
        /// <returns></returns>
        public ActionResult Attach_close_event_handler_during_initialization()
        {
            return View();
        }

        public ActionResult Attach_close_event_handler_via_bind_detach_via_unbind()
        {
            return View();
        }

        /// <summary>
        /// open
        /// Triggered before the responsive panel is opened. Cancellable.
        /// </summary>
        /// <returns></returns>
        public ActionResult Attach_open_event_handler_during_initialization()
        {
            return View();
        }

        public ActionResult Attach_open_event_handler_via_bind_detach_via_unbind()
        {
            return View();
        }
    }
}