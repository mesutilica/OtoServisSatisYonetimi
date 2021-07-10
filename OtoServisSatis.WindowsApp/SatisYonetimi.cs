using System;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System.Linq;
using System.Windows.Forms;

namespace OtoServisSatis.WindowsApp
{
    public partial class SatisYonetimi : Form
    {
        public SatisYonetimi()
        {
            InitializeComponent();
        }
        SatisManager manager = new SatisManager();
        AracManager aracManager = new AracManager();
        MusteriManager musteriManager = new MusteriManager();
        void Yukle()
        {
            dgvSatislar.DataSource = manager.GetAll();
            cbArac.DataSource = aracManager.GetAll();
            cbArac.DisplayMember = "Modeli";
            cbArac.ValueMember = "Id";
            cbMusteri.DataSource = musteriManager.GetAll();
            cbMusteri.DisplayMember = "Adi";
            cbMusteri.ValueMember = "Id";
        }
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            lblId.Text = "0";
        }
        private void SatisYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Satis
                    {
                        AracId = Convert.ToInt32(cbArac.SelectedValue),
                        MusteriId = Convert.ToInt32(cbMusteri.SelectedValue),
                        SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text),
                        SatisTarihi = dtpSatisTarihi.Value
                    });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Eklendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi!");
            }
        }

        private void dgvSatislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var satis = manager.Find(Convert.ToInt32(dgvSatislar.CurrentRow.Cells[0].Value));
                if (satis != null)
                {
                    cbArac.SelectedValue = satis.AracId;
                    cbMusteri.SelectedValue = satis.MusteriId;
                    txtSatisFiyati.Text = satis.SatisFiyati.ToString();
                    dtpSatisTarihi.Value = satis.SatisTarihi;
                    lblId.Text = satis.Id.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Yüklenemedi!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Update(
                    new Satis
                    {
                        Id = Convert.ToInt32(dgvSatislar.CurrentRow.Cells[0].Value),
                        AracId = Convert.ToInt32(cbArac.SelectedValue),
                        MusteriId = Convert.ToInt32(cbMusteri.SelectedValue),
                        SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text),
                        SatisTarihi = dtpSatisTarihi.Value
                    });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Güncellendi!");
                    }
                }
                else MessageBox.Show("Listeden güncellenecek kaydı seçiniz!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Güncellenemdi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Silindi!");
                    }
                }
                else MessageBox.Show("Listeden silinecek kaydı seçiniz!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi!");
            }
        }
    }
}
