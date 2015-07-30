using MvcDemoSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemoSample.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            var model =
                from r in _reviews
                orderby r.City
                select r;
            return View(model);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        static List<RestaurantReview> _reviews = new List<RestaurantReview>
        {
            new RestaurantReview
                        {
                            Id = 1,
                            Name="Kamath",
                            City="mysuru",
                            Country="India",
                            Rating=10,

},
new RestaurantReview
                        {
                            Id = 2,
                            Name="Mylari",
                            City="Bangaluru",
                            Country="India",
                            Rating=7,

},
new RestaurantReview
                        {
                            Id = 1,
                            Name="Krishna",
                            City="Udupi",
                            Country="India",
                            Rating=6,

},

        };

    }
}
