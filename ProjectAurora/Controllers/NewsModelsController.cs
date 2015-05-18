using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectAurora.Models;

namespace ProjectAurora.Controllers
{
    public class NewsModelsController : Controller
    {
        private GameInfoDbContext db = new GameInfoDbContext();

        // GET: NewsModels
        public ActionResult Index()
        {
            return View(db.NewsModels.ToList());
        }

        public ActionResult NewsPageTemp()
        {
            return View(db.NewsModels.ToList());
        }

        // GET: NewsModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsModel newsModel = db.NewsModels.Find(id);
            if (newsModel == null)
            {
                return HttpNotFound();
            }
            return View(newsModel);
        }

        // GET: NewsModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewsModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NewsTitle,NewsImageUrl,NewsPart1,VideoUrl,NewsPart2,Author")] NewsModel newsModel)
        {
            if (ModelState.IsValid)
            {
                db.NewsModels.Add(newsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newsModel);
        }

        // GET: NewsModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsModel newsModel = db.NewsModels.Find(id);
            if (newsModel == null)
            {
                return HttpNotFound();
            }
            return View(newsModel);
        }

        // POST: NewsModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NewsTitle,NewsImageUrl,NewsPart1,VideoUrl,NewsPart2,Author")] NewsModel newsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newsModel);
        }

        // GET: NewsModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsModel newsModel = db.NewsModels.Find(id);
            if (newsModel == null)
            {
                return HttpNotFound();
            }
            return View(newsModel);
        }

        // POST: NewsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewsModel newsModel = db.NewsModels.Find(id);
            db.NewsModels.Remove(newsModel);
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
