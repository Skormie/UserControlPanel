using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UserControlPanel.DAL;
using UserControlPanel.Models;

namespace UserControlPanel.Controllers
{
    public class CharacterController : Controller
    {
        private CPContext db = new CPContext();

        // GET: Character
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "";
            //ViewBag.NameSortParm = sortOrder == "Level" ? "Class" : "Level";
            ViewBag.CurrentSort = sortOrder;

            if (searchString != null)
                page = 1;
            else
                searchString = currentFilter;

            ViewBag.CurrentFilter = searchString;

            var characters = from s in db.Character select s;

            if (!String.IsNullOrEmpty(searchString))
                characters = characters.Where(s => s.Name.Contains(searchString) || s.Class.ToString().Contains(searchString));

            switch (sortOrder)
            {
                case "Name":
                    characters = characters.OrderByDescending(s=> s.Name);
                    break;
                case "Level":
                    characters = characters.OrderByDescending(s => s.Level);
                    break;
                case "Class":
                    characters = characters.OrderBy(s => s.Class);
                    break;
                default:
                    characters = characters.OrderBy(s => s.ID);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(/*db.Character.ToList()*/ /*characters.ToList()*/ characters.ToPagedList(pageNumber, pageSize));
        }

        // GET: Character/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Character.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // GET: Character/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Character/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LoginID,Name,Level,Class,Experience,Next,CharacterCreationDate")] Character character)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Character.Add(character);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("","Unable to save changes. Please try something different.");
            }

            return View(character);
        }

        // GET: Character/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Character.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // POST: Character/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LoginID,Name,Level,Class,Experience,Next,CharacterCreationDate")] Character character)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(character).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("","Unable to save changes. Please try something different.");
            }
            return View(character);
        }

        // GET: Character/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Character.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // POST: Character/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Character character = db.Character.Find(id);
                db.Character.Remove(character);
                db.SaveChanges();
            }
            catch (DataException)
            {
                ModelState.AddModelError("","Unable to save changes. Please try something different.");
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
