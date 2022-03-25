namespace denemem
{
    partial class Form1
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
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.lblurunadi = new System.Windows.Forms.Label();
            this.lblureticifirma = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblkategoriadi = new System.Windows.Forms.Label();
            this.txtürünadi = new System.Windows.Forms.TextBox();
            this.txtüreticifirma = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.kategoricombo = new System.Windows.Forms.ComboBox();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UreticiFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(97, 25);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 0;
            this.btn_sil.Text = "sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(196, 25);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(64, 23);
            this.btn_temizle.TabIndex = 1;
            this.btn_temizle.Text = "temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(294, 25);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(64, 23);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.Text = "çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(294, 241);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(64, 23);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(384, 241);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(64, 23);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // lblurunadi
            // 
            this.lblurunadi.AutoSize = true;
            this.lblurunadi.Location = new System.Drawing.Point(12, 85);
            this.lblurunadi.Name = "lblurunadi";
            this.lblurunadi.Size = new System.Drawing.Size(51, 13);
            this.lblurunadi.TabIndex = 5;
            this.lblurunadi.Text = "Ürün Adı:";
            // 
            // lblureticifirma
            // 
            this.lblureticifirma.AutoSize = true;
            this.lblureticifirma.Location = new System.Drawing.Point(12, 129);
            this.lblureticifirma.Name = "lblureticifirma";
            this.lblureticifirma.Size = new System.Drawing.Size(68, 13);
            this.lblureticifirma.TabIndex = 6;
            this.lblureticifirma.Text = "Üretici Firma:";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(12, 175);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(32, 13);
            this.lblfiyat.TabIndex = 7;
            this.lblfiyat.Text = "Fiyat:";
            // 
            // lblkategoriadi
            // 
            this.lblkategoriadi.AutoSize = true;
            this.lblkategoriadi.Location = new System.Drawing.Point(12, 209);
            this.lblkategoriadi.Name = "lblkategoriadi";
            this.lblkategoriadi.Size = new System.Drawing.Size(70, 13);
            this.lblkategoriadi.TabIndex = 8;
            this.lblkategoriadi.Text = " Kategori Adi:";
            // 
            // txtürünadi
            // 
            this.txtürünadi.Location = new System.Drawing.Point(132, 82);
            this.txtürünadi.Name = "txtürünadi";
            this.txtürünadi.Size = new System.Drawing.Size(100, 20);
            this.txtürünadi.TabIndex = 9;
            // 
            // txtüreticifirma
            // 
            this.txtüreticifirma.Location = new System.Drawing.Point(132, 122);
            this.txtüreticifirma.Name = "txtüreticifirma";
            this.txtüreticifirma.Size = new System.Drawing.Size(100, 20);
            this.txtüreticifirma.TabIndex = 10;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(132, 168);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 11;
            // 
            // kategoricombo
            // 
            this.kategoricombo.FormattingEnabled = true;
            this.kategoricombo.Location = new System.Drawing.Point(132, 209);
            this.kategoricombo.Name = "kategoricombo";
            this.kategoricombo.Size = new System.Drawing.Size(121, 21);
            this.kategoricombo.TabIndex = 12;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UrunAdi,
            this.UreticiFirma,
            this.Fiyat,
            this.KategoriAdi});
            this.liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.liste.Location = new System.Drawing.Point(0, 279);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(694, 82);
            this.liste.TabIndex = 13;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "UrunAdi";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // UreticiFirma
            // 
            this.UreticiFirma.HeaderText = "UreticiFirma";
            this.UreticiFirma.Name = "UreticiFirma";
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.HeaderText = "KategoriAdi";
            this.KategoriAdi.Name = "KategoriAdi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.kategoricombo);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txtüreticifirma);
            this.Controls.Add(this.txtürünadi);
            this.Controls.Add(this.lblkategoriadi);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lblureticifirma);
            this.Controls.Add(this.lblurunadi);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label lblurunadi;
        private System.Windows.Forms.Label lblureticifirma;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lblkategoriadi;
        private System.Windows.Forms.TextBox txtürünadi;
        private System.Windows.Forms.TextBox txtüreticifirma;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.ComboBox kategoricombo;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UreticiFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
    }
}

