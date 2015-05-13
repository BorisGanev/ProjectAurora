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
    public class GameInfoController : Controller
    {
        private GameInfoDbContext db = new GameInfoDbContext();

        // GET: GameInfo
        public ActionResult Index()
        {
            return View(db.GamesInfos.ToList());
        }

        // GET: GameInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameInfo gameInfo = db.GamesInfos.Find(id);
            if (gameInfo == null)
            {
                return HttpNotFound();
            }
            return View(gameInfo);
        }

        // GET: GameInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Developer,Publisher,Platforms,ReleaseDate,Genre,MetaCriticScore")] GameInfo gameInfo)
        {
            if (ModelState.IsValid)
            {
                db.GamesInfos.Add(gameInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameInfo);
        }

        // GET: GameInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameInfo gameInfo = db.GamesInfos.Find(id);
            if (gameInfo == null)
            {
                return HttpNotFound();
            }
            return View(gameInfo);
        }

        // POST: GameInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Developer,Publisher,Platforms,ReleaseDate,Genre,MetaCriticScore")] GameInfo gameInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameInfo);
        }

        // GET: GameInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameInfo gameInfo = db.GamesInfos.Find(id);
            if (gameInfo == null)
            {
                return HttpNotFound();
            }
            return View(gameInfo);
        }

        // POST: GameInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameInfo gameInfo = db.GamesInfos.Find(id);
            db.GamesInfos.Remove(gameInfo);
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
