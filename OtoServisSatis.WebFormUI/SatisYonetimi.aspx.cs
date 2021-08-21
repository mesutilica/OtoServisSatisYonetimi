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
    public partial class SatisYonetimi : System.Web.UI.Page
    {
        SatisManager manager = new SatisManager();
        AracManager aracManager = new AracManager();
        MusteriManager musteriManager = new MusteriManager();
        void Yukle()
        {
            dgvSatislar.DataSource = manager.GetAll();
            dgvSatislar.DataBind();
            cbArac.DataSource = aracManager.GetAll();
            cbArac.DataTextField = "Modeli";
            cbArac.DataValueField = "Id";
            cbArac.DataBind();
            cbMusteri.DataSource = musteriManager.GetAll();
            cbMusteri.DataTextField = "Adi";
            cbMusteri.DataValueField = "Id";
            cbMusteri.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) Yukle();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Satis
                    {
                        AracId = Convert.ToInt32(cbArac.SelectedValue),
                        MusteriId = Convert.ToInt32(cbMusteri.SelectedValue),
                        SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text),
                        SatisTarihi = dtpSatisTarihi.SelectedDate + DateTime.Now.TimeOfDay
                    });
                if (sonuc > 0)
                {
                    Response.Redirect("SatisYonetimi.aspx");
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
                    var sonuc = manager.Update(
                    new Satis
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        AracId = Convert.ToInt32(cbArac.SelectedValue),
                        MusteriId = Convert.ToInt32(cbMusteri.SelectedValue),
                        SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text),
                        SatisTarihi = dtpSatisTarihi.SelectedDate + DateTime.Now.TimeOfDay
                    });
                    if (sonuc > 0)
                    {
                        Response.Redirect("SatisYonetimi.aspx");
                    }
                }
                else MessageBox("Listeden güncellenecek kaydı seçiniz!");
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Güncellenemdi!");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Response.Redirect("SatisYonetimi.aspx");
                    }
                }
                else MessageBox("Listeden silinecek kaydı seçiniz!");
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Silinemedi!");
            }
        }

        protected void dgvSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = dgvSatislar.SelectedRow;
            try
            {
                var satis = manager.Find(Convert.ToInt32(row.Cells[1].Text));
                if (satis != null)
                {
                    cbArac.SelectedValue = satis.AracId.ToString();
                    cbMusteri.SelectedValue = satis.MusteriId.ToString();
                    txtSatisFiyati.Text = satis.SatisFiyati.ToString();
                    dtpSatisTarihi.SelectedDate = satis.SatisTarihi;
                    lblId.Text = satis.Id.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Yüklenemedi!");
            }
        }

        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı", $"<script>alert('{mesaj}')</script>");
        }
    }
}