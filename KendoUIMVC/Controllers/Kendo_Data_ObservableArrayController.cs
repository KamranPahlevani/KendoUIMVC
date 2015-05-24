using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_Data_ObservableArrayController : Controller
    {
        //
        // GET: /Kendo_Data_ObservableArray/

        public ActionResult Creating_a_New_ObservableArray()
        {
            return View();
        }

        public ActionResult Using_the_kendo_observable_Method()
        {
            return View();
        }

        public ActionResult ObservableArray_of_Complex_and_Primitive_Type()
        {
            return View();
        }

        public ActionResult Iterating_Over_ObservableArray()
        {
            return View();
        }

        /// <summary>
        /// برقراری ارتباط بین هندلر و رویداد
        /// </summary>
        /// <returns></returns>
        public ActionResult bind()
        {
            return View();
        }

        /// <summary>
        /// تبدیل تمام آیتم های آرایه به یک رشته با استفاده از یک جدا کننده
        /// </summary>
        /// <returns></returns>
        public ActionResult join()
        {
            return View();
        }

        public ActionResult parent()
        {
            return View();
        }

        /// <summary>
        /// آخرین آیتم آرایه را حذف و آن را بر می گرداند
        /// </summary>
        /// <returns></returns>
        public ActionResult pop()
        {
            return View();
        }

        /// <summary>
        /// آیتم جدید را به آرایه اضافه و طول جدید آرایه را بر می گرداند
        /// </summary>
        /// <returns></returns>
        public ActionResult push()
        {
            return View();
        }

        public ActionResult Append_more_than_one_item_to_an_ObservableArray()
        {
            return View();
        }

        /// <summary>
        /// یک کپی از عمق یک سطحی را بر می گرداند
        /// begin Number : Zero-based index at which to begin extraction.
        /// end Number : Zero-based index at which to end extraction. If end is omitted, slice extracts to the end of the sequence.
        /// </summary>
        /// <returns></returns>
        public ActionResult slice()
        {
            return View();
        }

        /// <summary>
        /// تغییر آرایه با اضافه کردن آیتم های جدید همزمان با حذف آیتم های قدیمی
        /// index Number : Index at which to start changing the array. If negative, will begin that many elements from the end.
        /// howMany Number : An integer indicating the number of items to remove. If howMany is 0, no items are removed. In this case, you should specify at least one new item.
        /// </summary>
        /// <returns></returns>
        public ActionResult splice()
        {
            return View();
        }

        /// <summary>
        /// اولین آیتم آرایه را حذف و آن را بر می گرداند
        /// </summary>
        /// <returns></returns>
        public ActionResult shift()
        {
            return View();
        }

        public ActionResult toJSON()
        {
            return View();
        }

        /// <summary>
        /// یک یا چند آیتم جدید را به ابتدای آرایه اضافه کرده و طول جدید آرایه را بر می گرداند
        /// </summary>
        /// <returns></returns>
        public ActionResult unshift()
        {
            return View();
        }

        /// <summary>
        /// رویداد تغییر در آرایه
        /// Event Data : e.action String, e.index Number, e.items Array, e.field String 
        /// </summary>
        /// <returns></returns>
        public ActionResult change()
        {
            return View();
        }

    }
}
