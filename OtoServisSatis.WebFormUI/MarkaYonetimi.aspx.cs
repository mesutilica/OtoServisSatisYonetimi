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
    public partial class MarkaYonetimi : System.Web.UI.Page
    {
        MarkaManager manager = new MarkaManager();
        void Yukle()
        {
            dgvMarkalar.DataSource = manager.GetAll();
            dgvMarkalar.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) Yukle();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemSonucu = manager.Add(
                    new Marka
                    {
                        Adi = txtMarkaAdi.Text
                    }
                    );
                if (islemSonucu > 0)
                {
                    Response.Redirect("MarkaYonetimi.aspx");
                }
            }
            catch (Exception hata)
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
                    int islemSonucu = manager.Update(
                    new Marka
                    {
                        Id = int.Parse(lblId.Text),
                        Adi = txtMarkaAdi.Text
                    }
                    );
                    if (islemSonucu > 0)
                    {
                        Response.Redirect("MarkaYonetimi.aspx");
                    }
                }
                else MessageBox("Listeden güncellemek istediğiniz kaydı seçiniz!");
            }
            catch (Exception hata)
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
                    var marka = manager.Get(int.Parse(lblId.Text));
                    int islemSonucu = manager.Delete(marka);
                    if (islemSonucu > 0)
                    {
                        Response.Redirect("MarkaYonetimi.aspx");
                    }
                }
                else MessageBox("Listeden silmek istediğiniz kaydı seçiniz!");
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Silinemedi!");
            }
        }

        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı", $"<script>alert('{mesaj}')</script>");
        }

        protected void dgvMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = dgvMarkalar.SelectedRow;
                int id = Convert.ToInt32(row.Cells[1].Text);
                if (id > 0)
                {
                    var marka = manager.Get(id);
                    lblId.Text = marka.Id.ToString();
                    txtMarkaAdi.Text = marka.Adi;
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu!");
            }
        }

    }
}