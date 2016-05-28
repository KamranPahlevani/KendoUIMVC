using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_DropTargetController : Controller
    {
        // GET: Kendo_UI_DropTarget
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// group String(default: "default")
        /// Used to group sets of draggable and drop targets.
        /// A draggable with the same group value as a drop target will be accepted by the drop target.
        /// </summary>
        /// <returns></returns>
        public ActionResult group()
        {
            return View();
        }

        /// <summary>
        /// destroyGroup
        /// Destroys all DropTarget instances from the group with the given name.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroyGroup()
        {
            return View();
        }

        /// <summary>
        /// dragenter
        /// Fired when draggable moves over the drop target.
        /// The dragenter event represents a jQuery mousemove event and contains all the event data of the jQuery Event Object.
        /// Event Data
        /// e.draggable kendo.ui.Draggable
        /// The Draggable instance that enters the drop target.
        /// e.dropTarget jQuery
        /// The DropTarget element.
        /// e.target Element
        /// The Draggable element.
        /// </summary>
        /// <returns></returns>
        public ActionResult dragenter()
        {
            return View();
        }

        /// <summary>
        /// dragleave
        /// Fired when draggable moves out of the drop target.
        /// The dragleave event represents a jQuery mousemove event and contains all the event data of the jQuery Event Object.
        /// Event Data
        /// e.draggable kendo.ui.Draggable
        /// The Draggable instance that leaves the drop target.
        /// e.dropTarget jQuery
        /// The DropTarget element.
        /// e.target Element
        /// The Draggable element.
        /// </summary>
        /// <returns></returns>
        public ActionResult dragleave()
        {
            return View();
        }

        /// <summary>
        /// drop
        /// Fired when draggable is dropped over the drop target.
        /// The dragleave event represents a jQuery mouseup event and contains all the event data of the jQuery Event Object.
        /// Event Data
        /// e.draggable kendo.ui.Draggable
        /// The Draggable instance that leaves the drop target.
        /// e.dropTarget jQuery
        /// The DropTarget element.
        /// e.target Element
        /// The Draggable element.
        /// </summary>
        /// <returns></returns>
        public ActionResult drop()
        {
            return View();
        }
    }
}