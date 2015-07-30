//using MvcDemo.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace MvcDemo.Controllers
//{
//    public class ReviewController : Controller
//    {
//        //
//        // GET: /Review/
     

//        public ActionResult Index()
//        {
//            var model =
//                from r in _reviews
//                orderby r.City
//                select r;
//            return View(model);
           
//        }

//        //
//        // GET: /Review/Details/5

//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        //
//        // GET: /Review/Create

//        public ActionResult Create()
//        {
//            return View();
//        }

//        //
//        // POST: /Review/Create

//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Review/Edit/5

//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        //
//        // POST: /Review/Edit/5

//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Review/Delete/5

//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        //
//        // POST: /Review/Delete/5

//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//        static List<RestaurantReview> _reviews = new List<RestaurantReview>
//        {
//            new RestaurantReview
//                        {
//                            Id = 1,
//                            Name="Kamath",
//                            City="mysuru",
//                            Country="India",
//                            Rating=10,

//},
//new RestaurantReview
//                        {
//                            Id = 2,
//                            Name="Mylari",
//                            City="Bangaluru",
//                            Country="India",
//                            Rating=7,

//},
//new RestaurantReview
//                        {
//                            Id = 1,
//                            Name="Krishna",
//                            City="Udupi",
//                            Country="India",
//                            Rating=6,

//},

//        };

//    }
//}
