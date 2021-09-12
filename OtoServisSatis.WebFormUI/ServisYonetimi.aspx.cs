using System;
using System.Web.UI;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;

namespace OtoServisSatis.WebFormUI
{
    public partial class ServisYonetimi : System.Web.UI.Page
    {
        ServisManager manager = new ServisManager();
        void Yukle()
        {
            dgvServisler.DataSource = manager.GetAll();
            dgvServisler.DataBind();
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
                    new Servis
                    {
                        AracPlaka = txtAracPlaka.Text,
                        AracSorunu = txtAracSorunu.Text,
                        GarantiKapsamindaMi = cbGaranti.Checked,
                        KasaTipi = txtKasaTipi.Text,
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Notlar = txtNotlar.Text,
                        SaseNo = txtSaseNo.Text,
                        ServiseGelisTarihi = dtpServiseGelisTarihi.SelectedDate + DateTime.Now.TimeOfDay,
                        ServistenCikisTarihi = dtpServistenCikisTarihi.SelectedDate + DateTime.Now.TimeOfDay,
                        ServisUcreti = Convert.ToDecimal(txtServisUcreti.Text),
                        YapilanIslemler = txtYapilanIslemler.Text
                    });
                if (sonuc > 0)
                {
                    Response.Redirect("ServisYonetimi.aspx");
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
                    new Servis
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        AracPlaka = txtAracPlaka.Text,
                        AracSorunu = txtAracSorunu.Text,
                        GarantiKapsamindaMi = cbGaranti.Checked,
                        KasaTipi = txtKasaTipi.Text,
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Notlar = txtNotlar.Text,
                        SaseNo = txtSaseNo.Text,
                        ServiseGelisTarihi = dtpServiseGelisTarihi.SelectedDate + DateTime.Now.TimeOfDay,
                        ServistenCikisTarihi = dtpServistenCikisTarihi.SelectedDate + DateTime.Now.TimeOfDay,
                        ServisUcreti = Convert.ToDecimal(txtServisUcreti.Text),
                        YapilanIslemler = txtYapilanIslemler.Text
                    });
                    if (sonuc > 0)
                    {
                        Response.Redirect("ServisYonetimi.aspx");
                    }
                }
                else MessageBox("Listeden güncellenecek kaydı seçiniz!");
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
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Response.Redirect("ServisYonetimi.aspx");
                    }
                }
                //else MessageBox("Listeden silinecek kaydı seçiniz!"); 
                else Tools.Araclar.MessageBox(this, "Listeden silinecek kaydı seçiniz!");
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Silinemedi!");
            }
        }

        protected void dgvServisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GridViewRow row = dgvServisler.SelectedRow;
            try
            {
                var servis = manager.Find(Convert.ToInt32(dgvServisler.SelectedRow.Cells[1].Text));
                if (servis != null)
                {
                    txtAracPlaka.Text = servis.AracPlaka;
                    txtAracSorunu.Text = servis.AracSorunu;
                    txtKasaTipi.Text = servis.KasaTipi;
                    txtMarka.Text = servis.Marka;
                    txtModel.Text = servis.Model;
                    txtNotlar.Text = servis.Notlar;
                    txtSaseNo.Text = servis.SaseNo;
                    txtServisUcreti.Text = servis.ServisUcreti.ToString();
                    txtYapilanIslemler.Text = servis.YapilanIslemler;
                    dtpServiseGelisTarihi.SelectedDate = servis.ServiseGelisTarihi;
                    dtpServistenCikisTarihi.SelectedDate = servis.ServistenCikisTarihi;
                    cbGaranti.Checked = servis.GarantiKapsamindaMi;
                    lblId.Text = servis.Id.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Yüklenemedi!");
            }
        }

        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı", $"alert('{mesaj}')", true);
        }
    }
}