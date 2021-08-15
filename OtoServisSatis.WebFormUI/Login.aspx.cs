using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtoServisSatis.WebFormUI
{
    public partial class Login : System.Web.UI.Page
    {
        BL.KullaniciManager kullaniciManager = new BL.KullaniciManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanici = kullaniciManager.Get(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text && k.AktifMi == true);
                if (kullanici != null)
                {
                    Response.Redirect("AnaMenu.aspx");
                }
                else
                {
                    MessageBox("Kullanıcı Girişi Başarısız!");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu!");
            }
        }

        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı", $"<script>alert('{mesaj}')</script>");
        }

    }
}