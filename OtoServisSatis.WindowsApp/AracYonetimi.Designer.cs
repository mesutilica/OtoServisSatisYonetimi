
namespace OtoServisSatis.WindowsApp
{
    partial class AracYonetimi
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
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.txtModeli = new System.Windows.Forms.TextBox();
            this.txtKasaTipi = new System.Windows.Forms.TextBox();
            this.txtModelYili = new System.Windows.Forms.TextBox();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSatistaMi = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(0, 0);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.Size = new System.Drawing.Size(797, 212);
            this.dgvAraclar.TabIndex = 0;
            this.dgvAraclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAraclar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cbSatistaMi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNotlar);
            this.groupBox1.Controls.Add(this.txtModelYili);
            this.groupBox1.Controls.Add(this.txtKasaTipi);
            this.groupBox1.Controls.Add(this.txtModeli);
            this.groupBox1.Controls.Add(this.txtFiyati);
            this.groupBox1.Controls.Add(this.txtRenk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMarka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(694, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 10);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka";
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(104, 40);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(121, 21);
            this.cbMarka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Renk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modeli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kasa Tipi";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(104, 67);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 2;
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(104, 93);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtFiyati.TabIndex = 3;
            // 
            // txtModeli
            // 
            this.txtModeli.Location = new System.Drawing.Point(104, 119);
            this.txtModeli.Name = "txtModeli";
            this.txtModeli.Size = new System.Drawing.Size(100, 20);
            this.txtModeli.TabIndex = 4;
            // 
            // txtKasaTipi
            // 
            this.txtKasaTipi.Location = new System.Drawing.Point(104, 145);
            this.txtKasaTipi.Name = "txtKasaTipi";
            this.txtKasaTipi.Size = new System.Drawing.Size(100, 20);
            this.txtKasaTipi.TabIndex = 5;
            // 
            // txtModelYili
            // 
            this.txtModelYili.Location = new System.Drawing.Point(356, 41);
            this.txtModelYili.Name = "txtModelYili";
            this.txtModelYili.Size = new System.Drawing.Size(100, 20);
            this.txtModelYili.TabIndex = 6;
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(356, 67);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(100, 42);
            this.txtNotlar.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model Yılı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Notlar";
            // 
            // cbSatistaMi
            // 
            this.cbSatistaMi.AutoSize = true;
            this.cbSatistaMi.Location = new System.Drawing.Point(356, 122);
            this.cbSatistaMi.Name = "cbSatistaMi";
            this.cbSatistaMi.Size = new System.Drawing.Size(69, 17);
            this.cbSatistaMi.TabIndex = 14;
            this.cbSatistaMi.Text = "Satış Mı?";
            this.cbSatistaMi.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(255, 163);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(356, 163);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(459, 163);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // AracYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAraclar);
            this.Name = "AracYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Yönetimi";
            this.Load += new System.EventHandler(this.AracYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKasaTipi;
        private System.Windows.Forms.TextBox txtModeli;
        private System.Windows.Forms.TextBox txtFiyati;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.CheckBox cbSatistaMi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.TextBox txtModelYili;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}