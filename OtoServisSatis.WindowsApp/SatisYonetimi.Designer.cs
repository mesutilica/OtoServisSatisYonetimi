
namespace OtoServisSatis.WindowsApp
{
    partial class SatisYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cbArac = new System.Windows.Forms.ComboBox();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(-1, -1);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.Size = new System.Drawing.Size(799, 251);
            this.dgvSatislar.TabIndex = 1;
            this.dgvSatislar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSatislar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.dtpSatisTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSatisFiyati);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMusteri);
            this.groupBox1.Controls.Add(this.cbArac);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Bilgileri";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(554, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // cbArac
            // 
            this.cbArac.FormattingEnabled = true;
            this.cbArac.Location = new System.Drawing.Point(106, 32);
            this.cbArac.Name = "cbArac";
            this.cbArac.Size = new System.Drawing.Size(121, 21);
            this.cbArac.TabIndex = 2;
            // 
            // cbMusteri
            // 
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(106, 77);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cbMusteri.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Araç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Satış Fiyatı";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(106, 116);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(121, 20);
            this.txtSatisFiyati.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Satış Tarihi";
            // 
            // dtpSatisTarihi
            // 
            this.dtpSatisTarihi.Location = new System.Drawing.Point(339, 29);
            this.dtpSatisTarihi.Name = "dtpSatisTarihi";
            this.dtpSatisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpSatisTarihi.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(302, 114);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(383, 113);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(464, 113);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // SatisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSatislar);
            this.Name = "SatisYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Yönetimi";
            this.Load += new System.EventHandler(this.SatisYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.ComboBox cbArac;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSatisTarihi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}