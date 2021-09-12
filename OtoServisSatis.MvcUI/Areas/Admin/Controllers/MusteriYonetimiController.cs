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
    public class MusteriYonetimiController : Controller
    {
        //private DatabaseContext db = new DatabaseContext();

        MusteriManager manager = new MusteriManager();
        AracManager aracManager = new AracManager();

        // GET: Admin/MusteriYonetimi
        public ActionResult Index()
        {
            var musteriler = manager.GetAllByInclude("Arac"); //db.Musteriler.Include(m => m.Arac);
            return View(musteriler.ToList());
        }

        // GET: Admin/MusteriYonetimi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musteri musteri = manager.Find(id.Value);
            if (musteri == null)
            {
                return HttpNotFound();
            }
            return View(musteri);
        }

        // GET: Admin/MusteriYonetimi/Create
        public ActionResult Create()
        {
            ViewBag.AracId = new SelectList(aracManager.GetAll(), "Id", "Renk");
            return View();
        }

        // POST: Admin/MusteriYonetimi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                manager.Add(musteri);
                
                return RedirectToAction("Index");
            }

            ViewBag.AracId = new SelectList(aracManager.GetAll(), "Id", "Renk", musteri.AracId);
            return View(musteri);
        }

        // GET: Admin/MusteriYonetimi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musteri musteri = manager.Find(id.Value);
            if (musteri == null)
            {
                return HttpNotFound();
            }
            ViewBag.AracId = new SelectList(aracManager.GetAll(), "Id", "Renk", musteri.AracId);
            return View(musteri);
        }

        // POST: Admin/MusteriYonetimi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                manager.Update(musteri);
                
                return RedirectToAction("Index");
            }
            ViewBag.AracId = new SelectList(aracManager.GetAll(), "Id", "Renk", musteri.AracId);
            return View(musteri);
        }

        // GET: Admin/MusteriYonetimi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musteri musteri = manager.Find(id.Value);
            if (musteri == null)
            {
                return HttpNotFound();
            }
            return View(musteri);
        }

        // POST: Admin/MusteriYonetimi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Musteri musteri = manager.Find(id);
            manager.Delete(musteri.Id);
            
            return RedirectToAction("Index");
        }
        
    }
}
