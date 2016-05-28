using MvcKendo.infrastructure;
using MvcKendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_UI_AutoCompleteController : Controller
    {
        //
        // GET: /Kendo_UI_AutoComplete/

        public JsonResult GetCountries()
        {
            string[] Countries = (new CountryRepository()).GetCountries();
            return Json(Countries, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetFruits()
        {
            IList<Fruit> FruitsList = new FruitRepository().GetFruits();
            return Json(FruitsList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult disable_open_and_close_animations()
        {
            return View();
        }

        public ActionResult configure_the_animation()
        {
            return View();
        }

        public ActionResult set_dataSource_as_a_JavaScript_object()
        {
            return View();
        }

        public ActionResult set_dataSource_as_an_existing_kendo_data_DataSource_instance()
        {
            return View();
        }

        public ActionResult set_the_delay()
        {
            return View(); 
        }

        public ActionResult disable_the_widget()
        {
            return View(); 
        }

        public ActionResult set_the_filter()
        {
            return View(); 
        }

        public ActionResult set_the_height()
        {
            return View(); 
        }

        public ActionResult set_highlightFirst()
        {
            return View(); 
        }

        public ActionResult disable_case_insensitive_suggestions()
        {
            return View(); 
        }

        public ActionResult set_minLength()
        {
            return View();  
        }

        public ActionResult enable_automatic_suggestion()
        {
            return View();   
        }

        public ActionResult specify_template_as_a_function()
        {
            return View();
        }

        public ActionResult specify_template_as_a_string()
        {
            return View(); 
        }

        public ActionResult add_a_data_item_to_the_data_source()
        {
            return View();
        }

        public ActionResult close_the_suggestion_popup()
        {
            return View();
        }

        public ActionResult get_the_item_at_certain_index()
        {
            return View();
        }

        public ActionResult destroy()
        {
            return View();
        }

        public ActionResult enable_the_widget()
        {
            return View();
        }

        public ActionResult make_the_widget_readonly()
        {
            return View();
        }

        public ActionResult focus_the_widget()
        {
            return View();
        }

        public ActionResult refresh_the_widget()
        {
            return View();
        }

        public ActionResult select_item()
        {
            return View();
        }

        public ActionResult suggest()
        {
            return View();
        }

        public ActionResult set_and_get_the_value_of_the_widget()
        {
            return View();
        }

        public ActionResult subscribe_to_the_change_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_change_event_after_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_close_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_close_event_after_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_dataBound_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_dataBound_event_after_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_open_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_open_event_after_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_select_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_select_event_after_initialization()
        {
            return View();
        }

        public ActionResult RTL()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to show a customized template, when the entered values does not match any of the suggestions.
        /// </summary>
        /// <returns></returns>
        public ActionResult Add_No_records_found_template()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to change dynamically the DataSource based on selection made via radio buttons
        /// </summary>
        /// <returns></returns>
        public ActionResult Change_DataSource_dynamically_based_on_user_selection()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to highlight the matched values from the AutoComplete suggestions based on the value entered by the user.
        /// </summary>
        /// <returns></returns>
        public ActionResult Highlight_matched_values_from_the_user_input()
        {
            return View();
        }

    }
}
