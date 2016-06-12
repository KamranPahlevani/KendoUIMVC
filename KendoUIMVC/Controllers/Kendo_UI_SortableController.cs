using KendoUIMvcApplication.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_SortableController : Controller
    {

        /// <summary>
        /// axis String(default: null)
        /// Constrains the hint movement to either the horizontal (x) or vertical (y) axis. Can be set to either "x" or "y".
        /// </summary>
        /// <returns></returns>
        public ActionResult axis()
        {
            return View();
        }

        /// <summary>
        /// container String | jQuery(default: null)
        /// Selector that determines the container to which boundaries the hint movement will be constrained.
        /// </summary>
        /// <returns></returns>
        public ActionResult container()
        {
            return View();
        }

        /// <summary>
        /// connectWith String | jQuery(default: null)
        /// Selector which determines if items from the current Sortable widget can be accepted from another Sortable container(s).
        /// The connectWith option describes one way relationship, if the developer wants a two way connection then the connectWith option should be set on both widgets.
        /// By default when the Sortable widget is left with no items its height will become zero. This will prevent the user from being able to drop items back into it.
        /// To avoid this behaviour the developer should set the min-height CSS property of the sortable container.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_up_a_one_way_connection_from_ListA_to_ListB()
        {
            return View();
        }

        public ActionResult set_up_a_bidirectional_connection_between_Sortable_widgets()
        {
            return View();
        }

        /// <summary>
        /// cursor String(default: "auto")
        /// The cursor that will be shown while user drags sortable item.
        /// </summary>
        /// <returns></returns>
        public ActionResult cursor()
        {
            return View();
        }

        /// <summary>
        /// cursorOffset Object(default: null)
        /// If set, specifies the offset of the hint relative to the mouse cursor/finger. By default,
        /// the hint is initially positioned on top of the draggable source offset. The option accepts an object with two keys: top and left.
        /// cursorOffset.left Number
        /// The left offset of the hint element relative to the mouse cursor/finger.
        /// cursorOffset.top Number
        /// The top offset of the hint element relative to the mouse cursor/finger.
        /// </summary>
        /// <returns></returns>
        public ActionResult cursorOffset()
        {
            return View();
        }

        /// <summary>
        /// disabled String(default: null)
        /// Selector that determines which items are disabled. Disabled items cannot be dragged but are valid sort targets.
        /// </summary>
        /// <returns></returns>
        public ActionResult disabled()
        {
            return View();
        }

        /// <summary>
        /// filter String(default: null)
        /// Selector that determines which items are sortable. Filtered items cannot be dragged and are not valid sort targets.
        /// </summary>
        /// <returns></returns>
        public ActionResult filter()
        {
            return View();
        }

        /// <summary>
        /// handler String(default: null)
        /// Selector that determines which element will be used as a draggable handler. If a handler is defined,
        /// the user will be able to move the Sortable items only if the cursor/finger is positioned onto the handler element.
        /// </summary>
        /// <returns></returns>
        public ActionResult handler()
        {
            return View();
        }

        /// <summary>
        /// hint Function | String | jQuery
        /// Provides a way for customization of the sortable item hint. If a function is supplied,
        /// it receives one argument - the draggable element's jQuery object.
        /// If hint function is not provided the widget will clone dragged item and use it as a hint.
        /// Important: The hint element is appended to the <body> tag.
        /// The developer should have this in mind in order to avoid styling issues.
        /// </summary>
        /// <returns></returns>
        public ActionResult hint()
        {
            return View();
        }

        /// <summary>
        /// holdToDrag Boolean(default: false)
        /// Suitable for touch oriented user interface, in order to avoid collision with the touch scrolling gesture.
        /// When set to true, the item will be activated after the user taps and holds the finger on the element for a short amount of time.
        /// The item will also be activated by pressing, holding and lifting the finger without any movement.
        /// Dragging it afterwards will initiate the drag immediately.
        /// </summary>
        /// <returns></returns>
        public ActionResult holdToDrag()
        {
            return View();
        }

        /// <summary>
        /// ignore String(default: null)
        /// Selector that determines which elements inside the sorted item's container will be ignored. Useful if the sortable item contains input elements.
        /// Important The ignore option is available in the latest internal build! This feature is not included in Q1 2014 (v2014.1.318).
        /// </summary>
        /// <returns></returns>
        public ActionResult ignore()
        {
            return View();
        }

        /// <summary>
        /// placeholder Function | String | jQuery
        /// Provides a way for customization of the sortable item placeholder. If a function is supplied, it receives one argument - the draggable element's jQuery object.
        /// If placeholder function is not provided the widget will clone dragged item, remove its ID attribute, set its visibility to hidden and use it as a placeholder.
        /// **Important: The placeholder element is appended to the Sortable widget container.
        /// </summary>
        /// <returns></returns>
        public ActionResult placeholder()
        {
            return View();
        }

        /// <summary>
        /// indexOf
        /// Returns the index of specified item. Filtered items are excluded from the collection.
        /// Important: While user drags to sort the original item is hidden and the placeholder is appended to the Sortable collection. This is why jQuery's index method might return incorrect results. When the developer wants to find the index of a given item it is recommended to use widget's indexOf method.
        /// Parameters
        /// element jQuery
        /// jQuery object which represents the sortable element.
        /// Returns
        /// Number the index of specified item.
        /// </summary>
        /// <returns></returns>
        public ActionResult indexOf()
        {
            return View();
        }

        /// <summary>
        /// items
        /// Returns the sortable elements. Filtered items and the placeholder are excluded from the collection.
        /// Important: While user drags to sort the original item is hidden and the placeholder is appended to the Sortable collection.
        /// This is why jQuery's children method might return incorrect results.
        /// When the developer wants to obtain the sortable items it is recommended to use widget's items method.
        /// Returns
        /// jQuery the sortable items
        /// </summary>
        /// <returns></returns>
        public ActionResult items()
        {
            return View();
        }

        /// <summary>
        /// start
        /// Fires when sortable item drag starts.
        /// Event Data
        /// e.draggableEvent Object
        /// The original draggable's dragstart event data.
        /// e.item jQuery
        /// The element that will be dragged.
        /// e.preventDefault Function
        /// If invoked prevents the drag start action. The element will remain at its original position. The hint and placeholder will not be initialized.
        /// </summary>
        /// <returns></returns>
        public ActionResult start()
        {
            return View();
        }

        /// <summary>
        /// move
        /// Fires when Sortable's placeholder changes its position.
        /// Event Data
        /// e.item jQuery
        /// The element that is dragged.
        /// e.target jQuery
        /// The target element under cursor against which placeholder is positioned.
        /// e.list kendo.ui.Sortable
        /// The Sortable widget instance which the item belongs to (useful in case there are connected Sortable widgets).
        /// e.draggableEvent Object
        /// The original draggable's drag event data.
        /// </summary>
        /// <returns></returns>
        public ActionResult move()
        {
            return View();
        }

        /// <summary>
        /// end
        /// Fires when item dragging ends but before the item's position is changed in the DOM. This event is suitable for preventing the sort action.
        /// Event Data
        /// e.action String
        /// Possible values are: 
        /// "sort" - indicates that item's position was changed inside the same Sortable container;
        /// "remove" - indicates that the item was removed from current Sortable widget;
        /// "receive" - indicates that the item was received by a connected Sortable widget instance;
        /// e.preventDefault Function
        /// If invoked prevents the sort action. The element will be reverted at its original position. The hint and placeholder will be destroyed.
        /// e.item jQuery
        /// The element that is dragged.
        /// e.oldIndex Number
        /// The original position of the item in the Sortable collection. In case the item is received from connected Sortable the value will be -1
        /// e.newIndex Number
        /// The position where item will be placed. In case the item is removed from connected Sortable the value will be -1
        /// e.draggableEvent Object
        /// The original draggable's drag event data.
        /// </summary>
        /// <returns></returns>
        public ActionResult end()
        {
            return View();
        }

        /// <summary>
        /// change
        /// Fires when item is sorted and the item's position is changed in the DOM.
        /// Important: This event cannot be prevented. If this is required the developer should use the end event.
        /// Event Data
        /// e.action String
        /// Possible values are: "sort" - indicates that item's position was changed inside the same Sortable container; "remove" - indicates that the item was removed from current Sortable widget; "receive" - indicates that the item was received by a connected Sortable widget instance;
        /// e.item jQuery
        /// The element that is dragged.
        /// e.oldIndex Number
        /// The original position where the item was located at. In case the item is received from connected Sortable the value will be -1
        /// e.newIndex Number
        /// The position where item is placed. In case the item is removed from connected Sortable the value will be -1
        /// e.draggableEvent Object
        /// The original draggable's drag event data.
        /// </summary>
        /// <returns></returns>
        public ActionResult change()
        {
            return View();
        }

        /// <summary>
        /// cancel
        /// Fires when item sorting is canceled by pressing the Escape key.
        /// Event Data
        /// e.item jQuery
        /// The element that is dragged.
        /// </summary>
        /// <returns></returns>
        public ActionResult cancel()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to save the order in localStorage and restore it on page load
        /// </summary>
        /// <returns></returns>
        public ActionResult Persist_order_in_localStorage()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to reorder rows in a child Grid using Kendo UI Sortable
        /// </summary>
        /// <returns></returns>
        public ActionResult Reorder_rows_in_nested_Grid()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to reorder Grid rows using a Kendo UI Sortable
        /// </summary>
        /// <returns></returns>
        public ActionResult Reorder_Grid_rows()
        {
            ViewBag.Products = JsonConvert.SerializeObject(new ProductRepository().GetProducts(), Formatting.None);
            return View();
        }

    }
}