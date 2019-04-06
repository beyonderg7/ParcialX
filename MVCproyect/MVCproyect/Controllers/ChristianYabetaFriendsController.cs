using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCproyect.Models;

namespace MVCproyect.Controllers
{
    public class ChristianYabetaFriendsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: ChristianYabetaFriends
        public ActionResult Index()
        {
            return View(db.ChristianYabetaFriends.ToList());
        }

        // GET: ChristianYabetaFriends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChristianYabetaFriends christianYabetaFriends = db.ChristianYabetaFriends.Find(id);
            if (christianYabetaFriends == null)
            {
                return HttpNotFound();
            }
            return View(christianYabetaFriends);
        }

        // GET: ChristianYabetaFriends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChristianYabetaFriends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendID,Name,Type,Nickname,BirthDate")] ChristianYabetaFriends christianYabetaFriends)
        {
            if (ModelState.IsValid)
            {
                db.ChristianYabetaFriends.Add(christianYabetaFriends);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(christianYabetaFriends);
        }

        // GET: ChristianYabetaFriends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChristianYabetaFriends christianYabetaFriends = db.ChristianYabetaFriends.Find(id);
            if (christianYabetaFriends == null)
            {
                return HttpNotFound();
            }
            return View(christianYabetaFriends);
        }

        // POST: ChristianYabetaFriends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendID,Name,Type,Nickname,BirthDate")] ChristianYabetaFriends christianYabetaFriends)
        {
            if (ModelState.IsValid)
            {
                db.Entry(christianYabetaFriends).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(christianYabetaFriends);
        }

        // GET: ChristianYabetaFriends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChristianYabetaFriends christianYabetaFriends = db.ChristianYabetaFriends.Find(id);
            if (christianYabetaFriends == null)
            {
                return HttpNotFound();
            }
            return View(christianYabetaFriends);
        }

        // POST: ChristianYabetaFriends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChristianYabetaFriends christianYabetaFriends = db.ChristianYabetaFriends.Find(id);
            db.ChristianYabetaFriends.Remove(christianYabetaFriends);
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
