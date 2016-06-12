using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_UI_GridController : Controller
    {
        //
        // GET: /Kendo_UI_Grid/

        public ActionResult specify_alternating_row_template_as_a_function()
        {
            return View();
        }

        public ActionResult specify_alternating_row_template_as_a_string()
        {
            return View();
        }

        /// <summary>
        /// (default: true)
        /// If set to false the widget will not bind to the data source during initialization.
        /// In this case data binding will occur when the change event of the data source is fired.
        /// By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <returns></returns>
        public ActionResult autoBind()
        {
            return View();
        }

        /// <summary>
        /// The configuration of the grid columns. 
        /// An array of JavaScript objects or strings. 
        /// A JavaScript objects are interpreted as column configurations. 
        /// Strings are interpreted as the field to which the column is bound. 
        /// The grid will create a column for every item of the array.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_grid_columns_as_array_of_strings()
        {
            return View();
        }

        /// <summary>
        /// The configuration of the grid columns. 
        /// An array of JavaScript objects or strings. 
        /// A JavaScript objects are interpreted as column configurations. 
        /// Strings are interpreted as the field to which the column is bound. 
        /// The grid will create a column for every item of the array.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_grid_columns_as_array_of_objects()
        {
            return View();
        }

        /// <summary>
        /// The aggregate(s) which are calculated when the grid is grouped by the columns field.
        /// The supported aggregates are "average", "count", "max", "min" and "sum".
        /// </summary>
        /// <returns></returns>
        public ActionResult set_column_aggregates()
        {
            return View();
        }

        /// <summary>
        /// HTML attributes of the table cell (<td>) rendered for the column.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_column_HTML_attributes()
        {
            return View();
        }

        /// <summary>
        /// The configuration of the column command(s). If set the column would display a button for every command. Commands can be custom or built-in ("edit" or "destroy").
        /// The "edit" built-in command switches the current table row in edit mode.
        /// The "destroy" built-in command removes the data item to which the current table row is bound.
        /// Custom commands are supported by specifying the click option.
        /// The built-in "edit" and "destroy" commands work only if editing is enabled via the editable option. The "edit" command supports "inline" and "popup" editing modes.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_command_as_a_string()
        {
            return View();
        }

        public ActionResult set_command_as_array_of_strings()
        {
            return View();
        }

        public ActionResult set_command_as_array_of_objects()
        {
            return View();
        }

        /// <summary>
        /// The name of the command. The built-in commands are "edit" and "destroy". Can be set to a custom value.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_command_name()
        {
            return View();
        }

        public ActionResult customize_the_text_of_the_command()
        {
            return View();
        }

        public ActionResult set_the_CSS_class_of_the_command()
        {
            return View();
        }

        public ActionResult handle_the_click_event_of_the_custom_command_button()
        {
            return View();
        }

        public ActionResult create_a_custom_column_editor_using_the_Kendo_UI_AutoComplete()
        {
            return View();
        }

        /// <summary>
        /// If set to true the column value will be HTML-encoded before it is displayed.
        /// If set to false the column value will be displayed as is. By default the column value is HTML-encoded.
        /// </summary>
        /// <returns></returns>
        public ActionResult prevent_HTML_encoding()
        {
            return View();
        }

        public ActionResult disable_filtering()
        {
            return View();
        }

        public ActionResult specify_the_filter_UI_as_a_string()
        {
            return View();
        }

        public ActionResult initialize_the_filter_UI()
        {
            return View();
        }

        public ActionResult specify_column_footer_template()
        {
            return View();
        }

        public ActionResult customize_filter_menu_messages()
        {
            return View();
        }

        public ActionResult specify_the_column_format_string()
        {
            return View();
        }

        /// <summary>
        /// The template which renders the group header when the grid is grouped by the column field.
        /// By default the name of the field and the current group value is displayed.
        /// The fields which can be used in the template are:
        /// value - the current group value
        /// average - the value of the "average" aggregate (if specified)
        /// count - the value of the "count" aggregate (if specified)
        /// max - the value of the "max" aggregate (if specified)
        /// min - the value of the "min" aggregate (if specified)
        /// sum - the value of the "sum" aggregate (if specified)
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_group_header_template()
        {
            return View();
        }

        /// <summary>
        /// The template which renders the group footer when the grid is grouped by the column field.
        /// By default the group footer is not displayed.
        /// The fields which can be used in the template are:
        /// average - the value of the "average" aggregate (if specified)
        /// count - the value of the "count" aggregate (if specified)
        /// max - the value of the "max" aggregate (if specified)
        /// min - the value of the "min" aggregate (if specified)
        /// sum - the value of the "sum" aggregate (if specified)
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_group_footer_template()
        {
            return View();
        }

        /// <summary>
        /// HTML attributes of the column header. The grid renders a table header cell (<th>) for every column.
        /// The headerAttributes option can be used to set the HTML attributes of that th.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_column_header_HTML_attributes()
        {
            return View();
        }

        /// <summary>
        /// The template which renders the column header content.
        /// By default the value of the title column option is displayed in the column header cell.
        /// If sorting is enabled, the column header content will be wrapped in a <a> element.
        /// As a result the template must contain only inline elements.
        /// </summary>
        /// <returns></returns>
        public ActionResult column_header_template_as_a_string()
        {
            return View();
        }

        public ActionResult hide_columns()
        {
            return View();
        }

        /// <summary>
        /// If set to true the user can click the column header and sort the grid by the column field when sorting is enabled.
        /// If set to false sorting will be disabled for this column.
        /// By default all columns are sortable if sorting is enabled via the sortable option.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_sorting()
        {
            return View();
        }

        public ActionResult set_the_template_as_a_string()
        {
            return View();
        }

        public ActionResult set_the_template_as_a_function_returned_by_kendo_template()
        {
            return View();
        }

        public ActionResult set_the_template_as_a_function_which_returns_a_string()
        {
            return View();
        }

        public ActionResult set_the_title_of_the_column()
        {
            return View();
        }

        public ActionResult set_the_column_width_as_a_string()
        {
            return View();
        }

        public ActionResult set_the_column_width_as_a_number()
        {
            return View();
        }

        /// <summary>
        /// An array of values that will be displayed instead of the bound value. 
        /// Each item in the array must have a text and value fields.
        /// Use the values option to display user-friendly text instead of database values.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_column_values()
        {
            return View();
        }

        /// <summary>
        /// If set to true the column will be visible in the grid column menu. 
        /// By default the column menu includes all data-bound columns (ones that have their field set).
        /// </summary>
        /// <returns></returns>
        public ActionResult hide_a_column_from_the_column_menu()
        {
            return View();
        }

        public ActionResult enable_the_column_menu()
        {
            return View();
        }

        /// <summary>
        /// If set to true the column menu would allow the user to select (show and hide) grid columns.
        /// By default the column menu allows column selection.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_column_selection()
        {
            return View();
        }

        /// <summary>
        /// If set to true the column menu would allow the user to filter the grid.
        /// By default the column menu allows the user to filter if filtering is enabled via the filterable.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_column_menu_filtering()
        {
            return View();
        }

        /// <summary>
        /// If set to true the column menu would allow the user to sort the grid by the column field.
        /// By default the column menu allows the user to sort if sorting is enabled via the sortable option.
        /// If this option is set to false the user could still sort by clicking the column header cell.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_column_menu_sorting()
        {
            return View();
        }

        /// <summary>
        /// The text messages displayed in the column menu.
        /// Use it to customize or localize the column menu messages.
        /// </summary>
        /// <returns></returns>
        public ActionResult customize_column_menu_messages()
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

        public ActionResult specify_detail_template_as_a_function()
        {
            return View();
        }

        public ActionResult specify_detail_template_as_a_string()
        {
            return View();
        }

        /// <summary>
        /// If set to true the user would be able to edit the data to which the grid is bound to. By default editing is disabled.
        /// Can be set to a string ("inline", "incell" or "popup") to specify the editing mode. The default editing mode is "incell".
        /// Can be set to a JavaScript object which represents the editing configuration.
        /// The "inline" and "popup" editing modes are triggered by the "edit" column command. Thus it is required to have a column with an "edit" command.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_editing()
        {
            return View();
        }

        public ActionResult enable_popup_editing()
        {
            return View();
        }

        public ActionResult disable_delete_confirmation()
        {
            return View();
        }

        public ActionResult set_delete_confirmation_text()
        {
            return View();
        }

        /// <summary>
        /// The positon at which new data items are inserted in the grid. Must be set to either "top" or "bottom".
        /// By default new data items are inserted at the top.
        /// </summary>
        /// <returns></returns>
        public ActionResult insert_new_data_items_at_the_bottom()
        {
            return View();
        }

        /// <summary>
        /// If set to true the user can delete data items from the grid by clicking the "destroy" command button.
        /// Deleting is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_deleting()
        {
            return View();
        }

        /// <summary>
        /// The editing mode to use. The supported editing modes are "incell", "inline" and "popup".
        /// The "inline" and "popup" editing modes are triggered by the "edit" column command.
        /// Thus it is required to have a column with an "edit" command.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_inline_editing_mode()
        {
            return View();
        }

        /// <summary>
        /// The template which renders popup editor.
        /// The template should contain elements whose name HTML attributes are set as the editable fields.
        /// This is how the grid will know which field to update.
        /// The other option is to use MVVM bindings in order to bind HTML elements to data item fields.
        /// Use the role data attribute to initialize Kendo UI widgets in the template.
        /// Check data attribute initialization for more info.
        /// </summary>
        /// <returns></returns>
        public ActionResult customize_the_popup_editor()
        {
            return View();
        }

        public ActionResult using_MVVM_in_the_popup_editor_template()
        {
            return View();
        }

        public ActionResult enable_only_deleting()
        {
            return View();
        }

        public ActionResult enable_the_filtering()
        {
            return View();
        }

        public ActionResult disable_the_extra_filtering_criteria()
        {
            return View();
        }

        /// <summary>
        /// The text of the radio button for false values.
        /// Displayed when filtering Boolean fields
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_isFalse_message()
        {
            return View();
        }

        /// <summary>
        /// The text of the radio button for true values.
        /// Displayed when filtering Boolean fields.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_isTrue_message()
        {
            return View();
        }

        /// <summary>
        /// The text of the dropdownlist displayed in the filter menu for columns whose values option is set.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_selectValue_message()
        {
            return View();
        }

        public ActionResult set_string_operators()
        {
            return View();
        }

        public ActionResult set_the_string_starts_with_operator()
        {
            return View();
        }

        public ActionResult set_the_string_contains_operator()
        {
            return View();
        }

        public ActionResult set_the_string_does_not_contain_operator()
        {
            return View();
        }

        public ActionResult set_the_string_ends_with_operator()
        {
            return View();
        }

        public ActionResult set_number_operators()
        {
            return View();
        }

        public ActionResult set_the_number_greater_than_or_equal_to_operator()
        {
            return View();
        }

        public ActionResult set_the_number_greater_than_operator()
        {
            return View();
        }

        public ActionResult set_the_number_less_than_or_equal_to_operator()
        {
            return View();
        }

        public ActionResult set_the_number_less_than_operator()
        {
            return View();
        }

        public ActionResult set_date_operators()
        {
            return View();
        }

        public ActionResult set_the_date_equal_operator()
        {
            return View();
        }

        public ActionResult set_the_date_not_equal_operator()
        {
            return View();
        }

        public ActionResult set_the_date_greater_than_or_equal_operator()
        {
            return View();
        }

        public ActionResult set_the_date_greater_than_operator()
        {
            return View();
        }

        public ActionResult set_the_date_less_than_or_equal_operator()
        {
            return View();
        }

        public ActionResult set_the_date_less_than_operator()
        {
            return View();
        }


        public ActionResult set_enum_operators()
        {
            return View();
        }

        public ActionResult enable_grouping()
        {
            return View();
        }

        public ActionResult set_the_empty_grouping_message()
        {
            return View();
        }

        /// <summary>
        /// The height of the grid. Numeric values are treated as pixels.
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

        public ActionResult set_the_label_before_the_pager_input()
        {
            return View();
        }

        /// <summary>
        /// If set to true the use could navigate the widget using the keyboard navigation.
        /// By default keyboard navigation is disabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_keyboard_navigation()
        {
            return View();
        }

        /// <summary>
        /// If set to true the grid will display a pager. By default paging is disabled.
        /// Can be set to a JavaScript object which represents the pager configuration.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_paging()
        {
            return View();
        }

        /// <summary>
        /// If set to true the pager will display buttons for going to the first, previous, next and last pages.
        /// By default those buttons are displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult hide_the_first_previous_next_and_last_buttons()
        {
            return View();
        }

        /// <summary>
        /// If set to true the pager will display buttons for navigating to specific pages.
        /// By default those buttons are displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult hide_the_numeric_pager_buttons()
        {
            return View();
        }

        /// <summary>
        /// The maximum number of buttons displayed in the numeric pager.
        /// The pager will display ellipsis (...) if there are more pages than the specified number.
        /// default: 10
        /// </summary>
        /// <returns></returns>
        public ActionResult set_pager_button_count()
        {
            return View();
        }

        /// <summary>
        /// If set to true the pager will display an input element which allows the user to type a specific page number.
        /// By default the page input is not displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult show_the_pager_input()
        {
            return View();
        }

        /// <summary>
        /// If set to true the pager will display a dropdown list which allows the user to pick a page size.
        /// By default the page size dropdown list is not displayed.
        /// Can be set to an array with the available page sizes.
        /// </summary>
        /// <returns></returns>
        public ActionResult show_the_page_size_dropdown()
        {
            return View();
        }

        public ActionResult specify_the_page_sizes_as_array()
        {
            return View();
        }

        /// <summary>
        /// If set to true the pager will display the refresh button.
        /// Clicking the refresh button will refresh the grid.
        /// By default the refresh button is not displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult show_the_refresh_button()
        {
            return View();
        }

        /// <summary>
        /// If set to true the pager will display information about the current page and total number of data items.
        /// By default the paging information is displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult hide_the_paging_information()
        {
            return View();
        }

        /// <summary>
        /// Contains three placeholders: - {0} - the first data item index - {1} - the last data item index - {2} - the total number of data items
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_display_pager_message()
        {
            return View();
        }

        /// <summary>
        /// The text displayed when the grid is empty.
        /// </summary>
        /// <returns></returns>
        public ActionResult  set_the_empty_pager_message()
        {
            return View();
        }

        /// <summary>
        /// The label displayed before the pager input. Uses kendo.format.
        /// Contains one optional placeholder {0} which represents the total number of pages.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_label_after_the_pager_input()
        {
            return View();
        }

        /// <summary>
        /// The label displayed after the page size dropdown list.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_label_after_the_page_size_dropdown_list()
        {
            return View();
        }

        public ActionResult set_the_tooltip_of_the_first_page_button()
        {
            return View();
        }

        public ActionResult set_the_tooltip_of_the_last_page_button()
        {
            return View();
        }

        public ActionResult set_the_tooltip_of_the_next_page_button()
        {
            return View();
        }

        public ActionResult set_the_tooltip_of_the_previous_page_button()
        {
            return View();
        }

        public ActionResult set_the_tooltip_of_the_refresh_button()
        {
            return View();
        }

        /// <summary>
        /// If set to true the user could reorder the columns by dragging their header cells.
        /// By default reordering is disabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_column_reordering()
        {
            return View();
        }

        public ActionResult enable_column_resizing()
        {
            return View();
        }

        public ActionResult disable_scrolling()
        {
            return View();
        }

        /// <summary>
        /// If set to true the user would be able to select grid rows. By default selection is disabled.
        /// Can also be set to the following string values:
        /// "row" - the user can select a single row.
        /// "cell" - the user can select a single cell.
        /// "multiple, row" - the user can select multiple rows.
        /// "multiple, cell" - the user can select multiple cells.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_selectable_as_a_boolean()
        {
            return View();
        }

        public ActionResult set_selectable_as_a_string()
        {
            return View();
        }

        /// <summary>
        /// If set to true the user could sort the grid by clicking the column header cells.
        /// By default sorting is disabled.
        /// Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_sorting()
        {
            return View();
        }

        /// <summary>
        /// If set to true the user can get the grid in unsorted state by clicking the sorted column header.
        /// </summary>
        /// <returns></returns>
        public ActionResult do_not_allow_unsorting()
        {
            return View();
        }

        /// <summary>
        /// The sorting mode. If set to "single" the user can sort by one column.
        /// If set to "multiple" the user can sort by one column.
        /// </summary>
        /// <returns></returns>
        public ActionResult allow_multiple_column_sorting()
        {
            return View();
        }

        /// <summary>
        /// The list of commands displayed in the grid toolbar. Commands can be custom or built-in ("cancel", "create", "save").
        /// The "cancel" built-in command reverts any data changes done by the end user.
        /// The "create" command adds an empty data item to the grid.
        /// The "save" command persists any data changes done by the end user.
        /// </summary>
        /// <returns></returns>
        public ActionResult configure_the_grid_toolbar()
        {
            return View();
        }

        /// <summary>
        /// The name of the toolbar command.
        /// Either a built-in ("cancel", "create" and "save") or custom.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_the_name_of_the_command()
        {
            return View();
        }

        public ActionResult set_the_toolbar_template_as_a_function()
        {
            return View();
        }

        public ActionResult set_the_toolbar_template_as_a_string()
        {
            return View();
        }

        public ActionResult set_the_text_of_the_toolbar_button()
        {
            return View();
        }

        /// <summary>
        /// The columns of the grid initialized from the columns option.
        /// Every item from the columns array has the same fields as the corresponding columns option.
        /// </summary>
        /// <returns></returns>
        public ActionResult iterate_the_grid_columns()
        {
            return View();
        }

        /// <summary>
        /// The data source of the widget. Configured via the dataSource option.
        /// Changes of the data source will be reflected in the widget.
        /// Assigning a new data source would have no effect. Use the setDataSource method instead.
        /// </summary>
        /// <returns></returns>
        public ActionResult add_a_data_item_to_the_data_source()
        {
            return View();
        }

        public ActionResult update_a_data_item_in_the_data_source()
        {
            return View();
        }

        public ActionResult remove_a_data_item_from_the_data_source()
        {
            return View();
        }

        /// <summary>
        /// The jQuery object which represents the table body.
        /// Contains all grid table rows.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_first_table_row()
        {
            return View();
        }

        /// <summary>
        /// Adds an empty data item to the grid.
        /// In "incell" and "inline" 
        /// ing mode a table row will be appended.
        /// Popup window will be displayed in "popup" editing mode.
        /// Fires the edit event.
        /// </summary>
        /// <returns></returns>
        public ActionResult add_a_new_data_item()
        {
            return View();
        }

        /// <summary>
        /// Cancels any pending changes in the data source.
        /// Deleted data items are restored, new data items are removed and updated data items are restored to their initial state.
        /// </summary>
        /// <returns></returns>
        public ActionResult cancel_any_changes()
        {
            return View();
        }

        /// <summary>
        /// Cancels editing for the table row which is in edit mode.
        /// Reverts any changes made.
        /// </summary>
        /// <returns></returns>
        public ActionResult cancel_editing()
        {
            return View();
        }

        /// <summary>
        /// Returns the index of the specified table cell.
        /// Skips group and detail table cells.
        /// </summary>
        /// <returns></returns>
        public ActionResult find_the_cell_index_when_the_cell_is_a_jQuery_object()
        {
            return View();
        }

        public ActionResult find_the_cell_index_when_the_cell_is_a_string()
        {
            return View();
        }

        /// <summary>
        /// Clears the currently selected table rows or cells (depending on the current selection mode).
        /// </summary>
        /// <returns></returns>
        public ActionResult clear_selection()
        {
            return View();
        }

        /// <summary>
        /// Stops editing the table cell which is in edit mode.
        /// Requires "incell" edit mode.
        /// </summary>
        /// <returns></returns>
        public ActionResult cancel_cell_editing()
        {
            return View();
        }

        /// <summary>
        /// Collapses the specified group.
        /// This hides the group items.
        /// A string, DOM element or jQuery object which represents the group table row. A string is treated as a jQuery selector.
        /// </summary>
        /// <returns></returns>
        public ActionResult collapse_the_first_group()
        {
            return View();
        }

        /// <summary>
        /// Collapses the specified master table row.
        /// This hides its detail table row.
        /// A string, DOM element or jQuery object which represents the master table row. A string is treated as a jQuery selector.
        /// </summary>
        /// <returns></returns>
        public ActionResult collapse_the_first_master_table_row()
        {
            return View();
        }

        /// <summary>
        /// Returns the data item to which the specified table row is bound.
        /// A string, DOM element or jQuery object which represents the table row.
        /// A string is treated as a jQuery selector.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_data_item_to_which_the_first_table_row_is_bound()
        {
            return View();
        }

        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// Switches the specified table cell in edit mode.
        /// Requires "inline" or "popup" edit mode.
        /// Fires the edit event.
        /// </summary>
        /// <returns></returns>
        public ActionResult switch_the_first_cell_to_edit_mode()
        {
            return View();
        }

        /// <summary>
        /// Switches the specified table cell in edit mode.
        /// Requires "inline" or "popup" edit mode.
        /// Fires the edit event.
        /// </summary>
        /// <returns></returns>
        public ActionResult switch_the_first_row_in_edit_mode()
        {
            return View();
        }

        /// <summary>
        /// Expands the specified group. This shows the group items.
        /// A string, DOM element or jQuery object which represents the group table row.
        /// A string is treated as a jQuery selector. Expands specified group.
        /// </summary>
        /// <returns></returns>
        public ActionResult expand_the_first_group()
        {
            return View();
        }

        /// <summary>
        /// Expands the specified master table row. This shows its detail table row.
        /// A string, DOM element or jQuery object which represents the master table row.
        /// A string is treated as a jQuery selector. Expands specified master row.
        /// </summary>
        /// <returns></returns>
        public ActionResult expand_the_first_master_table_row()
        {
            return View();
        }

        public ActionResult hide_a_column_by_index()
        {
            return View();
        }

        public ActionResult hide_a_column_by_field()
        {
            return View();
        }

        public ActionResult refresh_the_widget()
        {
            return View();
        }

        /// <summary>
        /// Removes the specified table row from the grid. 
        /// Also removes the corresponding data item from the data source.
        /// Fires the remove event.
        /// A string, DOM element or jQuery object which represents the table row.
        /// A string is treated as a jQuery selector.
        /// </summary>
        /// <returns></returns>
        public ActionResult remove_the_first_table_row()
        {
            return View();
        }

        /// <summary>
        /// Changes the position of the specified column.
        /// </summary>
        /// <returns></returns>
        public ActionResult move_a_column()
        {
            return View();
        }

        /// <summary>
        /// Saves any pending changes by calling the sync method.
        /// Fires the saveChanges event.
        /// </summary>
        /// <returns></returns>
        public ActionResult save_changes()
        {
            return View();
        }

        /// <summary>
        /// Switches the table row which is in edit mode and saves any changes made by the user.
        /// </summary>
        /// <returns></returns>
        public ActionResult save_row()
        {
            return View();
        }

        /// <summary>
        /// Gets or sets the table rows (or cells) which are selected.
        /// A string, DOM element or jQuery object which represents the table row(s) or cell(s).
        /// A string is treated as a jQuery selector.
        /// </summary>
        /// <returns></returns>
        public ActionResult select_the_first_and_second_table_rows()
        {
            return View();
        }

        public ActionResult select_the_first_table_cell()
        {
            return View();
        }

        public ActionResult get_the_selected_table_row()
        {
            return View();
        }

        public ActionResult set_the_data_source()
        {
            return View();
        }

        public ActionResult show_a_hidden_column_by_index()
        {
            return View();
        }

        public ActionResult show_a_hidden_column_by_field()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user clicks the "cancel" button (in inline or popup editing mode) or closes the popup window.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_cancel_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_cancel_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user selects a table row or cell in the grid.
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_selected_data_items_when_using_row_selection()
        {
            return View();
        }

        public ActionResult get_the_selected_data_items_when_using_cell_selection()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user hides a column.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_columnHide_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_columnHide_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the column menu is initialized.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_columnMenuInit_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_columnMenuInit_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user changes the order of a column.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_columnReorder_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_columnReorder_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user resizes a column.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_columnResize_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_columnResize_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user shows a column.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_columnShow_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_columnShow_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired before the widget binds to its data source.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_dataBinding_event_before_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_dataBinding_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.
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
        /// Fired when the user collapses a detail table row.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_detailCollapse_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_detailCollapse_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user expands a detail table row.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_detailExpand_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_detailExpand_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when a detail table row is initialized.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_detailInit_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_detailInit_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user edits or creates a data item.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_edit_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_edit_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the grid filter menu is initialized.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_filterMenuInit_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_filterMenuInit_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user clicks the "destroy" command button.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_remove_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_remove_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when a data item is saved.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_save_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_save_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// Fired when the user clicks the "save" command button.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_saveChanges_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_saveChanges_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// The following example demonstrates how to acccess an editor control in the edit event handler.
        /// </summary>
        /// <returns></returns>
        public ActionResult Access_an_editor_control_in_edit_event_of_Kendo_UI_Grid()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to add a new row when the user navigates out of the last row in the grid.
        /// </summary>
        /// <returns></returns>
        public ActionResult Add_new_row_when_tabbed_out_of_the_last_row()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to create a custom dataSource based on the data in a custom editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult Build_datasource_with_currying_for_a_custom_editor()
        {
            return View();
        }

        /// <summary>
        /// Kendo UI Grid example that demonstrates how to customize the delete confirmation dialog using Kendo UI templates,
        /// Kendo UI Window widget and the remove method of the Grid's dataSource.
        /// </summary>
        /// <returns></returns>
        public ActionResult Customize_the_delete_confirmation_dialog_of_Kendo_UI_Grid()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to use custom editor outside the Kendo UI Grid, that uses the currently selected item.
        /// </summary>
        /// <returns></returns>
        public ActionResult Custom_editor_shown_outside_the_Grid_using_the_selected_date_item()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to delete multiple columns selected with checkboxes
        /// </summary>
        /// <returns></returns>
        public ActionResult Delete_multiple_columns_in_Grid_with_checkboxes()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to edit records in a child grid.
        /// </summary>
        public ActionResult Hierarchy_with_editable_detail_grid()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to customize the default Kendo UI delete confirmation alert box using Kendo UI Window
        /// </summary>
        /// <returns></returns>
        public ActionResult Custom_confirmation_window()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to create Kendo UI Grid with custom number editor using Kendo UI NumericTextBox
        /// </summary>
        /// <returns></returns>
        public ActionResult Custom_number_editor_using_Kendo_UI_NumericTextBox()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to render input editor in a column template, and provide editing functionality.
        /// </summary>
        /// <returns></returns>
        public ActionResult Editing_using_column_template()
        {
            return View();
        }

        /// <summary>
        /// This example demonstrates how to configure editing with custom UI form, create editors for string, number and boolean field and add validation.
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit_Kendo_UI_Grid_records_using_an_external_form()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to prevent page navigation when Kendo UI Grid is in edit mode.
        /// </summary>
        /// <returns></returns>
        public ActionResult Prevent_page_navigation_when_in_edit_mode()
        {
            return View();
        }

        /// <summary>
        /// This example demonstrates how to preserve the dirty indicator in incell editing and client operations.
        /// </summary>
        /// <returns></returns>
        public ActionResult Preserve_the_dirty_indicator_in_incell_editing_and_client_operations()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to prevent editing for a record based on a boolean field in the data item.
        /// </summary>
        /// <returns></returns>
        public ActionResult Prevent_editing_for_records_based_on_boolean_value()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to show edit buttons only for records that meet certain criteria.
        /// </summary>
        /// <returns></returns>
        public ActionResult Show_edit_buttons_for_editable_recrods_only()
        {
            return View();
        }

        /// <summary>
        /// This example shows how to customize the Excel document that the grid generates during exporting.
        /// The demo uses the background option of the cell to set the background color of the alternating rows.
        /// To understand how Excel documents work check the Excel Introduction help topic.
        /// </summary>
        /// <returns></returns>
        public ActionResult excel_alternating_rows()
        {
            return View();
        }

        /// <summary>
        /// To format the cell values set the format option of the cells.
        /// The Create a custom number format page describes the formats that Excel supports.
        /// </summary>
        /// <returns></returns>
        public ActionResult Set_Cell_Format_During_Excel_export()
        {
            return View();
        }

        /// <summary>
        /// This example shows how to use the column template as the value of corresponding cell in the output Excel document. For additional info check Create Excel Documents.
        /// </summary>
        /// <returns></returns>
        public ActionResult Column_Template_Excell_Export()
        {
            return View();
        }

        /// <summary>
        /// This demo shows how to export the detail grids and merge their workbooks with the master grid workbook.
        /// The uses the excelExport event to get the workbook of the detail grids.
        /// The event is prevented to avoid saving an Excel file for every detail grid. For additional info check Create Excel Documents.
        /// </summary>
        /// <returns></returns>
        public ActionResult Detail_Grid_Excel_Export()
        {
            return View();
        }

        /// <summary>
        /// This example shows how to export two Kendo UI grids in the same Excel document.
        /// Each grid is exported in a separate Excel sheet. For additional info check Create Excel Documents.
        /// </summary>
        /// <returns></returns>
        public ActionResult Multiple_Grid_Export()
        {
            return View();
        }

        /// <summary>
        /// Kendo Grid example that demonstrates how to apply minimum column width during column resize.
        /// </summary>
        /// <returns></returns>
        public ActionResult Apply_minimum_width_during_column_resize()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to create auto layout for the Kendo UI Grid.
        /// Please note that the auto layout requires disabled Grid scrolling
        /// </summary>
        /// <returns></returns>
        public ActionResult Creating_and_using_auto_layout()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to change the group header position,
        /// when locked columns are used, in order to show them on the right table.
        /// </summary>
        /// <returns></returns>
        public ActionResult Change_group_header_position_with_locked_columns()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to adjust the row height of a Kendo UI Grid with virtual scrolling enabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult Adjust_row_height_in_with_virtual_scrolling()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to use FontAwesome icons inside a Kendo UI Grid custom command button.
        /// </summary>
        /// <returns></returns>
        public ActionResult FontAwesome_icons_in_custom_command_buttons()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to resize the Kendo UI Grid when the parent window is resized.
        /// Web standards require elements with a percentage height to have a parent with an explicit height.
        /// The rule applies recursively until an element with a pixel height is reached, or the root HTML element is reached.
        /// In the latter case the BODY and HTML elements need a 100% height style as well. 100% high elements cannot have margins, paddings, borders and siblings.
        /// </summary>
        /// <returns></returns>
        public ActionResult Resize_grid_when_the_window_is_resized()
        {
            return View();
        }

        /// <summary>
        /// This example demonstrates how to export the full Grid content in a PDF file.
        /// This includes all data pages as well as scrolled content. The content will be scaled to fit in the specified page size.
        /// </summary>
        /// <returns></returns>
        public ActionResult Export_a_PDF_including_all_Grid_page()
        {
            return View();
        }

        /// <summary>
        /// This example demonstrates how to: - select grid row using a checkbox - preserve that selection between pages - get the selected item IDs from all pages
        /// </summary>
        /// <returns></returns>
        public ActionResult Kendo_UI_Grid_selection_with_checkbox_column()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to persists row selection in a grid, while different pages of the dataSource are shown.
        /// </summary>
        /// <returns></returns>
        public ActionResult Persist_row_selection_while_paging()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to prevent the cell selection for checkbox cell or any cell.
        /// </summary>
        /// <returns></returns>
        public ActionResult Prevent_selection_for_checkbox_cell()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to select multiple rows using checkbox template.
        /// </summary>
        /// <returns></returns>
        public ActionResult Select_multiple_rows_with_checkboxes()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to create custom editor in a Kendo UI Grid detail template
        /// </summary>
        /// <returns></returns>
        public ActionResult Custom_editor_in_detail_template()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to use checkboxes in Kendo UI Grid column templates and perform editing.
        /// </summary>
        /// <returns></returns>
        public ActionResult Checkbox_template_column_and_editing()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to refresh a child grid in a detail template using external button
        /// </summary>
        /// <returns></returns>
        public ActionResult Refresh_grid_in_detail_template()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to use dates inside a Kendo UI Grid row template.
        /// </summary>
        /// <returns></returns>
        public ActionResult Row_template_using_dates()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to add a Kendo UI tooltip for grid cell record.
        /// </summary>
        /// <returns></returns>
        public ActionResult Add_tooltip_for_grid_cell()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to set cell text color based on the ForeignKey values.
        /// </summary>
        /// <returns></returns>
        public ActionResult Set_cell_text_color_based_on_the_ForeignKey_values()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to create checkbox filter menu functionality in a Kendo UI Grid
        /// </summary>
        /// <returns></returns>
        public ActionResult Checkbox_filter_menu_filtering()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to use checkboxes inside a Kendo UI Grid column menu.
        /// </summary>
        /// <returns></returns>
        public ActionResult Column_menu_using_checkboxes()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to create a Kendo UI Grid that supports pasting from Excel
        /// </summary>
        /// <returns></returns>
        public ActionResult Copy_data_from_Excel()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to initialize a Kendo UI Grid using data attributes and include a detail template
        /// </summary>
        /// <returns></returns>
        public ActionResult Data_attribute_initialization_with_detail_template()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to enable sorting by text in ForeignKey column using calculated field.
        /// </summary>
        /// <returns></returns>
        public ActionResult ForeignKey_column_sorting_by_text()
        {
            return View();
        }

        /// <summary>
        /// This examples demonstrates how to add cascading DropDownList editors in Kendo UI Grid.
        /// </summary>
        /// <returns></returns>
        public ActionResult Add_cascading_DropDownList_editors()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to perform CRUD operations with local storage data.
        /// </summary>
        /// <returns></returns>
        public ActionResult CRUD_operations_with_local_storage_as_a_database()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to show Kendo UI Tooltip for Kendo UI Grid columns.
        /// </summary>
        /// <returns></returns>
        public ActionResult Show_Kendo_UI_Tooltip_for_columns_records()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to hide the detail grid and indicator when the parent dataSource returns an empty array.
        /// </summary>
        /// <returns></returns>
        public ActionResult Hide_the_detail_grid_and_indicator_when_the_DataSource_returns_empty_array()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to initialize a Kendo UI Grid widget in a SPA application.
        /// </summary>
        /// <returns></returns>
        public ActionResult Using_Grid_in_a_Kendo_UI_SPA_application()
        {
            return View();
        }

        /// <summary>
        /// The example demonstrates how to load more records when scrolling the Grid rows.
        /// The difference between this scenario and virtual scrolling is that here the number of records constantly increases,
        /// while virtual scrolling replaces the existing records with new ones. Please note that increasing the page size will make data requests slower.
        /// There are two things to be done: 1. Subscribe to the Grid's data container's scroll event and increment the page size by a desired value. 2.
        /// Use a flag to prevent multiple simultaneous page size increments.
        /// The flag should be set in the scroll event handler, and cleared in the Grid's dataBound event handler.
        /// </summary>
        /// <returns></returns>
        public ActionResult load_and_append_more_Grid_records_as_the_user_scrolls_down()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to use a Kendo UI MultiSelect widget for column filter.
        /// </summary>
        /// <returns></returns>
        public ActionResult Multiselect_used_for_column_filtering()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to persist expanded rows after refresh.
        /// </summary>
        /// <returns></returns>
        public ActionResult Persist_expanded_rows_after_refresh()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to persisted the collapsed state of grouped records in a Kendo UI Grid.
        /// </summary>
        /// <returns></returns>
        public ActionResult Persist_grouped_grid_collapsed_details_state()
        {
            return View();
        }

        /// <summary>
        /// This example demonstrates how to preserve the Grid state (filtering/sorting/paging/grouping and selection) in a cookie and restore it when the page is re-visited.
        /// Keep in mind that If you are running the page directly from the hard-drive in Chrome (not through web server),
        /// Chrome won't save cookies for this page and persistence won't be available.
        /// </summary>
        /// <returns></returns>
        public ActionResult Preserve_Grid_state_in_a_cookie()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to create a custom MVVM binding to update the toolbar content dynamically
        /// </summary>
        /// <returns></returns>
        public ActionResult Update_toolbar_content_using_MVVM_binding()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how nest a Kendo UI Chart inside the grid template
        /// </summary>
        /// <returns></returns>
        public ActionResult Use_nested_Kendo_UI_chart()
        {
            return View();
        }

        /// <summary>
        /// The following runnable sample demonstrates how to use nested model properties. CRUD operations are not fully configured.
        /// </summary>
        /// <returns></returns>
        public ActionResult Use_nested_model_properties()
        {
            return View();
        }

        /// <summary>
        /// To enable the adaptive rendering feature the developer should set mobile propery to true, phone or tablet.
        /// </summary>
        /// <returns></returns>
        public ActionResult Enabling_the_adaptive_rendering_feature()
        {
            return View();
        }

        public ActionResult Localization_of_the_toolbar_controls()
        {
            return View();
        }

        public ActionResult Localization_of_the_column_commands()
        {
            return View();
        }

        public ActionResult Localization_of_the_filter_menu()
        {
            return View();
        }

        public ActionResult Localization_of_the_grouping_header()
        {
            return View();
        }

        public ActionResult Localization_of_the_column_menu()
        {
            return View();
        }

        public ActionResult Localization_of_the_pager()
        {
            return View();
        }

        public ActionResult set_dataSource_as_a_JavaScript_object_byTypeScript()
        {
            return View();
        }

        public ActionResult set_dataSource_as_an_existing_kendo_data_DataSource_instance_byTypeScript()
        {
            return View();
        }

        public ActionResult specify_detail_template_as_a_function_byTypeScript() {
            return View();
        }

        public ActionResult specify_alternating_row_template_as_a_string_byTypeScript()
        {
            return View();
        }

        public ActionResult create_a_custom_column_editor_using_the_Kendo_UI_AutoComplete_byTypeScript()
        {
            return View();
        }






    }
}
