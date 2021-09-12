using System.Linq;
using System.Net;
using System.Web.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.BL;

namespace OtoServisSatis.MvcUI.Areas.Admin.Controllers
{
    public class SatisYonetimiController : Controller
    {
        //private DatabaseContext db = new DatabaseContext();

        SatisManager manager = new SatisManager();
        AracManager aracManager = new AracManager();
        MusteriManager musteriManager = new MusteriManager();

        // GET: Admin/SatisYonetimi
        public ActionResult Index()
        {
            var satislar = manager.GetAllByInclude("Musteri");//db.Satislar.Include(s => s.Arac).Include(s => s.Musteri);
            return View(satislar.ToList());
        }

        // GET: Admin/SatisYonetimi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Satis satis = manager.Find(id.Value);
            if (satis == null)
            {
                return HttpNotFound();
            }
            return View(satis);
        }

        // GET: Admin/SatisYonetimi/Create
        public ActionResult Create()
        {
            ViewBag.AracId = new SelectList(aracManager.GetAll(), "Id", "Renk");
            ViewBag.MusteriId = new SelectList(musteriManager.GetAll(), "Id", "Adi");
            return View();
        }

        // POST: Admin/SatisYonetimi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Satis satis)
        {
            if (ModelState.IsValid)
            {
                manager.Add(satis);
                
                return RedirectToAction("Index");
            }

            ViewBag.AracId = new SelectList(aracManager.GetAll(), "Id", "Renk", satis.AracId);
            ViewBag.MusteriId = new SelectList(musteriManager.GetAll(), "Id", "Adi", satis.MusteriId);
            return View(satis);
        }

        // GET: Admin/SatisYonetimi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Satis satis = manager.Find(id.Value);
            if (satis == null)
            {
                return HttpNotFound();
            }
            ViewBag.AracId = new SelectList(aracManager.GetAll(), "Id", "Renk", satis.AracId);
            ViewBag.MusteriId = new SelectList(musteriManager.GetAll(), "Id", "Adi", satis.MusteriId);
            return View(satis);
        }

        // POST: Admin/SatisYonetimi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Satis satis)
        {
            if (ModelState.IsValid)
            {
                manager.Update(satis);

                return RedirectToAction("Index");
            }
            ViewBag.AracId = new SelectList(aracManager.GetAll(), "Id", "Renk", satis.AracId);
            ViewBag.MusteriId = new SelectList(musteriManager.GetAll(), "Id", "Adi", satis.MusteriId);
            return View(satis);
        }

        // GET: Admin/SatisYonetimi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Satis satis = manager.Find(id.Value);
            if (satis == null)
            {
                return HttpNotFound();
            }
            return View(satis);
        }

        // POST: Admin/SatisYonetimi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Satis satis = manager.Find(id);
            manager.Delete(satis.Id);
            
            return RedirectToAction("Index");
        }
        
    }
}
