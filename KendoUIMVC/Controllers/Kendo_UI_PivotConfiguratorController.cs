using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_PivotConfiguratorController : Controller
    {
        // GET: Kendo_UI_PivotConfigurator

        /// <summary>
        ///  dataSource Object|kendo.data.PivotDataSource
        /// The data source of the widget which is used to display values.
        /// Can be a JavaScript object which represents a valid data source configuration or an existing kendo.data.PivotDataSource instance.
        /// If the dataSource option is set to a JavaScript object the widget will initialize a new kendo.data.PivotDataSource instance using that
        /// value as data source configuration.
        /// If the dataSource option is an existing kendo.data.PivotDataSource instance 
        /// the widget will use that instance and will not initialize a new one.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_dataSource_as_a_JavaScript_object()
        {
            return View();
        }

        public ActionResult set_dataSource_as_an_existing_kendo_data_PivotDataSource_instance()
        {
            return View();
        }

        /// <summary>
        /// filterable Boolean (default: false)
        /// If set to true the user will be able to filter by using the field menu.
        /// </summary>
        /// <returns></returns>
        public ActionResult filterable()
        {
            return View();
        }

        /// <summary>
        /// sortable Boolean|Object (default: false)
        /// If set to true the user could sort the widget by clicking the dimension fields. By default sorting is disabled.
        /// Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_sorting()
        {
            return View();
        }

        /// <summary>
        /// sortable.allowUnsort Boolean (default: false)
        /// If set to true the user can get the widget in unsorted state by clicking the sorted dimension field.
        /// </summary>
        /// <returns></returns>
        public ActionResult allow_unsorting()
        {
            return View();
        }

        /// <summary>
        /// height Number|String
        /// The height of the PivotConfigurator. Numeric values are treated as pixels
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_height_as_a_number()
        {
            return View();
        }

        public ActionResult set_the_height_as_a_string()
        {
            return View();
        }

        /// <summary>
        /// messages Object
        /// The text messages displayed in the fields sections.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages()
        {
            return View();
        }

        /// <summary>
        /// messages.measures String (default: "Drop Data Fields Here")
        /// The text messages displayed in the measure fields sections.
        /// </summary>
        /// <returns></returns>
        public ActionResult setting_measure_fields_section_default_text()
        {
            return View();
        }

        /// <summary>
        /// messages.columns String (default: "Drop Column Fields Here")
        /// The text messages displayed in the column fields sections.
        /// </summary>
        /// <returns></returns>
        public ActionResult setting_column_fields_section_default_text()
        {
            return View();
        }

        /// <summary>
        /// messages.rows String (default: "Drop Rows Fields Here")
        /// The text messages displayed in the row fields sections.
        /// </summary>
        /// <returns></returns>
        public ActionResult setting_row_fields_section_default_text()
        {
            return View();
        }

        /// <summary>
        /// messages.measuresLabel String (default: "Measures")
        /// The text messages displayed for measure label.
        /// </summary>
        /// <returns></returns>
        public ActionResult setting_measure_label_text()
        {
            return View();
        }

        /// <summary>
        /// messages.rowsLabel String (default: "Rows")
        /// The text messages displayed for rows label.
        /// </summary>
        /// <returns></returns>
        public ActionResult setting_row_label_text()
        {
            return View();
        }

        /// <summary>
        /// messages.columnsLabel String (default: "Columns")
        /// The text messages displayed for column label
        /// </summary>
        /// <returns></returns>
        public ActionResult setting_column_label_text()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldsLabel String (default: "Fields")
        /// The text messages displayed for fields label.
        /// </summary>
        /// <returns></returns>
        public ActionResult setting_fields_label_text()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu Object
        /// The text messages displayed in the field menu.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.info String (default: "Show items with value that:")
        /// The text messages displayed in fields filter.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_info()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.sortAscending String (default: "Sort Ascending")
        /// The text message displayed for the menu item which performs ascending sort.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_sortAscending()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.sortDescending String (default: "Sort Descending")
        /// The text message displayed for the menu item which performs descending sort.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_sortDescending()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.filterFields String (default: "Fields Filter")
        /// The text messages of the fields filter menu item.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_filterFields()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.filter String (default: "Filter")
        /// The text messages of the filter button.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_filter()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.include String (default: "Include Fields...")
        /// The text messages of the include menu item.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_include()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.title String (default: "Fields to include")
        /// The title of the include fields dialog.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_title()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.clear String (default: "Clear")
        /// The text of the clear filter expressions button.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_clear()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.ok String (default: "Ok")
        /// The text of the OK button in the include fields dialog.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_ok()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.cancel String (default: "Cancel")
        /// The text of the cancel button in the include fields dialog.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_cancel()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.operators Object
        /// The text of the filter operators displayed in the filter menu.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_operators()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.operators.contains String (default: "Contains")
        /// The text of the "contains" filter operator.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_operators_contains()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.operators.doesnotcontain String (default: "Does not contain")
        /// The text of the "Does not contain" filter operator.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_operators_doesnotcontain()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.operators.startswith String (default: "Starts with")
        /// The text of the "Starts with" filter operator.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_operators_startswith()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.operators.endswith String (default: "Ends with")
        /// The text of the "Ends with" filter operator.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_operators_endswith()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.operators.eq String (default: "Is equal to")
        /// The text of the "equal" filter operator.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_operators_eq()
        {
            return View();
        }

        /// <summary>
        /// messages.fieldMenu.operators.neq String (default: "Is not equal to")
        /// The text of the "not equal" filter operator.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_fieldMenu_operators_neq()
        {
            return View();
        }

        /// <summary>
        /// dataSource kendo.data.PivotDataSource
        /// The data source of the widget. Configured via the dataSource option.
        /// Changes of the data source will be reflected in the widget.
        /// Assigning a new data source would have no effect. Use the setDataSource method instead.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_reference_to_the_widget_data_source()
        {
            return View();
        }

        /// <summary>
        /// Prepares the widget for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// This method does not remove the widget element from DOM.
        /// </summary>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// refresh
        /// Refresh widget content
        /// </summary>
        /// <returns></returns>
        public ActionResult refresh_the_widget()
        {
            return View();
        }

        /// <summary>
        /// setDataSource
        /// Sets the data source of the widget.
        /// Parameters
        /// dataSource kendo.data.PivotDataSource
        /// The data source to which the widget should be bound.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_data_source()
        {
            return View();
        }

    }
}