using KendoUIMvcApplication.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_PivotGridController : Controller
    {

        /// <summary>
        /// dataSource Object|kendo.data.PivotDataSource
        /// The data source of the widget which is used to display values. Can be a JavaScript object which represents a valid data source configuration or an existing kendo.data.PivotDataSource instance.
        /// If the dataSource option is set to a JavaScript object the widget will initialize a new kendo.data.PivotDataSource instance using that value as data source configuration.
        /// If the dataSource option is an existing kendo.data.PivotDataSource instance the widget will use that instance and will not initialize a new one.
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
        /// autoBind Boolean (default: true)
        /// If set to false the widget will not bind to the data source during initialization.
        /// In this case data binding will occur when the change event of the data source is fired.
        /// By default the widget will bind to the data source specified in the configuration.
        /// Setting autoBind to false is useful when multiple widgets are bound to the same data source.
        /// Disabling automatic binding ensures that the shared data source doesn't make more than one request to the remote service.
        /// </summary>
        /// <returns></returns>
        public ActionResult autoBind()
        {
            return View();
        }

        /// <summary>
        /// reorderable Boolean (default: true)
        /// If set to false the user will not be able to add/close/reorder current fields for columns/rows/measures.
        /// </summary>
        /// <returns></returns>
        public ActionResult reorderable()
        {
            return View();
        }

        /// <summary>
        /// excel Object
        /// Configures the Kendo UI PivotGrid Excel export settings.
        /// excel.fileName String (default: "Export.xslx")
        /// Specifies the file name of the exported Excel file.
        /// </summary>
        /// <returns></returns>
        public ActionResult excel_fileName()
        {
            return View();
        }

        /// <summary>
        /// excel.filterable Boolean (default: false)
        /// Enables or disables column filtering in the Excel file.
        /// Not to be mistaken with the pivotgrid filtering feature.
        /// </summary>
        /// <returns></returns>
        public ActionResult excel_filterable()
        {
            return View();
        }

        /// <summary>
        /// excel.forceProxy Boolean (default: false)
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// excel.proxyURL String (default: null)
        /// The URL of the server side proxy which will stream the file to the end user.
        /// A proxy will be used when the browser isn't capable of saving files locally. Such browsers are IE version 9 and lower and Safari.
        /// The developer is responsible for implementing the server-side proxy.
        /// The proxy will receive a POST request with the following parameters in the request body:
        /// contentType: The MIME type of the file
        /// base64: The base-64 encoded file content
        /// fileName: The file name, as requested by the caller.
        /// The proxy should return the decoded file with the "Content-Disposition" header set to attachment; filename="<fileName.xslx>".
        /// </summary>
        /// <returns></returns>
        public ActionResult excel_proxyURL()
        {
            return View();
        }

        /// <summary>
        /// pdf Object
        /// Configures the Kendo UI PivotGrid PDF export settings.
        /// pdf.author String (default: null)
        /// The author of the PDF document.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_author()
        {
            return View();
        }

        /// <summary>
        /// pdf.creator String (default: "Kendo UI PDF Generator")
        /// The creator of the PDF document.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_creator()
        {
            return View();
        }

        /// <summary>
        /// pdf.date Date
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_date()
        {
            return View();
        }

        /// <summary>
        /// pdf.keywords String (default: null)
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_keywords()
        {
            return View();
        }

        /// <summary>
        /// pdf.landscape Boolean (default: false)
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_landscape()
        {
            return View();
        }

        /// <summary>
        /// pdf.margin Object
        /// Specifies the margins of the page (numbers or strings with units). Supported units are "mm", "cm", "in" and "pt" (default).
        /// pdf.margin.bottom Number|String (default: 0)
        /// The bottom margin. Numbers are considered as "pt" units.
        /// pdf.margin.left Number|String (default: 0)
        /// The left margin. Numbers are considered as "pt" units.
        /// pdf.margin.right Number|String (default: 0)
        /// The right margin. Numbers are considered as "pt" units.
        /// pdf.margin.top Number|String (default: 0)
        /// The top margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_margin()
        {
            return View();
        }

        /// <summary>
        /// pdf.paperSize String|Array (default: "auto")
        /// Specifies the paper size of the PDF document. The default "auto" means paper size is determined by content.
        /// The size of the content in pixels will match the size of the output in points (1 pixel = 1/72 inch).
        /// Supported values:
        /// A predefined size: "A4", "A3" etc
        /// An array of two numbers specifying the width and height in points (1pt = 1/72in)
        /// An array of two strings specifying the width and height in units. Supported units are "mm", "cm", "in" and "pt".
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_paperSize()
        {
            return View();
        }

        /// pdf.forceProxy Boolean (default: false)
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// pdf.proxyURL String (default: null)
        /// The URL of the server side proxy which will stream the file to the end user.
        /// A proxy will be used when the browser isn't capable of saving files locally e.g. Internet Explorer 9 and Safari. PDF export is not supported in Internet Explorer 8 and below.
        /// The developer is responsible for implementing the server-side proxy.
        /// The proxy will receive a POST request with the following parameters in the request body:
        /// contentType: The MIME type of the file
        /// base64: The base-64 encoded file content
        /// fileName: The file name, as requested by the caller.
        /// The proxy should return the decoded file with the "Content-Disposition" header set to attachment; filename="<fileName.pdf>".
        public ActionResult pdf_proxyURL()
        {
            return View();
        }

        /// <summary>
        /// pdf.proxyTarget String (default: "_self")
        /// A name or keyword indicating where to display the document returned from the proxy.
        /// If you want to display the document in a new window or iframe, the proxy should set the "Content-Disposition" header to inline; filename="<fileName.pdf>".
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_proxyTarget()
        {
            return View();
        }

        /// <summary>
        /// pdf.subject String (default: null)
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_subject()
        {
            return View();
        }

        /// <summary>
        /// pdf.title String (default: null)
        /// Sets the title of the PDF file.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_title()
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
        /// If set to true the user could sort the pivotgrid by clicking the dimension fields. By default sorting is disabled.
        /// Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <returns></returns>
        public ActionResult sortable()
        {
            return View();
        }

        /// <summary>
        /// sortable.allowUnsort Boolean (default: true)
        /// If set to true the user can get the pivotgrid in unsorted state by clicking the sorted dimension field.
        /// </summary>
        /// <returns></returns>
        public ActionResult sortable_allowUnsort()
        {
            return View();
        }

        /// <summary>
        /// columnWidth Number
        /// The width of the table columns. Value is treated as pixels.
        /// </summary>
        /// <returns></returns>
        public ActionResult columnWidth()
        {
            return View();
        }

        /// <summary>
        /// height Number|String
        /// The height of the PivotGrid. Numeric values are treated as pixels.
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
        /// columnHeaderTemplate String|Function
        /// The template which renders the content of the column header cell. By default it renders the caption of the tuple member.
        /// The fields which can be used in the template are:
        /// member - the member of the corresponding column header cell
        /// tuple - the tuple of the corresponding column header cell
        /// </summary>
        /// <returns></returns>
        public ActionResult columnHeaderTemplate()
        {
            return View();
        }

        /// <summary>
        /// dataCellTemplate String|Function
        /// The template which renders the content of the data cell. By default renders the formatte d value (fmtValue) of the data item.
        /// The fields which can be used in the template are:
        /// columnTuple - the tuple of the corresponding column header cell
        /// rowTuple - the tuple of the corresponding row header cell
        /// measure - the value of the data cell measure
        /// dataItem - the data item itself
        /// </summary>
        /// <returns></returns>
        public ActionResult dataCellTemplate()
        {
            return View();
        }

        /// <summary>
        /// kpiStatusTemplate String|Function
        /// The template which renders the content of the KPI Status value. By default renders "open", "hold" and "denied" status icons.
        /// The fields which can be used in the template are:
        /// columnTuple - the tuple of the corresponding column header cell
        /// rowTuple - the tuple of the corresponding row header cell
        /// measure - the value of the data cell measure
        /// dataItem - the data item itself
        /// </summary>
        /// <returns></returns>
        public ActionResult kpiStatusTemplate()
        {
            return View();
        }

        /// <summary>
        /// kpiTrendTemplate String|Function
        /// The template which renders the content of the KPI Trend value. By default renders "increase", "decrease" and "equal" status icons.
        /// The fields which can be used in the template are:
        /// columnTuple - the tuple of the corresponding column header cell
        /// rowTuple - the tuple of the corresponding row header cell
        /// measure - the value of the data cell measure
        /// dataItem - the data item itself
        /// </summary>
        /// <returns></returns>
        public ActionResult kpiTrendTemplate()
        {
            return View();
        }

        /// <summary>
        /// The template which renders the content of the row header cell. By default it renders the caption of the tuple member.
        /// The fields which can be used in the template are:
        /// member - the member of the corresponding row header cell
        /// tuple - the tuple of the corresponding row header cell
        /// </summary>
        /// <returns></returns>
        public ActionResult rowHeaderTemplate()
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
        /// messages.measureFields String (default: "Drop Measure Here")
        /// The text messages displayed in the measure fields sections.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_measureFields()
        {
            return View();
        }

        /// <summary>
        /// messages.columnFields String (default: "Drop Column Here")
        /// The text messages displayed in the column fields sections.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_columnFields()
        {
            return View();
        }

        /// <summary>
        /// messages.rowFields String (default: "Drop Rows Here")
        /// The text messages displayed in the row fields sections.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_rowFields()
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
        public ActionResult PivotDataSource()
        {
            return View();
        }

        /// <summary>
        /// cellInfo
        /// Returns an information about a data cell at a specific column and row index.
        /// Parameters
        /// columnIndex Number
        /// The index of the column cell that crosses the data cell.
        /// rowIndex Number
        /// The index of the row cell that crosses the data cell.
        /// Returns
        /// Object the data cell information.
        /// The fields of the result object:
        /// columnTuple - the tuple of the corresponding column header cell
        /// rowTuple - the tuple of the corresponding row header cell
        /// measure - the measure value of the data cell
        /// dataItem - the data item itself
        /// </summary>
        /// <returns></returns>
        public ActionResult cellInfo()
        {
            return View();
        }

        /// <summary>
        /// cellInfoByElement
        /// Returns an information about for a specific data cell element
        /// Parameters
        /// cell String|Element|jQuery
        /// A string, DOM element or jQuery object which represents the data table cell. A string is treated as a jQuery selector.
        /// Returns
        /// Object the data cell information.
        /// The fields of the result object:
        /// columnTuple - the tuple of the corresponding column header cell
        /// rowTuple - the tuple of the corresponding row header cell
        /// measure - the measure value of the data cell
        /// dataItem - the data item itself
        /// </summary>
        /// <returns></returns>
        public ActionResult cellInfoByElement()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Prepares the widget for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// This method does not remove the widget element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// refresh
        /// Renders all content using the current data items.
        /// </summary>
        /// <returns></returns>
        public ActionResult refresh()
        {
            return View();
        }

        /// <summary>
        /// Sets the data source of the widget.
        /// Parameters
        /// dataSource kendo.data.PivotDataSource
        /// The data source to which the widget should be bound.
        /// </summary>
        /// <returns></returns>
        public ActionResult setDataSource()
        {
            return View();
        }

        /// <summary>
        /// Initiates the Excel export. Also fires the excelExport event.
        /// Calling this method could trigger the browser built-in popup blocker in some cases. To avoid that, always call it as a response to an end-user action e.g. button click.
        /// </summary>
        /// <returns></returns>
        public ActionResult saveAsExcel()
        {
            return View();
        }

        /// <summary>
        /// Initiates the PDF export and returns a promise. Also triggers the pdfExport event.
        /// Calling this method may trip the built-in browser pop-up blocker. To avoid that, call this method as a response to an end-user action, e.g. a button click.
        /// Returns
        /// Promise A promise that will be resolved when the export completes. The same promise is available in the pdfExport event arguments.
        /// </summary>
        /// <returns></returns>
        public ActionResult saveAsPDF()
        {
            return View();
        }

        /// <summary>
        /// dataBinding
        /// Fired before the widget binds to its data source.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.preventDefault Function
        /// If invoked prevents the data bind action. The PivotGrid will remain unchanged and dataBound event will not fire.
        /// e.sender kendo.ui.PivotGrid
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_dataBinding_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_dataBinding_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// dataBound
        /// Fired after the widget is bound to the data from its data source.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.sender kendo.ui.PivotGrid
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
        /// expandMember
        /// Fired before column or row field is expanded.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.preventDefault Function
        /// If invoked prevents the expand and the widget will remain in its current state.
        /// e.sender kendo.ui.PivotGrid
        /// The widget instance which fired the event.
        /// e.axis String
        /// The axis that will be expanded. Possible values columns or rows.
        /// e.path String
        /// The path to the field that will be expanded.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_expandMember_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_expandMember_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// collapseMember
        /// Fired before column or row field is collapsed.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.preventDefault Function
        /// If invoked prevents the collapse and the widget will remain in its current state.
        /// e.sender kendo.ui.PivotGrid
        /// The widget instance which fired the event.
        /// e.axis String
        /// The axis that will be collapsed. Possible values columns or rows.
        /// e.path String
        /// The path to the field that will be collapsed.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_collapseMember_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_collapseMember_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// excelExport
        /// Fired when saveAsExcel method is called.
        /// Event Data
        /// e.sender kendo.ui.PivotGrid
        /// The widget instance which fired the event.
        /// e.data Array
        /// The array of data items used to create the Excel workbook.
        /// e.workbook Object
        /// The Excel workbook configuration object. Used to initialize a kendo.ooxml.Workbook class. Modifications of the workbook will reflect in the output Excel document.
        /// e.preventDefault Function
        /// If invoked the grid will not save the generated file.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_excelExport_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_excelExport_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// pdfExport
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// Event Data
        /// e.sender kendo.ui.PivotGrid
        /// The widget instance which fired the event.
        /// e.preventDefault Function
        /// If invoked the grid will not save the generated file.
        /// e.promise Promise
        /// A promise that will be resolved when the export completes.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_pdfExport_event_during_initialization()
        {
            return View();
        }


        public ActionResult subscribe_to_the_pdfExport_event_after_initialization()
        {
            return View();
        }

        public ActionResult Access_MDX_query()
        {
            return View();
        }

        public ActionResult Add_dimension_to_column_axis()
        {
            ViewBag.Products = JsonConvert.SerializeObject(new ProductRepository().GetProducts(), Formatting.None);
            return View();
        }

        public ActionResult Change_data_source_dynamically()
        {
            ViewBag.Products = JsonConvert.SerializeObject(new ProductRepository().GetProducts(), Formatting.None);
            return View();
        }

        public ActionResult Chart_intergration()
        {
            return View();
        }

        public ActionResult Filter_a_dimension()
        {
            return View();
        }

        public ActionResult Modify_the_measure_tag_caption()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to right align the text of the data cells of Kendo UI PivotGrid
        /// </summary>
        /// <returns></returns>
        public ActionResult Right_aligned_text()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to display a tooltip hint when hover PivotGrid data cell element 
        /// </summary>
        /// <returns></returns>
        public ActionResult Show_tooltip_with_data_cell_information()
        {
            ViewBag.Products = JsonConvert.SerializeObject(new ProductRepository().GetProducts(), Formatting.None);
            return View();
        }


    }
}