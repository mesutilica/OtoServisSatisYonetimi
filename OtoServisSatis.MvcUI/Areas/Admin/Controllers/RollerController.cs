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
    public class RollerController : Controller
    {
        //private DatabaseContext db = new DatabaseContext();
        RoleManager manager = new RoleManager();

        // GET: Admin/Roller
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Roller/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rol rol = manager.Find(id.Value);
            if (rol == null)
            {
                return HttpNotFound();
            }
            return View(rol);
        }

        // GET: Admin/Roller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Roller/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adi")] Rol rol)
        {
            if (ModelState.IsValid)
            {
                manager.Add(rol);
                
                return RedirectToAction("Index");
            }

            return View(rol);
        }

        // GET: Admin/Roller/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rol rol = manager.Find(id.Value);
            if (rol == null)
            {
                return HttpNotFound();
            }
            return View(rol);
        }

        // POST: Admin/Roller/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adi")] Rol rol)
        {
            if (ModelState.IsValid)
            {
                manager.Update(rol);

                return RedirectToAction("Index");
            }
            return View(rol);
        }

        // GET: Admin/Roller/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rol rol = manager.Find(id.Value);
            if (rol == null)
            {
                return HttpNotFound();
            }
            return View(rol);
        }

        // POST: Admin/Roller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rol rol = manager.Find(id);
            manager.Delete(rol.Id);
            
            return RedirectToAction("Index");
        }
        
    }
}
