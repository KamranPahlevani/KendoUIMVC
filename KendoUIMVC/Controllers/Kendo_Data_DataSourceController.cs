using KendoUIMVC.infrastructure;
using KendoUIMVC.Models;
using KendoUIMvcApplication.Infrastructure;
using KendoUIMvcApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace KendoUIMVC.Controllers
{
    public class Kendo_Data_DataSourceController : Controller
    {
        //
        // GET: /Kendo_Data_DataSource/

        public JsonResult GetProducts()
        {
            IList<Product> ProductsList = new ProductRepository().GetProducts();
            return Json(ProductsList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSuppliers()
        {
            IList<Supplier> SuppliersList = new SupplierRepository().GetSuppliers();
            return Json(SuppliersList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCustomers()
        {
            IList<Customer> CustomersList = new CustomerRepository().GetCustomers();
            return Json(CustomersList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetProductsBySupplier(string selectedSuppliersListJsonObj)
        {
            IList<int> selectedSuppliersList = JsonConvert.DeserializeObject<List<int>>(selectedSuppliersListJsonObj);
            IList<Product> productsList = new ProductRepository().GetProducts().Where(x => selectedSuppliersList.Contains(x.SupplierID)).ToList<Product>();
            return Json(productsList, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// عملیات های محاسباتی        
        /// The supported aggregates are "average", "count", "max", "min" and "sum".
        /// The data item field which will be used to calculate the aggregates.
        /// </summary>
        /// <returns></returns>
        public ActionResult aggregateArray()
        {
            return View();
        }

        /// <summary>
        /// ذخیره خودکار تغییرات بر روی منبع داده
        /// بطور پیش فرض تغییرات بر روی منبع داده ذخیره نمی شوند چون مقدار اتو سینک فالز می باشد
        /// </summary>
        /// <returns></returns>
        public ActionResult autoSync()
        {
            return View();
        }

        /// <summary>
        /// اگر اتوسینک ترو باشد بعد از تغییر منبع داده ایتم تغییر یافته منبع داده در قالب ابجکتی از مدل به متد اکشن تعیین شده ارسال می شود
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public ActionResult UpdateProduct(Product p)
        {
            return View("autoSync");
        }
        
        /// <summary>
        /// ذخیره دسته ای تغییرات بر روی منبع داده در قالب یک درخواست اچ تی تی پی 
        ///  پیش فرض فالز می باشد  یعنی به ازای هر عملیات ایجاد یا خواندن یا ویرایش یا حذف یک درخواست اچ تی تی پی صادر می شود
        /// </summary>
        /// <returns></returns>
        public ActionResult batch()
        {
            return View();
        }

        /// <summary>
        /// اگر بچ ترو باشد ایتم های تغییر یافته از منبع داده در قالب ریکوئست پارامترز به متد اکشن تعیین شده ارسال می شود
        /// </summary>
        /// <returns></returns>
        public ActionResult UpdateProducts()
        {
            return View("batch");
        }

        /// <summary>
        /// منبع داده از نوع ایکس ام ال
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_data_items_as_an_XML_string() {
            return View();
        }

        /// <summary>
        /// اعمال فیلتر عادی بر روی منبع داده
        /// Parameters: field, operator, value
        /// </summary>
        /// <returns></returns>
        public ActionResult set_a_single_filter()
        {
            return View();
        }

        /// <summary>
        /// ایجاد فیلتر ترکیبی
        /// </summary>
        /// <returns></returns>
        public ActionResult set_filter_as_conjunction_and()
        {
            return View();
        }
            
        /// <summary>
        /// ایجاد فیلتر تفکیکی
        /// </summary>
        /// <returns></returns>
        public ActionResult set_filter_as_disjunction_or()
        {
            return View();
        }       

        /// <summary>
        /// گروه بندی منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult set_group_as_an_object()                
        {                       
            return View();
        }
            
        /// <summary>
        /// گروه بندی ترکیبی منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult set_group_as_an_array()
        {
            return View();
        }           

        /// <summary>
        /// گروه بندی صعودی یا نزولی منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult group_dir()
        {
            return View();
        }

        /// <summary>
        /// انجام عملیات محاسباتی بر اساس گروه بندی منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult group_aggregates()
        {
            return View();
        }

        /// <summary>
        /// صفحه بندی و تقاضای صفحه بندی منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult pageNumber()
        {
            return View();
        }

        /// <summary>
        /// تنظیمات مورد استفاده در تجزیه پاسخ ریموت سرویس
        /// </summary>
        /// <returns></returns>
        public ActionResult schema()
        {
            return View();
        }

        /// <summary>
        /// تنظیمات خطای بازگشتی در تجزیه پاسخ ریموت سرویس
        /// </summary>
        /// <returns></returns>
        public ActionResult schema_errors()
        {
            return View();
        }

        /// <summary>
        ///  عملیات محاسباتی در تجزیه پاسخ ریموت سرویس
        /// The aggregates option is used only when the serverAggregates option is set to true
        /// </summary>
        /// <returns></returns>
        public ActionResult schema_aggregates()
        {
            return View();
        }

        /// <summary>
        /// گروه بندی ها در تجزیه پاسخ ریموت سرویس
        /// The groups option is used only when the serverGrouping option is set to true
        /// </summary>
        /// <returns></returns>
        public ActionResult schema_groups()
        {
            return View();
        }


        /// <summary>
        /// تعریف مدل برای اسکیمای منبع داده
        /// If set to an existing kendo.data.Model instance the data source will use that instance and will not initialize a new one.        
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_model_as_a_JavaScript_object()
        {
            return View();
        }

        /// <summary>
        /// تعریف مدل برای اسکیمای منبع داده
        /// If set to an object the Model.define method will be used to initialize the data source model
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_model_as_an_existing_kendo_data_Model_instance()
        {
            return View();
        }

        /// <summary>
        /// به منظور پردازش اولیه یا تجزیه پاسخ سرور مورد استفاده قرار می گیرد
        /// </summary>
        /// <returns></returns>
        public ActionResult schema_parse()
        {
            return View();
        }

        /// <summary>
        /// فیلدی که تعداد کل دیتا ایتم های پاسخ داده شده از سرور را باز میگرداند
        /// </summary>
        /// <returns></returns>
        public ActionResult schema_total()
        {
            return View();
        }

        /// <summary>
        /// منبع داده از اژاکس جی کوئری برای ارسال درخواست اچ تی تی پی به ریموت سرویس استفاده می کند
        /// created model items sent as Request.Params["models"] in json format
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_create_remote_service()
        {
            return View();
        }

        /// <summary>
        /// به جای استفاده مستقیم از اژاکس جی کوئری یک فانکشن فراخوانی می شود
        /// created model items sent as Request.Params["models"] in json format
        /// </summary>
        /// <returns></returns>
        public ActionResult set_create_as_a_function()
        {
            return View();
        }

        public void CreateProducts()
        {
        }

        /// <summary>
        /// منبع داده از اژاکس جی کوئری برای ارسال درخواست اچ تی تی پی به ریموت سرویس استفاده می کند
        /// removed model items sent as Request.Params["models"] in json format
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_destroy_remote_service()
        {
            return View();
        }

        /// <summary>
        /// به جای استفاده مستقیم از اژاکس جی کوئری یک فانکشن فراخوانی می شود
        /// removed model items sent as Request.Params["models"] in json format
        /// </summary>
        /// <returns></returns>
        public ActionResult set_destroy_as_a_function()
        {
            return View();
        }

        public void DestroyProducts()
        { 
        }

        /// <summary>
        /// انصراف از کلیه تغییرات اعمال شده بر روی منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult cancel_all_changes()
        {
            return View();
        }

        /// <summary>
        /// انصراف از تغییرات اعمال شده بر روی یک دیتا آیتم از منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult cancel_changes_of_only_one_data_item()
        {
            return View();
        }

        /// <summary>
        /// متد اعمال فیلتر بر روی منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_data_source_filter()
        {
            return View();
        }

        /// <summary>
        /// متد اخذ اعمال فیلتر از منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_data_source_filter()
        {
            return View();
        }

        /// <summary>
        /// اخذ دیتا آیتم از طریق شناسه
        /// The get method requires the schema.model option to be set and the id of the model to be specified
        /// </summary>
        /// <returns></returns>
        public ActionResult find_a_model_by_id()
        {
            return View();
        }

        /// <summary>
        /// متد گروه بندی منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult group_the_data_items()
        {
            return View();
        }

        /// <summary>
        /// متد اخذ تنظیمات گروه بندی منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_data_source_grouping_configuration()
        {
            return View();
        }

        /// <summary>
        /// متد تشخیص اینکه آیا منبع داده تغییرات داشته است یا خیر
        /// </summary>
        /// <returns></returns>
        public ActionResult check_if_the_data_source_has_changes()
        {
            return View();
        }

        /// <summary>
        /// متد اخذ ایندکس دیتا آیتم در منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_index_of_a_data_item()
        {
            return View();
        }

        /// <summary>
        /// متد اضافه نمودن دیتا آیتم در ایندکس تعیین شده از منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult  insert_a_data_item()
        {
            return View();
        }

        /// <summary>
        /// متد تعیین صفحه جاری از منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_current_page()
        {
            return View();
        }

        /// <summary>
        /// متد اخذ صفحه جاری از منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_current_page()
        {
            return View();
        }

        /// <summary>
        /// متد تعیین اندازه صفحه منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_page_size()
        {
            return View();
        }

        /// <summary>
        /// متد اخذ اندازه صفحه منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_page_size()
        {
            return View();
        }

        /// <summary>
        /// اجرای کوئری بر روی دیتا آیتم های منبع داده که اگر به ریموت سرویس متصل باشد یک درخواست اچ تی تی پی ایجاد می کند 
        /// </summary>
        /// <returns></returns>
        public ActionResult query_the_data_source()
        {
            return View();
        }

        /// <summary>
        /// متد حذف دیتا آیتم از منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult remove_a_data_item()
        {
            return View();
        }

        /// <summary>
        /// متد مرتب سازی دیتا آیتم های منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult sort_the_data_items()
        {
            return View();
        }

        /// <summary>
        /// متد اخذ تنظیمات مرتب سازی دیتا آیتم های منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_sort_configuration()
        {
            return View();
        }

        /// <summary>
        /// متد اخذ تعداد کل دیتا آیتم های منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_total_number_of_data_items()
        {
            return View();
        }

        /// <summary>
        /// متد اخذ تعداد کل صفحات منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_total_number_of_pages()
        {
            return View();
        }

        /// <summary>
        /// اخذ دیتا آیتم های صفحه بندی شده و مرتب شده از منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_paged_and_sorted_data_items()
        {
            return View();
        }

        /// <summary>
        /// اخذ دیتا آیتم های صفحه بندی شده و گروه بندی شده و مرتب شده از منبع داده
        /// </summary>
        /// <returns></returns>
        public ActionResult get_the_paged_sorted_and_grouped_data_items()
        {
            return View();
        }

        /// <summary>
        /// رویداد تغییر منبع داده در حین مقدار دهی اولیه 
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_change_event_during_initialization()
        {
            return View();
        }

        /// <summary>
        /// رویداد تغییر منبع داده بعد از مقدار دهی اولیه 
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_change_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// رویداد خطا منبع داده در حین مقدار دهی اولیه 
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_error_event_during_initialization()
        {
            return View();
        }

        /// <summary>
        /// رویداد پایان درخواست داده در حین مقدار دهی اولیه 
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_requestEnd_event_during_initialization()
        {
            return View();
        }

        /// <summary>
        /// رویداد پایان درخواست داده بعد از مقدار دهی اولیه 
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_requestEnd_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// رویداد شروع درخواست داده در حین مقدار دهی اولیه 
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_requestStart_event_during_initialization()
        {
            return View();
        }

        /// <summary>
        /// رویداد شروع درخواست داده بعد از مقدار دهی اولیه 
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_requestStart_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// رویداد سینک درخواست داده در حین مقدار دهی اولیه 
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_sync_event_during_initialization()
        {
            return View();
        }

        /// <summary>
        /// رویداد سینک درخواست داده بعد از مقدار دهی اولیه 
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_sync_event_after_initialization()
        {
            return View();
        }

    }
}
