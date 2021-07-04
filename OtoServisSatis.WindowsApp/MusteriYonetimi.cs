using OtoServisSatis.BL;
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
    public partial class MusteriYonetimi : Form
    {
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        MusteriManager manager = new MusteriManager();
        void Yukle()
        {
            dgvMusteriler.DataSource = manager.GetAll();
        }
        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}
