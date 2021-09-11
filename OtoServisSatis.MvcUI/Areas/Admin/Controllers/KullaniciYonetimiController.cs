using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Web.Mvc;

namespace OtoServisSatis.MvcUI.Areas.Admin.Controllers
{
    public class KullaniciYonetimiController : Controller
    {
        KullaniciManager manager = new KullaniciManager();
        RoleManager roleManager = new RoleManager();
        // GET: Admin/KullaniciYonetimi
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        
        // GET: Admin/KullaniciYonetimi/Create
        public ActionResult Create()
        {
            ViewBag.RolId = new SelectList(roleManager.GetAll(), "Id", "Adi");
            return View();
        }

        // POST: Admin/KullaniciYonetimi/Create
        [HttpPost]
        public ActionResult Create(Kullanici kullanici)
        {
            try
            {
                kullanici.EklenmeTarihi = DateTime.Now;
                manager.Add(kullanici);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/KullaniciYonetimi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = manager.Find(id.Value);
            if (kullanici == null)
            {
                return HttpNotFound();
            }
            ViewBag.RolId = new SelectList(roleManager.GetAll(), "Id", "Adi", kullanici.RolId);
            return View(kullanici);
        }

        // POST: Admin/KullaniciYonetimi/Edit/5
        [HttpPost]
        public ActionResult Edit(Kullanici kullanici)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    manager.Update(kullanici);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/KullaniciYonetimi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = manager.Find(id.Value);
            if (kullanici == null)
            {
                return HttpNotFound();
            }
            
            return View(kullanici);            
        }

        // POST: Admin/KullaniciYonetimi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                manager.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
