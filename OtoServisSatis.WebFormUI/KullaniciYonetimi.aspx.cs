using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;

namespace OtoServisSatis.WebFormUI
{
    public partial class KullaniciYonetimi : System.Web.UI.Page
    {
        KullaniciManager manager = new KullaniciManager();
        RoleManager roleManager = new RoleManager();
        void Yukle()
        {
            var ozelSorgu = (from k in manager.GetAllByInclude("Rol")
                             select new
                             {
                                 Id = k.Id,
                                 Adı = k.Adi,
                                 Soyadı = k.Soyadi,
                                 Email = k.Email,
                                 Telefon = k.Telefon,
                                 Kullanıcı_Adı = k.KullaniciAdi,
                                 Durum = k.AktifMi,
                                 Eklenme_Tarihi = k.EklenmeTarihi,
                                 Rolü = k.Rol.Adi
                             }).ToList();
            dgvKullanicilar.DataSource = ozelSorgu;
            //dgvKullanicilar.DataSource = manager.GetAll();
            dgvKullanicilar.DataBind();
            cbKullaniciRolu.DataSource = roleManager.GetAll();
            cbKullaniciRolu.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack) Yukle();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemSonucu = manager.Add(
                    new Kullanici
                    {
                        Adi = txtAdi.Text,
                        AktifMi = cbAktif.Checked,
                        EklenmeTarihi = DateTime.Now,
                        Email = txtEmail.Text,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        RolId = int.Parse(cbKullaniciRolu.SelectedValue.ToString()),
                        Sifre = txtSifre.Text,
                        Soyadi = txtSoyadi.Text,
                        Telefon = txtTelefon.Text
                    }
                    );
                if (islemSonucu > 0)
                {
                    Response.Redirect("KullaniciYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Eklenemedi!");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    int kulId = Convert.ToInt32(lblId.Text);
                    int islemSonucu = manager.Update(
                    new Kullanici
                    {
                        Id = kulId,
                        Adi = txtAdi.Text,
                        AktifMi = cbAktif.Checked,
                        EklenmeTarihi = DateTime.Now,
                        Email = txtEmail.Text,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        RolId = int.Parse(cbKullaniciRolu.SelectedValue),
                        Sifre = txtSifre.Text,
                        Soyadi = txtSoyadi.Text,
                        Telefon = txtTelefon.Text
                    }
                    );
                    if (islemSonucu > 0)
                    {
                        Response.Redirect("KullaniciYonetimi.aspx");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Güncellenemedi!");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox("Listeden silinecek kaydı seçiniz!");
                }
                else
                {
                    int kulId = Convert.ToInt32(lblId.Text);
                    var sonuc = manager.Delete(kulId);
                    if (sonuc > 0)
                    {
                        Response.Redirect("KullaniciYonetimi.aspx");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Silinemedi!");
            }
        }

        protected void dgvKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = dgvKullanicilar.SelectedRow;
                int kulId = Convert.ToInt32(row.Cells[1].Text);
                if (kulId > 0)
                {
                    var kullanici = manager.Find(kulId);
                    txtAdi.Text = kullanici.Adi;
                    txtEmail.Text = kullanici.Email;
                    txtKullaniciAdi.Text = kullanici.KullaniciAdi;
                    txtSifre.Text = kullanici.Sifre;
                    txtSoyadi.Text = kullanici.Soyadi;
                    txtTelefon.Text = kullanici.Telefon;
                    cbAktif.Checked = kullanici.AktifMi;
                    cbKullaniciRolu.SelectedValue = kullanici.RolId.ToString();
                    lblEklenmeTarihi.Text = kullanici.EklenmeTarihi.ToString();
                    lblId.Text = kullanici.Id.ToString();
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