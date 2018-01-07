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
        public string Details(int id)
        {
            string message = "store details" + id;
            return message;
        }
    }
}