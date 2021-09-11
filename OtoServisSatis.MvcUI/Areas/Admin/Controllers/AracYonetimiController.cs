using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Web.Mvc;

namespace OtoServisSatis.MvcUI.Areas.Admin.Controllers
{
    public class AracYonetimiController : Controller
    {
        AracManager manager = new AracManager();
        MarkaManager markaManager = new MarkaManager();
        // GET: Admin/AracYonetimi
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }
        public ActionResult Create()
        {
            ViewBag.MarkaId = new SelectList(markaManager.GetAll(), "Id", "Adi");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Arac arac)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sonuc = manager.Add(arac);
                    if (sonuc > 0)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Hata Oluştu! Kayıt Eklenemedi!");
            }
            
            return View();
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Arac arac = manager.Find(id.Value);
            if (arac == null)
            {
                return HttpNotFound();
            }
            ViewBag.MarkaId = new SelectList(markaManager.GetAll(), "Id", "Adi", arac.MarkaId);
            return View(arac);
        }
        [HttpPost]
        public ActionResult Edit(Arac arac)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sonuc = manager.Update(arac);
                    if (sonuc > 0)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Hata Oluştu! Kayıt Eklenemedi!");
            }
            ViewBag.MarkaId = new SelectList(markaManager.GetAll(), "Id", "Adi", arac.MarkaId);
            return View(arac);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Arac arac = manager.Find(id.Value);
            if (arac == null)
            {
                return HttpNotFound();
            }
            
            return View(arac);
        }

        [HttpPost]
        public ActionResult Delete(int? id, string test)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Arac arac = manager.Find(id.Value);
            if (arac == null)
            {
                return HttpNotFound();
            }
            try
            {
                manager.Delete(id.Value);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ModelState.AddModelError("","Kayıt Silinemedi!");
            }
            return View(arac);
        }

    }
}