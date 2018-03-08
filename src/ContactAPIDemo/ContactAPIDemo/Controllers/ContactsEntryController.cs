using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactAPIDemo.Controllers
{
    public class ContactsEntryController : Controller
    {
        // GET: ContactsEntry
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactsEntry/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
		public ActionResult Confirm(int id)
		{
			return View();

		}
        // GET: ContactsEntry/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactsEntry/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
					string Body="";
                // TODO: Add insert logic here
					 foreach (var key in collection.Keys)
					 {
						  Body += "<p><b>";
						  Body += key.ToString();
						  Body += ":</b> ";
						  Body += collection[key.ToString()];
						  Body += "</p>";
					 }
                return RedirectToAction("Confirm",3);
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactsEntry/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactsEntry/Edit/5
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

        // GET: ContactsEntry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactsEntry/Delete/5
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
