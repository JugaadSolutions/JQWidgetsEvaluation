using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemoSample.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
     //  [Authorize]
        public ActionResult search(string name="swedish")
        {
           

            var message=Server.HtmlEncode(name);
            return RedirectToAction(message);
        }
          }
}