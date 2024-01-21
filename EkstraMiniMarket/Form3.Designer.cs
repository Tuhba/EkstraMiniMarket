namespace EkstraMiniMarket
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnYeniSatisIslemi = new System.Windows.Forms.Button();
            this.btnDukkanIslemleri = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lblIndirimliTutar = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.labelOdeme = new System.Windows.Forms.Label();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.btnSiparişOnay = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnToplamTutarHesapla = new System.Windows.Forms.Button();
            this.labelToplamTutar = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.labelSepet = new System.Windows.Forms.Label();
            this.lbSepet = new System.Windows.Forms.ListBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.labelTutar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.labelAdet = new System.Windows.Forms.Label();
            this.lbUrunler = new System.Windows.Forms.ListBox();
            this.labelUrunler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniSatisIslemi
            // 
            this.btnYeniSatisIslemi.BackColor = System.Drawing.Color.Red;
            this.btnYeniSatisIslemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniSatisIslemi.ForeColor = System.Drawing.Color.White;
            this.btnYeniSatisIslemi.Location = new System.Drawing.Point(929, 535);
            this.btnYeniSatisIslemi.Name = "btnYeniSatisIslemi";
            this.btnYeniSatisIslemi.Size = new System.Drawing.Size(104, 53);
            this.btnYeniSatisIslemi.TabIndex = 96;
            this.btnYeniSatisIslemi.Text = "Yeni Satış İşlemi";
            this.btnYeniSatisIslemi.UseVisualStyleBackColor = false;
            this.btnYeniSatisIslemi.Click += new System.EventHandler(this.btnYeniSatisIslemi_Click_1);
            // 
            // btnDukkanIslemleri
            // 
            this.btnDukkanIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDukkanIslemleri.ForeColor = System.Drawing.Color.Red;
            this.btnDukkanIslemleri.Location = new System.Drawing.Point(446, 270);
            this.btnDukkanIslemleri.Name = "btnDukkanIslemleri";
            this.btnDukkanIslemleri.Size = new System.Drawing.Size(173, 56);
            this.btnDukkanIslemleri.TabIndex = 95;
            this.btnDukkanIslemleri.Text = "Dükkan İşlemleri";
            this.btnDukkanIslemleri.UseVisualStyleBackColor = true;
            this.btnDukkanIslemleri.Click += new System.EventHandler(this.btnDukkanIslemleri_Click_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(762, 492);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(125, 23);
            this.label.TabIndex = 94;
            this.label.Text = "İndirimli Tutar:";
            // 
            // lblIndirimliTutar
            // 
            this.lblIndirimliTutar.AutoSize = true;
            this.lblIndirimliTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblIndirimliTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIndirimliTutar.Location = new System.Drawing.Point(894, 502);
            this.lblIndirimliTutar.Name = "lblIndirimliTutar";
            this.lblIndirimliTutar.Size = new System.Drawing.Size(49, 13);
            this.lblIndirimliTutar.TabIndex = 93;
            this.lblIndirimliTutar.Text = "              ";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(101, 535);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(55, 13);
            this.lblTutar.TabIndex = 92;
            this.lblTutar.Text = "                ";
            // 
            // labelOdeme
            // 
            this.labelOdeme.AutoSize = true;
            this.labelOdeme.BackColor = System.Drawing.Color.Transparent;
            this.labelOdeme.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdeme.Location = new System.Drawing.Point(717, 398);
            this.labelOdeme.Name = "labelOdeme";
            this.labelOdeme.Size = new System.Drawing.Size(70, 21);
            this.labelOdeme.TabIndex = 91;
            this.labelOdeme.Text = "Ödeme:";
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.BackColor = System.Drawing.Color.Transparent;
            this.rbKrediKarti.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKrediKarti.Location = new System.Drawing.Point(869, 398);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(112, 25);
            this.rbKrediKarti.TabIndex = 90;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = false;
            this.rbKrediKarti.CheckedChanged += new System.EventHandler(this.rbKrediKarti_CheckedChanged_1);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.BackColor = System.Drawing.Color.Transparent;
            this.rbNakit.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.Location = new System.Drawing.Point(793, 398);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(70, 25);
            this.rbNakit.TabIndex = 89;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = false;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged_1);
            // 
            // btnSiparişOnay
            // 
            this.btnSiparişOnay.BackColor = System.Drawing.Color.Red;
            this.btnSiparişOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparişOnay.ForeColor = System.Drawing.Color.White;
            this.btnSiparişOnay.Location = new System.Drawing.Point(709, 535);
            this.btnSiparişOnay.Name = "btnSiparişOnay";
            this.btnSiparişOnay.Size = new System.Drawing.Size(104, 52);
            this.btnSiparişOnay.TabIndex = 88;
            this.btnSiparişOnay.Text = "Siparişi Onayla";
            this.btnSiparişOnay.UseVisualStyleBackColor = false;
            this.btnSiparişOnay.Visible = false;
            this.btnSiparişOnay.Click += new System.EventHandler(this.btnSiparişOnay_Click_1);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(104, 481);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(67, 20);
            this.nudAdet.TabIndex = 87;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.ValueChanged += new System.EventHandler(this.nudAdet_ValueChanged);
            // 
            // btnToplamTutarHesapla
            // 
            this.btnToplamTutarHesapla.BackColor = System.Drawing.Color.Red;
            this.btnToplamTutarHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToplamTutarHesapla.ForeColor = System.Drawing.Color.White;
            this.btnToplamTutarHesapla.Location = new System.Drawing.Point(819, 535);
            this.btnToplamTutarHesapla.Name = "btnToplamTutarHesapla";
            this.btnToplamTutarHesapla.Size = new System.Drawing.Size(104, 52);
            this.btnToplamTutarHesapla.TabIndex = 86;
            this.btnToplamTutarHesapla.Text = "Toplam Tutar Hesapla";
            this.btnToplamTutarHesapla.UseVisualStyleBackColor = false;
            this.btnToplamTutarHesapla.Click += new System.EventHandler(this.btnToplamTutarHesapla_Click_1);
            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.BackColor = System.Drawing.Color.Transparent;
            this.labelToplamTutar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelToplamTutar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamTutar.Location = new System.Drawing.Point(762, 451);
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(120, 23);
            this.labelToplamTutar.TabIndex = 85;
            this.labelToplamTutar.Text = "Toplam Tutar:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(894, 456);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(49, 13);
            this.lblToplam.TabIndex = 84;
            this.lblToplam.Text = "              ";
            // 
            // labelSepet
            // 
            this.labelSepet.AutoSize = true;
            this.labelSepet.BackColor = System.Drawing.Color.Transparent;
            this.labelSepet.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSepet.ForeColor = System.Drawing.Color.Red;
            this.labelSepet.Location = new System.Drawing.Point(825, 160);
            this.labelSepet.Name = "labelSepet";
            this.labelSepet.Size = new System.Drawing.Size(71, 21);
            this.labelSepet.TabIndex = 83;
            this.labelSepet.Text = "SEPET\r\n";
            // 
            // lbSepet
            // 
            this.lbSepet.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSepet.FormattingEnabled = true;
            this.lbSepet.ItemHeight = 14;
            this.lbSepet.Location = new System.Drawing.Point(709, 199);
            this.lbSepet.Name = "lbSepet";
            this.lbSepet.Size = new System.Drawing.Size(300, 186);
            this.lbSepet.TabIndex = 82;
            this.lbSepet.SelectedIndexChanged += new System.EventHandler(this.lbSepet_SelectedIndexChanged);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.Red;
            this.btnSepeteEkle.Enabled = false;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.White;
            this.btnSepeteEkle.Location = new System.Drawing.Point(207, 528);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(94, 47);
            this.btnSepeteEkle.TabIndex = 81;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click_1);
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.BackColor = System.Drawing.Color.Transparent;
            this.labelTutar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTutar.CausesValidation = false;
            this.labelTutar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTutar.Location = new System.Drawing.Point(24, 526);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(57, 23);
            this.labelTutar.TabIndex = 80;
            this.labelTutar.Text = "Tutar:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Red;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(207, 472);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(94, 50);
            this.btnHesapla.TabIndex = 79;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click_1);
            // 
            // labelAdet
            // 
            this.labelAdet.AutoSize = true;
            this.labelAdet.BackColor = System.Drawing.Color.Transparent;
            this.labelAdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAdet.CausesValidation = false;
            this.labelAdet.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdet.Location = new System.Drawing.Point(24, 478);
            this.labelAdet.Name = "labelAdet";
            this.labelAdet.Size = new System.Drawing.Size(53, 23);
            this.labelAdet.TabIndex = 78;
            this.labelAdet.Text = "Adet:";
            this.labelAdet.Click += new System.EventHandler(this.labelAdet_Click);
            // 
            // lbUrunler
            // 
            this.lbUrunler.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunler.FormattingEnabled = true;
            this.lbUrunler.ItemHeight = 14;
            this.lbUrunler.Location = new System.Drawing.Point(24, 199);
            this.lbUrunler.Name = "lbUrunler";
            this.lbUrunler.Size = new System.Drawing.Size(277, 242);
            this.lbUrunler.TabIndex = 77;
            this.lbUrunler.SelectedIndexChanged += new System.EventHandler(this.lbUrunler_SelectedIndexChanged_1);
            // 
            // labelUrunler
            // 
            this.labelUrunler.AutoSize = true;
            this.labelUrunler.BackColor = System.Drawing.Color.Transparent;
            this.labelUrunler.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrunler.ForeColor = System.Drawing.Color.Red;
            this.labelUrunler.Location = new System.Drawing.Point(110, 160);
            this.labelUrunler.Name = "labelUrunler";
            this.labelUrunler.Size = new System.Drawing.Size(105, 21);
            this.labelUrunler.TabIndex = 76;
            this.labelUrunler.Text = "ÜRÜNLER";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 615);
            this.Controls.Add(this.btnYeniSatisIslemi);
            this.Controls.Add(this.btnDukkanIslemleri);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblIndirimliTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.labelOdeme);
            this.Controls.Add(this.rbKrediKarti);
            this.Controls.Add(this.rbNakit);
            this.Controls.Add(this.btnSiparişOnay);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.btnToplamTutarHesapla);
            this.Controls.Add(this.labelToplamTutar);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.labelSepet);
            this.Controls.Add(this.lbSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.labelAdet);
            this.Controls.Add(this.lbUrunler);
            this.Controls.Add(this.labelUrunler);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniSatisIslemi;
        private System.Windows.Forms.Button btnDukkanIslemleri;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblIndirimliTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label labelOdeme;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Button btnSiparişOnay;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnToplamTutarHesapla;
        private System.Windows.Forms.Label labelToplamTutar;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label labelSepet;
        private System.Windows.Forms.ListBox lbSepet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label labelAdet;
        private System.Windows.Forms.ListBox lbUrunler;
        private System.Windows.Forms.Label labelUrunler;
    }
}