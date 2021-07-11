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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnAracYonetimi_Click(object sender, EventArgs e)
        {
            AracYonetimi aracYonetimi = new AracYonetimi();
            aracYonetimi.ShowDialog();
        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.ShowDialog();
        }

        private void btnMarkaYonetimi_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            markaYonetimi.ShowDialog();
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            MusteriYonetimi musteriYonetimi = new MusteriYonetimi();
            musteriYonetimi.ShowDialog();
        }

        private void btnRolYonetimi_Click(object sender, EventArgs e)
        {
            RolYonetimi rolYonetimi = new RolYonetimi();
            rolYonetimi.ShowDialog();
        }

        private void btnSatisYonetimi_Click(object sender, EventArgs e)
        {
            SatisYonetimi satisYonetimi = new SatisYonetimi();
            satisYonetimi.ShowDialog();
        }

        private void btnServisYonetimi_Click(object sender, EventArgs e)
        {
            ServisYonetimi servisYonetimi = new ServisYonetimi();
            servisYonetimi.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
