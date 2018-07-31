using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DeepSpaceDatabaseZ.Models;


namespace DeepSpaceDatabaseZ.Controllers
{
    public class SpaceObjectsController : Controller
    {
        private SpaceObjectDBContext db = new SpaceObjectDBContext();

       // GET: SpaceObjects
       //  public ActionResult Index()
       // {
       //     return View(db.SpaceObjects.ToList());
       // }

        public ActionResult Index(string Category, string searchString, string MinMagnitude, string isChecked)
        {
            var CatLst = new List<string>();

            var CatQry = from d in db.SpaceObjects
                         orderby d.Category
                         select d.Category;

            CatLst.AddRange(CatQry.Distinct());
            ViewBag.Category = new SelectList(CatLst);

            var sObjects = from m in db.SpaceObjects
                           select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                sObjects = sObjects.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(Category))
            {
                sObjects = sObjects.Where(x => x.Category == Category);
            }

            if (isChecked == "on" )

            {
                sObjects = from q in sObjects
                           orderby q.Name
                           select q;
                                          
            }

            try
            {

                if (!string.IsNullOrEmpty(MinMagnitude))
                {

                    var minNumb = Convert.ToDouble(MinMagnitude);
                    sObjects = sObjects.Where(p => p.Magnitude <= minNumb);

                }

                return View(sObjects);

            } 

            catch (FormatException)
            {
                return View(db.SpaceObjects);
            }



        }



        // GET: SpaceObjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpaceObject spaceObject = db.SpaceObjects.Find(id);
            if (spaceObject == null)
            {
                return HttpNotFound();
            }
            return View(spaceObject);
        }

        // GET: SpaceObjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SpaceObjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,URL,Name,Magnitude,Category,Distance")] SpaceObject spaceObject)
        {
            if (ModelState.IsValid)
            {
                db.SpaceObjects.Add(spaceObject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(spaceObject);
        }

        // GET: SpaceObjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpaceObject spaceObject = db.SpaceObjects.Find(id);
            if (spaceObject == null)
            {
                return HttpNotFound();
            }
            return View(spaceObject);
        }

        // POST: SpaceObjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,URL,Name,Magnitude,Category,Distance")] SpaceObject spaceObject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(spaceObject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(spaceObject);
        }

        // GET: SpaceObjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpaceObject spaceObject = db.SpaceObjects.Find(id);
            if (spaceObject == null)
            {
                return HttpNotFound();
            }
            return View(spaceObject);
        }

        // POST: SpaceObjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SpaceObject spaceObject = db.SpaceObjects.Find(id);
            db.SpaceObjects.Remove(spaceObject);
            db.SaveChanges();
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
