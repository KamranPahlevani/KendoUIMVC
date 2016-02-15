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
    }
}