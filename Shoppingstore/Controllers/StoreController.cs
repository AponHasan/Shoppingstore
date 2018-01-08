using Shoppingstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shoppingstore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello Index";
        }
        public string browser(string category)
        {
            string message = HttpUtility.HtmlEncode("Showing category "+category);
            return message;
        }
        public ActionResult Details(int id)
        {
            var Item = new Item { Title = "Item" + id };
            return View(Item);
        }
    }
}