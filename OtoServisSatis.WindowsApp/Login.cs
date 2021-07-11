using System;
using System.Windows.Forms;

namespace OtoServisSatis.WindowsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BL.KullaniciManager kullaniciManager = new BL.KullaniciManager();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanici = kullaniciManager.Get(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text && k.AktifMi == true);
                if (kullanici != null)
                {
                    AnaMenu anaMenu = new AnaMenu();
                    anaMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Girişi Başarısız!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }

        }
    }
}
