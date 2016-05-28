using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_MultiSelectController : Controller
    {
        /// <summary>
        /// Configures the opening and closing animations of the suggestion popup.
        /// Setting the animation option to false will disable the opening and closing animations.
        /// As a result the suggestion popup will open and close instantly.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_open_and_close_animations()
        {
            return View();
        }

        public ActionResult configure_the_animation()
        {
            return View();
        }

        /// <summary>
        /// animation.close.effects String
        /// The effect(s) to use when playing the close animation. Multiple effects should be separated with a space.
        /// animation.close.duration Number (default: 100)
        /// The duration of the close animation in milliseconds.
        /// animation.open Object
        /// The animation played when the suggestion popup is opened.
        /// </summary>
        /// <returns></returns>
        public ActionResult configure_the_close_animation()
        {
            return View();
        }

        /// <summary>
        /// animation.open.effects String
        /// The effect(s) to use when playing the open animation. Multiple effects should be separated with a space.
        /// animation.open.duration Number (default: 200)
        /// The duration of the open animation in milliseconds.
        /// autoBind Boolean(default: true)
        /// Controls whether to bind the widget to the data source on initialization.
        /// </summary>
        /// <returns></returns>
        public ActionResult configure_the_open_animation()
        {
            return View();
        }

        /// <summary>
        /// autoBind Boolean(default: true)
        /// Controls whether to bind the widget to the data source on initialization.
        /// </summary>
        /// <returns></returns>
        public ActionResult autoBind()
        {
            return View();
        }

        /// <summary>
        /// autoClose Boolean(default: true)
        /// Controls whether to close the widget suggestion list on item selection.
        /// </summary>
        /// <returns></returns>
        public ActionResult autoClose()
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

        /// <summary>
        /// dataValueField String(default: "")
        /// The field of the data item that provides the text content of the list items. The widget will filter the data source based on this field.
        /// Important When dataTextField is defined, thedataValueField option also should be set.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_dataTextField()
        {
            return View();
        }

        /// <summary>
        /// delay Number(default: 200)
        /// Specifies the delay in milliseconds after which the MultiSelect will start filtering dataSource.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_delay()
        {
            return View();
        }

        /// <summary>
        /// enable Boolean(default: true)
        /// If set to false the widget will be disabled and will not allow user input. The widget is enabled by default and allows user input.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_the_widget()
        {
            return View();
        }

        /// <summary>
        /// filter String(default: "startswith")
        /// The filtering method used to determine the suggestions for the current value.
        /// Filtration is turned of by default. The supported filter values are startswith, endswith and contains.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_filter()
        {
            return View();
        }


        /// <summary>
        /// height Number(default: 200)
        /// The height of the suggestion popup in pixels.
        /// The default value is 200 pixels.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_height()
        {
            return View();
        }

        /// <summary>
        /// highlightFirst Boolean(default: true)
        /// If set to true the first suggestion will be automatically highlighted.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_highlightFirst()
        {
            return View();
        }

        /// <summary>
        /// ignoreCase String(default: true)
        /// If set to false case-sensitive search will be performed to find suggestions. The widget performs case-insensitive searching by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_caseinsensitive_suggestions()
        {
            return View();
        }

        /// <summary>
        /// minLength Number(default: 0)
        /// The minimum number of characters the user must type before a search is performed.
        /// Set to a higher value if the search could match a lot of items. A zero value means that a request will be made as soon as the user focuses the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_minLength()
        {
            return View();
        }

        /// <summary>
        /// maxSelectedItems Number(default: null)
        /// Defines the limit of the selected items. If set to null widget will not limit number of the selected items.
        /// </summary>
        /// <returns></returns>
        public ActionResult maxSelectedItems()
        {
            return View();
        }

        /// <summary>
        /// placeholder String(default: "")
        /// The hint displayed by the widget when it is empty. Not set by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_placeholder_option()
        {
            return View();
        }

        public ActionResult specify_placeholder_as_HTML_attribute()
        {
            return View();
        }

        /// <summary>
        /// headerTemplate String|Function
        /// Specifies a static HTML content, which will be rendered as a header of the popup element.
        /// Important Widget does not pass a model data to the header template. Use this option only with static HTML.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_headerTemplate_as_a_string()
        {
            return View();
        }

        /// <summary>
        /// itemTemplate String|Function
        /// The template used to render the items in the popup list.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_template_as_a_function()
        {
            return View();
        }

        public ActionResult specify_template_as_a_string()
        {
            return View();
        }

        /// <summary>
        /// tagTemplate String
        /// The template used to render the tags.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_tagTemplate_as_a_function()
        {
            return View();
        }

        public ActionResult specify_tagTemplate_as_a_string()
        {
            return View();
        }

        /// <summary>
        /// value Array(default: [])
        /// Define the value of the widget
        /// Important: Define a list of data items if widget is not initially bound
        /// </summary>
        /// <returns></returns>
        public ActionResult value_simpleArray()
        {
            return View();
        }

        public ActionResult value_classArray()
        {
            return View();
        }

        /// <summary>
        /// valuePrimitive Boolean(default: false)
        /// Specifies the value binding behavior for the widget.
        /// If set to true, the View-Model field will be updated with the selected item value field.
        /// If set to false, the View-Model field will be updated with the selected item.
        /// </summary>
        /// <returns></returns>
        public ActionResult valuePrimitive()
        {
            return View();
        }

        /// <summary>
        /// dataSource kendo.data.DataSource
        /// The data source of the widget. Configured via the dataSource option.
        /// Changes of the data source will be reflected in the widget.
        /// Important: Assigning a new data source would have no effect. Use the setDataSource method instead.
        /// </summary>
        /// <returns></returns>
        public ActionResult add_a_data_item_to_the_data_source()
        {
            return View();
        }

        /// <summary>
        /// input jQuery
        /// A jQuery object of the visible input element, where the user types.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_input_element()
        {
            return View();
        }

        /// <summary>
        /// options Object
        /// An object, which holds the options of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_options_of_the_widget()
        {
            return View();
        }

        /// <summary>
        /// list jQuery
        /// A jQuery object of the drop-down list element.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_list_element()
        {
            return View();
        }

        /// <summary>
        /// ul jQuery
        /// A jQuery object of the ul element, which holds the available options.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_ul_element()
        {
            return View();
        }

        /// <summary>
        /// tagList jQuery
        /// A jQuery object of the ul element, which holds the selected tags.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_tagList_element()
        {
            return View();
        }

        /// <summary>
        /// Closes the widget popup.
        /// </summary>
        /// <returns></returns>
        public ActionResult close_the_suggestion_popup()
        {
            return View();
        }

        /// <summary>
        /// dataItems
        /// Returns list of raw data records corresponding to the selected items.
        /// Returns
        /// Array The raw data records. Returns empty array ([]) if no selected options
        /// </summary>
        /// <returns></returns>
        public ActionResult dataItems()
        {
            return View();
        }

        /// <summary>
        /// destroy
        ///Prepares the MultiSelect for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// Important: This method does not remove the MultiSelect element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enables or disables the widget.
        /// Parameters
        /// enable Boolean
        /// If set to true the widget will be enabled. If set to false the widget will be disabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_the_widget()
        {
            return View();
        }

        /// <summary>
        /// readonly
        /// Toggles the readonly state of the widget. When the widget is readonly it doesn't allow user input.
        /// There is a difference between disabled and readonly mode. The value of a disabled widget is not posted as part of a form whereas the value of a readonly widget is posted.
        /// Parameters
        /// readonly Boolean
        /// If set to true the widget will not allow user input. If set to false the widget will allow user input.
        /// </summary>
        /// <returns></returns>
        public ActionResult make_the_widget_readonly()
        {
            return View();
        }

        /// <summary>
        /// focus
        /// Focuses the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult focus_the_widget()
        {
            return View();
        }

        /// <summary>
        /// open
        /// Opens the popup.
        /// </summary>
        /// <returns></returns>
        public ActionResult open()
        {
            return View();
        }

        /// <summary>
        /// refresh
        /// Refresh the popup by rendering all items again.
        /// </summary>
        /// <returns></returns>
        public ActionResult refresh_the_popup_items()
        {
            return View();
        }

        /// <summary>
        /// search
        /// Searches the data source for the provided value and displays any matches as suggestions.
        /// Parameters
        /// word String
        /// The filter value.
        /// </summary>
        /// <returns></returns>
        public ActionResult search_the_widget()
        {
            return View();
        }

        /// <summary>
        /// setDataSource
        /// Sets the dataSource of an existing MultiSelect and rebinds it.
        /// Parameters
        /// dataSource kendo.data.DataSource
        /// </summary>
        /// <returns></returns>
        public ActionResult setDataSource()
        {
            return View();
        }

        /// <summary>
        /// toggle
        /// Opens or closes the widget popup.
        /// Parameters
        /// toggle Boolean
        /// Defines the whether to open/close the drop-down list.
        /// </summary>
        /// <returns></returns>
        public ActionResult toggle()
        {
            return View();
        }

        /// <summary>
        /// value
        /// Gets or sets the value of the MultiSelect. Accepts string value or Array of strings.
        /// Important: If no items, value method will pre-fetch the data before continue with the value setting.
        /// Parameters
        /// value Array|String
        /// The value to set.
        /// Returns
        /// Array The value of the MultiSelect.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_value()
        {
            return View();
        }

        /// <summary>
        /// If initial items are lost in attempt to set new values,
        /// probably the widget is filtered by the end user, but no value has been selected.
        /// You will need to remove applied filter, before calling value method
        /// </summary>
        /// <returns></returns>
        public ActionResult remove_applied_filter_before_set_the_value()
        {
            return View();
        }

        /// <summary>
        /// change
        /// Fired when the value of the widget is changed by the user.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Important: The event is not fired when the value of the widget is changed from code.
        /// Event Data
        ///e.sender kendo.ui.MultiSelect
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_change_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_tothe_change_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// close
        /// Fired when the popup of the widget is closed.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.sender kendo.ui.MultiSelect
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_close_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_close_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// dataBound
        /// Fired when the widget is bound to data from its data source.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.sender kendo.ui.MultiSelect
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_dataBound_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_dataBound_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// filtering
        /// Fired when the widget is about to filter the data source.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.sender kendo.ui.MultiSelect
        /// The widget instance which fired the event.
        /// e.filter Object
        /// The filter descriptor that will be used to filter the data source.
        /// The data source filters the data items client-side unless the data source serverFiltering option is set to true.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_filtering_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_filtering_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// open
        /// Fired when the popup of the widget is opened by the user.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.sender kendo.ui.MultiSelect
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_open_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_open_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// select
        /// Fired when an item from the popup is selected by the user.
        /// Important: The event is not fired when an item is selected programmatically.
        /// Event Data
        /// e.item jQuery
        /// The jQuery object which represents the selected item.
        /// e.sender kendo.ui.MultiSelect
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_select_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_select_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to bind the widget value to a template using MVVM
        /// </summary>
        /// <returns></returns>
        public ActionResult Bind_values_to_template()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to cascade the Kendo UI Multiselect from a Kendo UI DropDownList
        /// </summary>
        /// <returns></returns>
        public ActionResult Cascade_from_DropDownList()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to cascade multiple Kendo UI MultiSelect widgets.
        /// </summary>
        public ActionResult Cascading_MultiSelects()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to preselect items using MVVM binding.
        /// </summary>
        /// <returns></returns>
        public ActionResult Preselect_items_using_MVVM()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to create a scrollable list of the selected items in the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult Scrollbale_data_items()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to create a dataItem that holds value named "all" that will select all the items in the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult Select_all_values_with_one_selection()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to select/deselect all items using external buttons.
        /// </summary>
        /// <returns></returns>
        public ActionResult Select_deselect_all_items()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to use the Kendo UI Multiselect widget with Boostrap modal window and bind values.
        /// </summary>
        /// <returns></returns>
        public ActionResult Using_widget_with_Boostrap_modal_window()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to bind to the blur event of the filter input element.
        /// </summary>
        /// <returns></returns>
        public ActionResult Wire_blur_event_of_the_filter_input()
        {
            return View();
        }

             
	}
}