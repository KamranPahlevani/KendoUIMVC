using KendoUIMvcApplication.Infrastructure;
using KendoUIMvcApplication.Models;
using MvcKendo.infrastructure;
using MvcKendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_UI_ComboBoxController : Controller
    {
        //
        // GET: /Kendo_UI_ComboBox/

        public ActionResult animation()
        {
            return View();
        }

        public ActionResult animation_close()
        {
            return View();
        }

        public ActionResult animation_open()
        {
            return View();
        }

        public ActionResult enable()
        {
            return View();
        }

        public ActionResult filter()
        {
            return View();
        }

        /// <summary>
        /// Specifies the delay in ms after which the ComboBox will start filtering dataSource.
        /// </summary>
        /// <returns></returns>
        public ActionResult delay()
        {
            return View();
        }

        public ActionResult height()
        {
            return View();
        }

        public ActionResult highlightFirst()
        {
            return View();
        }

        public ActionResult ignoreCase()
        {
            return View();
        }

        public ActionResult index()
        {
            return View();
        }

        /// <summary>
        /// Specifies the minimum characters that should be typed before the ComboBox activates
        /// </summary>
        /// <returns></returns>
        public ActionResult minLength()
        {
            return View();
        }

        public ActionResult placeholder()
        {
            return View();
        }

        /// <summary>
        /// Controls whether the ComboBox should automatically auto-type the rest of text.
        /// </summary>
        /// <returns></returns>
        public ActionResult suggest()
        {
            return View();
        }

        public ActionResult template()
        {
            return View();
        }

        public ActionResult close()
        {
            return View();
        }

        public ActionResult dataItem()
        {
            return View();
        }

        public ActionResult destroy()
        {
            return View();
        }

        public ActionResult disable()
        {
            return View();
        }

        public ActionResult readOnly()
        {
            return View();
        }

        public ActionResult focus()
        {
            return View();
        }

        public ActionResult open()
        {
            return View();
        }

        public ActionResult refresh()
        {
            return View();
        }

        public ActionResult search()
        {
            return View();
        }

        /// <summary>
        /// Selects a dropdown item and sets the value and the text of the combobox, or retrieves the selected item index.
        /// </summary>
        /// <returns></returns>
        public ActionResult select()
        {
            return View();
        }

        public ActionResult setDataSource()
        {
            return View();
        }

        public ActionResult text()
        {
            return View();
        }

        public ActionResult toggle()
        {
            return View();
        }

        /// <summary>
        /// Gets/Sets the value of the combobox. If the value is undefined, text of the data item will be used.
        /// </summary>
        /// <returns></returns>
        public ActionResult value()
        {
            return View();
        }

        public ActionResult change_event()
        {
            return View();
        }

        public ActionResult close_event()
        {
            return View();
        }

        public ActionResult dataBound_event()
        {
            return View();
        }

        public ActionResult open_event()
        {
            return View();
        }

        public ActionResult select_event()
        {
            return View();
        }

        /// <summary>
        /// Triggered when value of the widget is changed via API or user interaction.
        /// </summary>
        /// <returns></returns>
        public ActionResult cascade_event()
        {
            return View();
        }

        public ActionResult RTL()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to add option label manually.
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_add_option_label_manually()
        {
            return View();
        }

        /// <summary>
        /// How to blur the ComboBox after select
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_blur_the_ComboBox_after_select()
        {
            return View();
        }

        public ActionResult How_to_bypass_boundary_detection_of_Kendo_UI_ComboBox()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to implement cascading with local data.
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_implement_cascading_with_local_data()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to clear filter on open.
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_clear_filter_on_open()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to declaratively initialize ComboBox with templates.
        /// </summary>
        /// <returns></returns>
        public ActionResult Declaratively_initialize_ComboBox_with_templates()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to configure deferred value binding.
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_configure_deferred_value_binding()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to use promises to detect when all widgets are bound
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_use_promises_to_detect_when_all_widgets_are_bound()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to disable child cascading ComboBox widget
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_disable_child_cascading_ComboBox_widget()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to expand Kendo UI ComboBox located in Bootstrap layout
        /// </summary>
        /// <returns></returns>
        public ActionResult how_to_expand_Kendo_UI_ComboBox_located_in_Bootstrap_layout()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to expand background of long list items of Kendo UI ComboBox
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_expand_the_background_of_long_list_items()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to search for dropped with the mouse text
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_make_search_for_dropped_with_the_mouse_text()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to prevent from POST on ENTER key press
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_prevent_from_POST_on_ENTER_key_press()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to make readonly visible input of Kendo UI ComboBox
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_make_Kendo_UI_ComboBox_visible_input_readonly()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to select item on TAB
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_select_item_on_TAB()
        {
            return View();
        }

        /// <summary>
        /// Example that shows how to underline matched search
        /// </summary>
        /// <returns></returns>
        public ActionResult How_to_underline_matched_search()
        {
            return View();
        }


    }
}
