
namespace OtoServisSatis.WindowsApp
{
    partial class ServisYonetimi
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
            this.dgvServisler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpServiseGelisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServisUcreti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtAracSorunu = new System.Windows.Forms.TextBox();
            this.dtpServistenCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYapilanIslemler = new System.Windows.Forms.TextBox();
            this.cbGaranti = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAracPlaka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKasaTipi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSaseNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServisler
            // 
            this.dgvServisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServisler.Location = new System.Drawing.Point(12, 0);
            this.dgvServisler.Name = "dgvServisler";
            this.dgvServisler.Size = new System.Drawing.Size(1060, 251);
            this.dgvServisler.TabIndex = 2;
            this.dgvServisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServisler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSaseNo);
            this.groupBox1.Controls.Add(this.txtKasaTipi);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.txtAracPlaka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbGaranti);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpServistenCikisTarihi);
            this.groupBox1.Controls.Add(this.txtNotlar);
            this.groupBox1.Controls.Add(this.txtYapilanIslemler);
            this.groupBox1.Controls.Add(this.txtAracSorunu);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.dtpServiseGelisTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtServisUcreti);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(12, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 192);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(526, 163);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(445, 163);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(364, 164);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpServiseGelisTarihi
            // 
            this.dtpServiseGelisTarihi.Location = new System.Drawing.Point(94, 30);
            this.dtpServiseGelisTarihi.Name = "dtpServiseGelisTarihi";
            this.dtpServiseGelisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpServiseGelisTarihi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giriş Tarihi";
            // 
            // txtServisUcreti
            // 
            this.txtServisUcreti.Location = new System.Drawing.Point(94, 101);
            this.txtServisUcreti.Name = "txtServisUcreti";
            this.txtServisUcreti.Size = new System.Drawing.Size(200, 20);
            this.txtServisUcreti.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servis Ücreti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aracın Sorunu";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(621, 168);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // txtAracSorunu
            // 
            this.txtAracSorunu.Location = new System.Drawing.Point(94, 56);
            this.txtAracSorunu.Multiline = true;
            this.txtAracSorunu.Name = "txtAracSorunu";
            this.txtAracSorunu.Size = new System.Drawing.Size(200, 39);
            this.txtAracSorunu.TabIndex = 13;
            // 
            // dtpServistenCikisTarihi
            // 
            this.dtpServistenCikisTarihi.Location = new System.Drawing.Point(94, 127);
            this.dtpServistenCikisTarihi.Name = "dtpServistenCikisTarihi";
            this.dtpServistenCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpServistenCikisTarihi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Yapılan İşlemler";
            // 
            // txtYapilanIslemler
            // 
            this.txtYapilanIslemler.Location = new System.Drawing.Point(401, 56);
            this.txtYapilanIslemler.Multiline = true;
            this.txtYapilanIslemler.Name = "txtYapilanIslemler";
            this.txtYapilanIslemler.Size = new System.Drawing.Size(200, 39);
            this.txtYapilanIslemler.TabIndex = 13;
            // 
            // cbGaranti
            // 
            this.cbGaranti.AutoSize = true;
            this.cbGaranti.Location = new System.Drawing.Point(401, 30);
            this.cbGaranti.Name = "cbGaranti";
            this.cbGaranti.Size = new System.Drawing.Size(141, 17);
            this.cbGaranti.TabIndex = 16;
            this.cbGaranti.Text = "Garanti Kapsamında Mı?";
            this.cbGaranti.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Araç Plaka";
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(401, 101);
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(200, 20);
            this.txtAracPlaka.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(401, 127);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(200, 20);
            this.txtMarka.TabIndex = 18;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(710, 27);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(133, 20);
            this.txtModel.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(624, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Model";
            // 
            // txtKasaTipi
            // 
            this.txtKasaTipi.Location = new System.Drawing.Point(710, 52);
            this.txtKasaTipi.Name = "txtKasaTipi";
            this.txtKasaTipi.Size = new System.Drawing.Size(133, 20);
            this.txtKasaTipi.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(624, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Kasa Tipi";
            // 
            // txtSaseNo
            // 
            this.txtSaseNo.Location = new System.Drawing.Point(710, 78);
            this.txtSaseNo.Name = "txtSaseNo";
            this.txtSaseNo.Size = new System.Drawing.Size(133, 20);
            this.txtSaseNo.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(622, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Şase No";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(710, 107);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(133, 74);
            this.txtNotlar.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(624, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Notlar";
            // 
            // ServisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvServisler);
            this.Name = "ServisYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Yönetimi";
            this.Load += new System.EventHandler(this.ServisYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpServiseGelisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServisUcreti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtAracSorunu;
        private System.Windows.Forms.DateTimePicker dtpServistenCikisTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYapilanIslemler;
        private System.Windows.Forms.CheckBox cbGaranti;
        private System.Windows.Forms.TextBox txtAracPlaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSaseNo;
        private System.Windows.Forms.TextBox txtKasaTipi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNotlar;
    }
}