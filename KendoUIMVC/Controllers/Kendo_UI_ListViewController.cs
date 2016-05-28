using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_ListViewController : Controller
    {
       /// <summary>
        /// If set to false the widget will not bind to the data source during initialization.
        /// In this case data binding will occur when the change event of the data source is fired.
        /// By default the widget will bind to the data source specified in the configuration.
       /// </summary>
       /// <returns></returns>
        public ActionResult disable_automatic_binding()
        {
            return View();
        }

        public ActionResult set_dataSource_as_a_JavaScript_object()
        {
            return View();
        }

        public ActionResult set_dataSource_as_a_JavaScript_array()
        {
            return View();
        }

        public ActionResult set_dataSource_as_an_existing_kendo_data_DataSource_instance()
        {
            return View();
        }

        public ActionResult editTemplate()
        {
            return View();
        }

        /// <summary>
        /// Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult navigatable()
        {
            return View();
        }

        /// <summary>
        /// Indicates whether selection is enabled/disabled. Possible values:
        /// true
        /// Single item selection.
        /// "single"
        /// Single item selection.
        /// "multiple"
        /// Multiple item selection.
        /// </summary>
        /// <returns></returns>
        public ActionResult Example_of_ListView_with_multiple_selection_enabled()
        {
            return View();
        }

        /// <summary>
        /// Specifies ListView item template
        /// </summary>
        /// <returns></returns>
        public ActionResult template()
        {
            return View();
        }

        /// <summary>
        /// altTemplate Function
        /// Template to be used for rendering the alternate items in the listview.
        /// </summary>
        /// <returns></returns>
        public ActionResult Example_of_alternate_item_template()
        {
            return View();
        }

        /// <summary>
        /// Inserts empty item as first item on the current view and prepare it for editing.
        /// </summary>
        /// <returns></returns>
        public ActionResult add()
        {
            return View();
        }

        /// <summary>
        /// Cancels changes in currently edited item.
        /// </summary>
        /// <returns></returns>
        public ActionResult cancel()
        {
            return View();
        }

        /// <summary>
        /// Clears ListView selected items and triggers change event.
        /// </summary>
        /// <returns></returns>
        public ActionResult clearSelection()
        {
            return View();
        }

        /// <summary>
        /// Prepares the ListView for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks.
        /// Calls destroy method of any child Kendo widgets.
        /// Important: This method does not remove the ListView element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// Edit specified ListView item. Fires the edit event.
        /// Parameters
        /// item jQuery
        /// jQuery object which represents the item to be edited.
        /// </summary>
        /// <returns></returns>
        public ActionResult edit()
        {
            return View();
        }

        /// <summary>
        /// jQuery object which represents the item to be edited.
        /// </summary>
        /// <returns></returns>
        public ActionResult refresh()
        {
            return View();
        }

        /// <summary>
        /// Removes specified ListView item.
        /// Triggers remove event and if not prevented calls DataSource sync method.
        /// Parameters
        /// item Object
        /// jQuery object which represents the item to be removed.
        /// </summary>
        /// <returns></returns>
        public ActionResult remove()
        {
            return View();
        }

        /// <summary>
        /// Saves edited ListView item. Triggers save event.
        /// If save event is not prevented and validation succeeds will call DataSource sync method.
        /// </summary>
        /// <returns></returns>
        public ActionResult save()
        {
            return View();
        }

        /// <summary>
        /// Get/set the selected listview item(s).
        /// Returns
        /// jQuery the selected items if called without arguments.
        /// Parameters
        /// items jQuery | Array
        /// Items to select.
        /// </summary>
        /// <returns></returns>
        public ActionResult select()
        {
            return View();
        }

        /// <summary>
        /// Sets the dataSource of an existing ListView and rebinds it.
        /// Parameters
        /// dataSource kendo.data.DataSource
        /// The data source to which the widget should be bound.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_data_source()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user clicks the "cancel" button.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.container jQuery
        /// The jQuery object that represents the edit form container element.
        /// e.model kendo.data.Model
        /// The model to which the current grid row is bound to.
        /// e.preventDefault Function
        /// If invoked prevents the cancel action. The row remains in edit mode.
        /// </summary>
        /// <returns></returns>
        public ActionResult cancel_event()
        {
            return View();
        }

        public ActionResult cancel_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fires when the list view selection has changed.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        public ActionResult change_event()
        {
            return View();
        }

        public ActionResult change_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fires when the list view has received data from the data source and it is already rendered.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult dataBound_event()
        {
            return View();
        }

        /// <summary>
        /// Fires when the list view is about to be rendered.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult dataBinding_event()
        {
            return View();
        }

        public ActionResult dataBinding_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fires when the list view enters edit mode.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.item jQuery
        /// The jQuery element to be edited.
        /// e.model kendo.data.Model
        /// The model to be edited.
        /// </summary>
        /// <returns></returns>
        public ActionResult edit_event()
        {
            return View();
        }

        public ActionResult edit_event_To_set_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fires before the list view item is removed. If it is not prevented will call DataSource sync method.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.item jQuery
        /// The item element to be deleted.
        /// e.model kendo.data.Model
        /// The model which to be deleted.
        /// </summary>
        /// <returns></returns>
        public ActionResult remove_event()
        {
            return View();
        }

        public ActionResult remove_event_To_set_after_initialization()
        {
            return View();
        }

        /// Fired when a data item is saved.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.model kendo.data.Model
        /// The data item to which the ListView item is bound.
        /// e.item jQuery
        /// The jQuery object representing the current ListView item.
        /// e.sender kendo.ui.ListView
        /// The widget instance which fired the event.
        public ActionResult subscribe_to_the_save_event()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates implementation for drag'n'drop reordering in ListView using kendoTouch tap event.
        /// The approach is suitable for mobile devices as it does not prevent the scrolling of the page/widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult Drag_and_Drop_reordering_using_Kendo_UI_Touch()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to filter ListView datasource based on Kendo UI Slider selection. Shows inclusive/exclusive fitlering
        /// </summary>
        /// <returns></returns>
        public ActionResult Filtering_using_Kendo_UI_Slider()
        {
            return View();
        }

	}
}