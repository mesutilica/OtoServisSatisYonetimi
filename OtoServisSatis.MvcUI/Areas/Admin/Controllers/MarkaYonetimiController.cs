using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.MvcUI.Models;
using OtoServisSatis.BL;

namespace OtoServisSatis.MvcUI.Areas.Admin.Controllers
{
    public class MarkaYonetimiController : Controller
    {
        MarkaManager manager = new MarkaManager();

        // GET: Admin/MarkasYonetimi
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/MarkasYonetimi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marka marka = manager.Get(id.Value);
            if (marka == null)
            {
                return HttpNotFound();
            }
            return View(marka);
        }

        // GET: Admin/MarkasYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/MarkasYonetimi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adi")] Marka marka)
        {
            if (ModelState.IsValid)
            {
                manager.Add(marka);
                
                return RedirectToAction("Index");
            }

            return View(marka);
        }

        // GET: Admin/MarkasYonetimi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marka marka = manager.Get(id.Value);
            if (marka == null)
            {
                return HttpNotFound();
            }
            return View(marka);
        }

        // POST: Admin/MarkasYonetimi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adi")] Marka marka)
        {
            if (ModelState.IsValid)
            {
                manager.Update(marka);
                return RedirectToAction("Index");
            }
            return View(marka);
        }

        // GET: Admin/MarkasYonetimi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marka marka = manager.Get(id.Value);
            if (marka == null)
            {
                return HttpNotFound();
            }
            return View(marka);
        }

        // POST: Admin/MarkasYonetimi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Marka marka = manager.Get(id);
            manager.Delete(marka);
            return RedirectToAction("Index");
        }
        
    }
}
