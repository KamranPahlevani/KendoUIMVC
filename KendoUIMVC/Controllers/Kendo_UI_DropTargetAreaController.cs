using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_DropTargetAreaController : Controller
    {
        /// <summary>
        /// group String(default: "default")
        /// Used to group sets of draggable and drop targets. A draggable with the same group value as a drop target will be accepted by the drop target.
        /// </summary>
        /// <returns></returns>
        public ActionResult group()
        {
            return View();
        }

        /// <summary>
        /// filter String(default: null)
        /// Selector to filter the drop targets in the area. Every matched element acts as a drop target and fires events on the DropTargetArea. Specifying the filter is mandatory.
        /// </summary>
        /// <returns></returns>
        public ActionResult filter()
        {
            return View();
        }

        /// <summary>
        /// Fired when draggable moves over one of the drop targets.
        /// The dragenter event represents a jQuery mousemove event and contains all the event data of the jQuery Event Object.
        /// Event Data
        /// e.draggable kendo.ui.Draggable
        /// Reference to the Draggable instance that enters a drop target.
        /// e.dropTarget jQuery
        /// The current DropTarget element in the area that initiated the event.
        /// e.target Element
        /// The current Draggable element.
        /// </summary>
        /// <returns></returns>
        public ActionResult dragenter()
        {
            return View();
        }

        /// <summary>
        /// Fired when draggable moves out of one of the drop targets.
        /// The dragleave event represents a jQuery mousemove event and contains all the event data of the jQuery Event Object.
        /// Event Data
        /// e.draggable kendo.ui.Draggable
        /// Reference to the Draggable instance that enters a drop target.
        /// e.dropTarget jQuery
        /// The current DropTarget element in the area that initiated the event.
        /// e.target Element
        /// The current Draggable element.
        /// </summary>
        /// <returns></returns>
        public ActionResult dragleave()
        {
            return View();
        }

        /// <summary>
        /// Fired when draggable is dropped over one of the drop targets.
        /// The drop event represents a jQuery mouseup event and contains all the event data of the jQuery Event Object.
        /// Event Data
        /// e.draggable kendo.ui.Draggable
        /// Reference to the Draggable instance that enters a drop target.
        /// e.dropTarget jQuery
        /// The current DropTarget element in the area that initiated the event.
        /// e.target Element
        /// The current Draggable element.
        /// </summary>
        /// <returns></returns>
        public ActionResult drop()
        {
            return View();
        }
    }
}