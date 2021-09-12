using System.Web.Mvc;

namespace OtoServisSatis.MvcUI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        BL.KullaniciManager kullaniciManager = new BL.KullaniciManager();
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string kullaniciAdi, string sifre)
        {
            try
            {
                var kullanici = kullaniciManager.Get(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifre && k.AktifMi == true);
                if (kullanici != null)
                {
                    Session["admin"] = kullanici;
                    return Redirect("/Admin");
                }
                else
                {
                    TempData["mesaj"] = "Kullanıcı Girişi Başarısız!";
                }
            }
            catch
            {
                TempData["mesaj"] = "Hata Oluştu!";
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Remove("admin");
            return Redirect("/Admin/Login");
        }
    }
}