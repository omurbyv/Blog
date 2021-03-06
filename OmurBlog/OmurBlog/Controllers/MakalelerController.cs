﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OmurBlog.Models;
using PagedList;

namespace OmurBlog.Controllers
{
    public class MakalelerController : Controller
    {
        private OmurBlogContext db = new OmurBlogContext();

        // GET: Makaleler
        public ActionResult Index(int page = 1)
        {
            return View(db.makaleler.OrderBy(model => model.Date).ToPagedList(page, 5 ));
        }

        // GET: Makaleler/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makaleler makaleler = db.makaleler.Find(id);
            if (makaleler == null)
            {
                return HttpNotFound();
            }
            return View(makaleler);
        }

        // GET: Makaleler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Makaleler/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "MakalelerId,Title,Author,Date,ArticleContent")] Makaleler makaleler)
        {
            if (ModelState.IsValid)
            {
                db.makaleler.Add(makaleler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(makaleler);
        }

        // GET: Makaleler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makaleler makaleler = db.makaleler.Find(id);
            if (makaleler == null)
            {
                return HttpNotFound();
            }
            return View(makaleler);
        }

        // POST: Makaleler/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "MakalelerId,Title,Author,Date,ArticleContent")] Makaleler makaleler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(makaleler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(makaleler);
        }

        // GET: Makaleler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makaleler makaleler = db.makaleler.Find(id);
            if (makaleler == null)
            {
                return HttpNotFound();
            }
            return View(makaleler);
        }

        // POST: Makaleler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Makaleler makaleler = db.makaleler.Find(id);
            db.makaleler.Remove(makaleler);
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
