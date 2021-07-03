using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoServisSatis.WindowsApp
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciManager manager = new KullaniciManager();
        RoleManager roleManager = new RoleManager();
        void Yukle()
        {
            dgvKullanicilar.DataSource = manager.GetAll();
            cbKullaniciRolu.DataSource = roleManager.GetAll();
        }
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        private void Temizle()
        {
            txtAdi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
            txtTelefon.Text = string.Empty;
        }
        private void btnEkle_Click(object sender, EventArgs e)
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
                    Yukle();
                    Temizle();
                    MessageBox.Show("Kayıt Eklendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi!");
            }
        }

        
    }
}
