using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EveryonesLibrary.Controllers
{
    public class searchController : Controller
    {
        //
        // GET: /search/

        public ActionResult Index(String s)
        {
            List<String> resultList = new List<String>();

            try
            {
                using (var db = new LibraryDB())
                {
                    var authorObj = (from a in db.Author where (a.FirstName.Contains(s) || a.LastName.Contains(s)) select a).ToList();
                    var bookObj = (from b in db.Book where b.Title.Contains(s) select b).ToList();

                    if (authorObj != null || bookObj != null)
                    {
                        foreach (var a in authorObj)
                        {
                            resultList.Add(a.FirstName + " " + a.LastName);
                        }

                        foreach (var b in bookObj)
                        {
                            resultList.Add(b.Title);
                        }
                        ViewBag.SearchResult = resultList;
                        return View();
                    }
                    else
                    {
                        return View(); // lists == null
                    }
                }
            }
            catch (NullReferenceException e)
            {
                return View(); //s.length == 0
            }
        }

        //
        // GET: /search/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /search/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /search/Create

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

        //
        // GET: /search/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /search/Edit/5

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

        //
        // GET: /search/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /search/Delete/5

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
    }
}
