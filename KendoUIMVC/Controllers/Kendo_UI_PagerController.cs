using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_PagerController : Controller
    {
        /// <summary>
        /// autoBind Boolean(default: true)
        /// Indicates whether the pager refresh method will be called within its initialization.
        /// </summary>
        /// <returns></returns>
        public ActionResult autoBind()
        {
            return View();
        }

        /// <summary>
        /// buttonCount Number(default: 10)
        /// Defines the number of buttons displayed in the numeric pager.
        /// </summary>
        /// <returns></returns>
        public ActionResult buttonCount()
        {
            return View();
        }

        /// <summary>
        /// Instance of kendo DataSource. See the kendo.data.DataSource.
        /// This option is mandatory because the Pager is tightly connected with DataSource.
        /// The pager is UI widget for managing paging over the DataSource.
        /// The Pager gets values like page size or total count of items from DataSource.
        /// </summary>
        /// <returns></returns>
        public ActionResult standalone_pager()
        {
            return View();
        }

        /// <summary>
        /// If the Pager is used with another widget then we usually specify this Pager like object of options for given widget.
        /// In that case the DataSource is automatically injected to the Pager from the widget. See example for a Grid below.
        /// </summary>
        /// <returns></returns>
        public ActionResult grid_pager()
        {
            return View();
        }

        /// <summary>
        /// selectTemplate String
        /// The template for selected page number link.
        /// </summary>
        /// <returns></returns>
        public ActionResult selectTemplate()
        {
            return View();
        }

        /// <summary>
        /// linkTemplate String
        /// The template for page number links.
        /// </summary>
        /// <returns></returns>
        public ActionResult linkTemplate()
        {
            return View();
        }

        /// <summary>
        /// info Boolean(default: true)
        /// Defines if a label showing current paging information will be displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult info()
        {
            return View();
        }

        /// <summary>
        /// input Boolean(default: false)
        /// Defines if an input element which allows the user to navigate to given page will be displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult input()
        {
            return View();
        }

        /// <summary>
        /// numeric Boolean(default: true)
        /// Defines if numeric portion of the pager will be shown.
        /// </summary>
        /// <returns></returns>
        public ActionResult numeric()
        {
            return View();
        }

        /// <summary>
        /// pageSizes Boolean|Array (default: false)
        /// Displays a list with predefined page sizes. An array of values to be displayed can be provided.
        /// If pageSize option is provided for DataSource then this pageSize value will be automatically selected in created selectbox.
        /// </summary>
        /// <returns></returns>
        public ActionResult show_the_page_size_DropDownList()
        {
            return View();
        }

        public ActionResult show_the_page_size_DropDownList_with_custom_values()
        {
            return View();
        }

        /// <summary>
        /// previousNext Boolean(default: true)
        /// Defines if buttons for navigating to the first, last, previous and next pages will be shown.
        /// </summary>
        /// <returns></returns>
        public ActionResult previousNext()
        {
            return View();
        }

        /// <summary>
        /// refresh Boolean(default: false)
        /// Defines if a refresh button will be displayed.
        /// Click on that button will call DataSource read() method to get actual data
        /// </summary>
        /// <returns></returns>
        public ActionResult refresh()
        {
            return View();
        }

        /// <summary>
        /// messages Object
        /// Defines texts shown within the pager. Use this option to customize or localize the pager messages.
        /// messages.display String(default: "{0} - {1} of {2} items")
        /// The pager info text. Uses kendo.format.
        /// Contains three placeholders: - {0} - the first data item index - {1} - the last data item index - {2} - the total number of data items
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_display_message()
        {
            return View();
        }

        /// <summary>
        /// messages.empty String(default: "No items to display"),
        /// The text displayed when the DataSource view does no contain items.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_empty_message()
        {
            return View();
        }

        /// <summary>
        /// messages.page String(default: "Page"),
        /// The label displayed before the pager input.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_label_before_the_pager_input()
        {
            return View();
        }

        /// <summary>
        /// messages.of String(default: "of {0}"),
        /// The label displayed before the pager input. Uses kendo.format.
        /// Contains one optional placeholder {0} which represents the total number of pages.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_label_after_the_pager_input()
        {
            return View();
        }

        /// <summary>
        /// messages.itemsPerPage String(default: "items per page"),
        /// The label displayed after the page size DropDownList.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_label_after_the_page_size_DropDownList()
        {
            return View();
        }

        /// <summary>
        /// messages.first String(default: "Go to the first page"),
        /// The tooltip of the button which navigates to the first page.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_tooltip_of_the_first_page_button()
        {
            return View();
        }

        /// <summary>
        /// messages.previous String(default: "Go to the previous page"),
        /// The tooltip of the button which navigates to the previous page.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_tooltip_of_the_previous_page_button()
        {
            return View();
        }

        /// <summary>
        /// messages.next String(default: "Go to the next page"),
        /// The tooltip of the button which navigates to the next page.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_tooltip_of_the_next_page_button()
        {
            return View();
        }

        /// <summary>
        /// messages.last String(default: "Go to the last page"),
        /// The tooltip of the button which navigates to the last page.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_tooltip_of_the_last_page_button()
        {
            return View();
        }

        /// <summary>
        /// messages.refresh String(default: "Refresh"),
        /// The tooltip of the refresh button.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_tooltip_of_the_refresh_button()
        {
            return View();
        }

        /// <summary>
        /// totalPages
        /// Returns the number of pages.
        /// Returns
        /// Number The number of pages.
        /// </summary>
        /// <returns></returns>
        public ActionResult totalPages()
        {
            return View();
        }

        /// <summary>
        /// pageSize
        /// Returns the page size - maximum number of items allowed on one page.
        /// Returns
        /// Number The maximum number of items allowed on one page.
        /// </summary>
        /// <returns></returns>
        public ActionResult pageSize()
        {
            return View();
        }

        /// <summary>
        /// page
        /// Sets or gets the current page.
        /// Parameters
        /// page Boolean
        /// The new page number.
        /// Returns
        /// Number The current page number 
        /// </summary>
        /// <returns></returns>
        public ActionResult get_current_page()
        {
            return View();
        }

        public ActionResult set_current_page()
        {
            return View();
        }

        /// <summary>
        /// Updates all values of pager elements so that these values fit the values of DataSource.
        /// This method is automatically called after DataSource change event is fired.
        /// </summary>
        /// <returns></returns>
        public ActionResult refresh_the_pager()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Unbinds all callbacks created within pager initialization.
        /// This method doesn't remove pager element from DOM.
        /// This method does not remove the widget element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// change
        /// Fires when the current page has changed.
        /// Event Data
        /// e.sender kendo.ui.Grid
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_change_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_change_event_after_initialization()
        {
            return View();
        }

    }
}