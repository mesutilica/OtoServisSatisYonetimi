
namespace OtoServisSatis.WindowsApp
{
    partial class MusteriYonetimi
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
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblEklenmeTarihi = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAracId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(0, 0);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(799, 251);
            this.dgvMusteriler.TabIndex = 0;
            this.dgvMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNotlar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.lblEklenmeTarihi);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtTcNo);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbAracId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(515, 56);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(121, 41);
            this.txtNotlar.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Notlar";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(381, 117);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(300, 117);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(219, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblEklenmeTarihi
            // 
            this.lblEklenmeTarihi.AutoSize = true;
            this.lblEklenmeTarihi.Location = new System.Drawing.Point(512, 108);
            this.lblEklenmeTarihi.Name = "lblEklenmeTarihi";
            this.lblEklenmeTarihi.Size = new System.Drawing.Size(0, 13);
            this.lblEklenmeTarihi.TabIndex = 16;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(61, 113);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 15;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(300, 56);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 41);
            this.txtAdres.TabIndex = 14;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(300, 26);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtTcNo.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(61, 56);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 12;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(61, 28);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Araç";
            // 
            // cbAracId
            // 
            this.cbAracId.DisplayMember = "Adi";
            this.cbAracId.FormattingEnabled = true;
            this.cbAracId.Location = new System.Drawing.Point(515, 27);
            this.cbAracId.Name = "cbAracId";
            this.cbAracId.Size = new System.Drawing.Size(121, 21);
            this.cbAracId.TabIndex = 9;
            this.cbAracId.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tc No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(605, 108);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "0";
            // 
            // MusteriYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMusteriler);
            this.Name = "MusteriYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Yönetimi";
            this.Load += new System.EventHandler(this.MusteriYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblEklenmeTarihi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAracId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.Label label7;
    }
}