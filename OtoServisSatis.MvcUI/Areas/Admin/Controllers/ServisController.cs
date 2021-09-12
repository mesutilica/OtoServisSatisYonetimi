using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.BL;

namespace OtoServisSatis.MvcUI.Areas.Admin.Controllers
{
    public class ServisController : Controller
    {
        //private DatabaseContext db = new DatabaseContext();

        ServisManager manager = new ServisManager();

        // GET: Admin/Servis
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Servis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servis servis = manager.Find(id.Value);
            if (servis == null)
            {
                return HttpNotFound();
            }
            return View(servis);
        }

        // GET: Admin/Servis/Create
        public ActionResult Create()
        {
            return View();
        }
                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Servis servis)
        {
            if (ModelState.IsValid)
            {
                manager.Add(servis);
                
                return RedirectToAction("Index");
            }

            return View(servis);
        }

        // GET: Admin/Servis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servis servis = manager.Find(id.Value);
            if (servis == null)
            {
                return HttpNotFound();
            }
            return View(servis);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Servis servis)
        {
            if (ModelState.IsValid)
            {
                manager.Update(servis);

                return RedirectToAction("Index");
            }
            return View(servis);
        }

        // GET: Admin/Servis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servis servis = manager.Find(id.Value);
            if (servis == null)
            {
                return HttpNotFound();
            }
            return View(servis);
        }

        // POST: Admin/Servis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Servis servis = manager.Find(id);
            manager.Delete(servis.Id);
            
            return RedirectToAction("Index");
        }
        
    }
}
