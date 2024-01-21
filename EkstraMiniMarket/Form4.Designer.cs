namespace EkstraMiniMarket
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tabControlDukkanIslemleri = new System.Windows.Forms.TabControl();
            this.tabPageUrunKatalogu = new System.Windows.Forms.TabPage();
            this.btnSatisIslemleriGecis = new System.Windows.Forms.Button();
            this.lbUrunKatalogu = new System.Windows.Forms.ListBox();
            this.labelUrunKatalogu = new System.Windows.Forms.Label();
            this.tabPageUrunEkle = new System.Windows.Forms.TabPage();
            this.lblEklenenUrun = new System.Windows.Forms.Label();
            this.nudUrunAdedi = new System.Windows.Forms.NumericUpDown();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapDefteriGoruntule = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.lbUrunFiyati = new System.Windows.Forms.Label();
            this.cmbUrunTanimi = new System.Windows.Forms.ComboBox();
            this.lbUrunTanimi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lbUrunAdi = new System.Windows.Forms.Label();
            this.tabPageUrunGuncelle = new System.Windows.Forms.TabPage();
            this.btnHesapDefteri = new System.Windows.Forms.Button();
            this.lblGuncellenenUrun = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.nudStokUrunAdedi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStokUrunKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageHesapDefteri = new System.Windows.Forms.TabPage();
            this.lblToplamSatisTutari = new System.Windows.Forms.Label();
            this.lbToplamSatisTutariyazi = new System.Windows.Forms.Label();
            this.lblSatoktakiUrunSayisi = new System.Windows.Forms.Label();
            this.lbStoktakiUrunSayisiyazi = new System.Windows.Forms.Label();
            this.tabPageKasiyerEkle = new System.Windows.Forms.TabPage();
            this.lblEklenenKasiyer = new System.Windows.Forms.Label();
            this.btnKasiyerEkle = new System.Windows.Forms.Button();
            this.txtEklenenSigortaNo = new System.Windows.Forms.TextBox();
            this.lblSigortaNo = new System.Windows.Forms.Label();
            this.txtEklenenKasiyerSoyadi = new System.Windows.Forms.TextBox();
            this.lblEklenenKasiyerSoyad = new System.Windows.Forms.Label();
            this.txtEklenenKasiyerAd = new System.Windows.Forms.TextBox();
            this.lblEklenenKasiyerAd = new System.Windows.Forms.Label();
            this.tabControlDukkanIslemleri.SuspendLayout();
            this.tabPageUrunKatalogu.SuspendLayout();
            this.tabPageUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdedi)).BeginInit();
            this.tabPageUrunGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokUrunAdedi)).BeginInit();
            this.tabPageHesapDefteri.SuspendLayout();
            this.tabPageKasiyerEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDukkanIslemleri
            // 
            this.tabControlDukkanIslemleri.Controls.Add(this.tabPageUrunKatalogu);
            this.tabControlDukkanIslemleri.Controls.Add(this.tabPageUrunEkle);
            this.tabControlDukkanIslemleri.Controls.Add(this.tabPageUrunGuncelle);
            this.tabControlDukkanIslemleri.Controls.Add(this.tabPageHesapDefteri);
            this.tabControlDukkanIslemleri.Controls.Add(this.tabPageKasiyerEkle);
            this.tabControlDukkanIslemleri.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlDukkanIslemleri.Location = new System.Drawing.Point(35, 156);
            this.tabControlDukkanIslemleri.Name = "tabControlDukkanIslemleri";
            this.tabControlDukkanIslemleri.SelectedIndex = 0;
            this.tabControlDukkanIslemleri.Size = new System.Drawing.Size(801, 351);
            this.tabControlDukkanIslemleri.TabIndex = 3;
            // 
            // tabPageUrunKatalogu
            // 
            this.tabPageUrunKatalogu.BackColor = System.Drawing.Color.White;
            this.tabPageUrunKatalogu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageUrunKatalogu.BackgroundImage")));
            this.tabPageUrunKatalogu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageUrunKatalogu.Controls.Add(this.btnSatisIslemleriGecis);
            this.tabPageUrunKatalogu.Controls.Add(this.lbUrunKatalogu);
            this.tabPageUrunKatalogu.Controls.Add(this.labelUrunKatalogu);
            this.tabPageUrunKatalogu.Location = new System.Drawing.Point(4, 26);
            this.tabPageUrunKatalogu.Name = "tabPageUrunKatalogu";
            this.tabPageUrunKatalogu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunKatalogu.Size = new System.Drawing.Size(793, 321);
            this.tabPageUrunKatalogu.TabIndex = 0;
            this.tabPageUrunKatalogu.Text = "Ürün Kataloğu";
            // 
            // btnSatisIslemleriGecis
            // 
            this.btnSatisIslemleriGecis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSatisIslemleriGecis.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisIslemleriGecis.ForeColor = System.Drawing.Color.White;
            this.btnSatisIslemleriGecis.Location = new System.Drawing.Point(591, 118);
            this.btnSatisIslemleriGecis.Name = "btnSatisIslemleriGecis";
            this.btnSatisIslemleriGecis.Size = new System.Drawing.Size(168, 72);
            this.btnSatisIslemleriGecis.TabIndex = 5;
            this.btnSatisIslemleriGecis.Text = "Satış İşlemlerine Geç";
            this.btnSatisIslemleriGecis.UseVisualStyleBackColor = false;
            this.btnSatisIslemleriGecis.Click += new System.EventHandler(this.btnSatisIslemleriGecis_Click_1);
            // 
            // lbUrunKatalogu
            // 
            this.lbUrunKatalogu.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunKatalogu.FormattingEnabled = true;
            this.lbUrunKatalogu.ItemHeight = 14;
            this.lbUrunKatalogu.Location = new System.Drawing.Point(6, 61);
            this.lbUrunKatalogu.Name = "lbUrunKatalogu";
            this.lbUrunKatalogu.Size = new System.Drawing.Size(213, 242);
            this.lbUrunKatalogu.TabIndex = 4;
            this.lbUrunKatalogu.SelectedIndexChanged += new System.EventHandler(this.lbUrunKatalogu_SelectedIndexChanged_1);
            // 
            // labelUrunKatalogu
            // 
            this.labelUrunKatalogu.AutoSize = true;
            this.labelUrunKatalogu.BackColor = System.Drawing.Color.White;
            this.labelUrunKatalogu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunKatalogu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUrunKatalogu.Location = new System.Drawing.Point(19, 24);
            this.labelUrunKatalogu.Name = "labelUrunKatalogu";
            this.labelUrunKatalogu.Size = new System.Drawing.Size(175, 22);
            this.labelUrunKatalogu.TabIndex = 1;
            this.labelUrunKatalogu.Text = "ÜRÜN KATALOĞU";
            // 
            // tabPageUrunEkle
            // 
            this.tabPageUrunEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageUrunEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageUrunEkle.BackgroundImage")));
            this.tabPageUrunEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageUrunEkle.Controls.Add(this.lblEklenenUrun);
            this.tabPageUrunEkle.Controls.Add(this.nudUrunAdedi);
            this.tabPageUrunEkle.Controls.Add(this.txtUrunKodu);
            this.tabPageUrunEkle.Controls.Add(this.lblUrunKodu);
            this.tabPageUrunEkle.Controls.Add(this.label1);
            this.tabPageUrunEkle.Controls.Add(this.btnHesapDefteriGoruntule);
            this.tabPageUrunEkle.Controls.Add(this.btnEkle);
            this.tabPageUrunEkle.Controls.Add(this.txtUrunFiyati);
            this.tabPageUrunEkle.Controls.Add(this.lbUrunFiyati);
            this.tabPageUrunEkle.Controls.Add(this.cmbUrunTanimi);
            this.tabPageUrunEkle.Controls.Add(this.lbUrunTanimi);
            this.tabPageUrunEkle.Controls.Add(this.txtUrunAdi);
            this.tabPageUrunEkle.Controls.Add(this.lbUrunAdi);
            this.tabPageUrunEkle.Location = new System.Drawing.Point(4, 26);
            this.tabPageUrunEkle.Name = "tabPageUrunEkle";
            this.tabPageUrunEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunEkle.Size = new System.Drawing.Size(793, 321);
            this.tabPageUrunEkle.TabIndex = 1;
            this.tabPageUrunEkle.Text = "Ürün Ekle";
            // 
            // lblEklenenUrun
            // 
            this.lblEklenenUrun.AutoSize = true;
            this.lblEklenenUrun.Location = new System.Drawing.Point(278, 23);
            this.lblEklenenUrun.Name = "lblEklenenUrun";
            this.lblEklenenUrun.Size = new System.Drawing.Size(0, 17);
            this.lblEklenenUrun.TabIndex = 23;
            // 
            // nudUrunAdedi
            // 
            this.nudUrunAdedi.Location = new System.Drawing.Point(408, 51);
            this.nudUrunAdedi.Name = "nudUrunAdedi";
            this.nudUrunAdedi.Size = new System.Drawing.Size(120, 24);
            this.nudUrunAdedi.TabIndex = 4;
            this.nudUrunAdedi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunKodu.Location = new System.Drawing.Point(136, 24);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(121, 24);
            this.txtUrunKodu.TabIndex = 0;
            this.txtUrunKodu.TextChanged += new System.EventHandler(this.txtUrunKodu_TextChanged_1);
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunKodu.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.Location = new System.Drawing.Point(15, 24);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(101, 18);
            this.lblUrunKodu.TabIndex = 20;
            this.lblUrunKodu.Text = "Ürün Kodu  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(301, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ürün Adedi : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHesapDefteriGoruntule
            // 
            this.btnHesapDefteriGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHesapDefteriGoruntule.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapDefteriGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnHesapDefteriGoruntule.Location = new System.Drawing.Point(626, 65);
            this.btnHesapDefteriGoruntule.Name = "btnHesapDefteriGoruntule";
            this.btnHesapDefteriGoruntule.Size = new System.Drawing.Size(149, 46);
            this.btnHesapDefteriGoruntule.TabIndex = 6;
            this.btnHesapDefteriGoruntule.Text = "Hesap Defterini Görüntüle";
            this.btnHesapDefteriGoruntule.UseVisualStyleBackColor = false;
            this.btnHesapDefteriGoruntule.Click += new System.EventHandler(this.btnHesapDefteriGoruntule_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEkle.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(626, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(149, 39);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunFiyati.Location = new System.Drawing.Point(407, 20);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(121, 24);
            this.txtUrunFiyati.TabIndex = 3;
            this.txtUrunFiyati.TextChanged += new System.EventHandler(this.txtUrunFiyati_TextChanged_1);
            // 
            // lbUrunFiyati
            // 
            this.lbUrunFiyati.AutoSize = true;
            this.lbUrunFiyati.BackColor = System.Drawing.Color.Transparent;
            this.lbUrunFiyati.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunFiyati.Location = new System.Drawing.Point(302, 23);
            this.lbUrunFiyati.Name = "lbUrunFiyati";
            this.lbUrunFiyati.Size = new System.Drawing.Size(103, 18);
            this.lbUrunFiyati.TabIndex = 14;
            this.lbUrunFiyati.Text = "Ürün Fiyatı  : ";
            this.lbUrunFiyati.Click += new System.EventHandler(this.lbUrunFiyati_Click);
            // 
            // cmbUrunTanimi
            // 
            this.cmbUrunTanimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunTanimi.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunTanimi.FormattingEnabled = true;
            this.cmbUrunTanimi.Items.AddRange(new object[] {
            "Gıda",
            "Bakım",
            "Elektronik"});
            this.cmbUrunTanimi.Location = new System.Drawing.Point(137, 54);
            this.cmbUrunTanimi.Name = "cmbUrunTanimi";
            this.cmbUrunTanimi.Size = new System.Drawing.Size(121, 25);
            this.cmbUrunTanimi.TabIndex = 1;
            this.cmbUrunTanimi.SelectedIndexChanged += new System.EventHandler(this.cmbUrunTanimi_SelectedIndexChanged);
            // 
            // lbUrunTanimi
            // 
            this.lbUrunTanimi.AutoSize = true;
            this.lbUrunTanimi.BackColor = System.Drawing.Color.Transparent;
            this.lbUrunTanimi.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunTanimi.Location = new System.Drawing.Point(16, 55);
            this.lbUrunTanimi.Name = "lbUrunTanimi";
            this.lbUrunTanimi.Size = new System.Drawing.Size(114, 18);
            this.lbUrunTanimi.TabIndex = 12;
            this.lbUrunTanimi.Text = "Ürün Tanımı  : ";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(137, 87);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(121, 24);
            this.txtUrunAdi.TabIndex = 2;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // lbUrunAdi
            // 
            this.lbUrunAdi.AutoSize = true;
            this.lbUrunAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbUrunAdi.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunAdi.Location = new System.Drawing.Point(16, 87);
            this.lbUrunAdi.Name = "lbUrunAdi";
            this.lbUrunAdi.Size = new System.Drawing.Size(88, 18);
            this.lbUrunAdi.TabIndex = 10;
            this.lbUrunAdi.Text = "Ürün Adi  : ";
            // 
            // tabPageUrunGuncelle
            // 
            this.tabPageUrunGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageUrunGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageUrunGuncelle.BackgroundImage")));
            this.tabPageUrunGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageUrunGuncelle.Controls.Add(this.btnHesapDefteri);
            this.tabPageUrunGuncelle.Controls.Add(this.lblGuncellenenUrun);
            this.tabPageUrunGuncelle.Controls.Add(this.btnGuncelle);
            this.tabPageUrunGuncelle.Controls.Add(this.nudStokUrunAdedi);
            this.tabPageUrunGuncelle.Controls.Add(this.label3);
            this.tabPageUrunGuncelle.Controls.Add(this.txtStokUrunKodu);
            this.tabPageUrunGuncelle.Controls.Add(this.label2);
            this.tabPageUrunGuncelle.Location = new System.Drawing.Point(4, 26);
            this.tabPageUrunGuncelle.Name = "tabPageUrunGuncelle";
            this.tabPageUrunGuncelle.Size = new System.Drawing.Size(793, 321);
            this.tabPageUrunGuncelle.TabIndex = 3;
            this.tabPageUrunGuncelle.Text = "Ürün Güncelle";
            // 
            // btnHesapDefteri
            // 
            this.btnHesapDefteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHesapDefteri.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapDefteri.ForeColor = System.Drawing.Color.White;
            this.btnHesapDefteri.Location = new System.Drawing.Point(625, 72);
            this.btnHesapDefteri.Name = "btnHesapDefteri";
            this.btnHesapDefteri.Size = new System.Drawing.Size(138, 46);
            this.btnHesapDefteri.TabIndex = 27;
            this.btnHesapDefteri.Text = "Hesap Defterini Görüntüle";
            this.btnHesapDefteri.UseVisualStyleBackColor = false;
            this.btnHesapDefteri.Click += new System.EventHandler(this.btnHesapDefteri_Click_1);
            // 
            // lblGuncellenenUrun
            // 
            this.lblGuncellenenUrun.AutoSize = true;
            this.lblGuncellenenUrun.Location = new System.Drawing.Point(338, 16);
            this.lblGuncellenenUrun.Name = "lblGuncellenenUrun";
            this.lblGuncellenenUrun.Size = new System.Drawing.Size(0, 17);
            this.lblGuncellenenUrun.TabIndex = 26;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(625, 19);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(138, 42);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // nudStokUrunAdedi
            // 
            this.nudStokUrunAdedi.Location = new System.Drawing.Point(312, 59);
            this.nudStokUrunAdedi.Name = "nudStokUrunAdedi";
            this.nudStokUrunAdedi.Size = new System.Drawing.Size(121, 24);
            this.nudStokUrunAdedi.TabIndex = 23;
            this.nudStokUrunAdedi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(95, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Eklenecek Ürün Adedi : ";
            // 
            // txtStokUrunKodu
            // 
            this.txtStokUrunKodu.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokUrunKodu.Location = new System.Drawing.Point(313, 29);
            this.txtStokUrunKodu.Name = "txtStokUrunKodu";
            this.txtStokUrunKodu.Size = new System.Drawing.Size(121, 24);
            this.txtStokUrunKodu.TabIndex = 21;
            this.txtStokUrunKodu.TextChanged += new System.EventHandler(this.txtStokUrunKodu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ürün Kodu  : ";
            // 
            // tabPageHesapDefteri
            // 
            this.tabPageHesapDefteri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageHesapDefteri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageHesapDefteri.BackgroundImage")));
            this.tabPageHesapDefteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageHesapDefteri.Controls.Add(this.lblToplamSatisTutari);
            this.tabPageHesapDefteri.Controls.Add(this.lbToplamSatisTutariyazi);
            this.tabPageHesapDefteri.Controls.Add(this.lblSatoktakiUrunSayisi);
            this.tabPageHesapDefteri.Controls.Add(this.lbStoktakiUrunSayisiyazi);
            this.tabPageHesapDefteri.Location = new System.Drawing.Point(4, 26);
            this.tabPageHesapDefteri.Name = "tabPageHesapDefteri";
            this.tabPageHesapDefteri.Size = new System.Drawing.Size(793, 321);
            this.tabPageHesapDefteri.TabIndex = 2;
            this.tabPageHesapDefteri.Text = "Hesap Defteri";
            // 
            // lblToplamSatisTutari
            // 
            this.lblToplamSatisTutari.AutoSize = true;
            this.lblToplamSatisTutari.BackColor = System.Drawing.Color.White;
            this.lblToplamSatisTutari.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSatisTutari.Location = new System.Drawing.Point(262, 65);
            this.lblToplamSatisTutari.Name = "lblToplamSatisTutari";
            this.lblToplamSatisTutari.Size = new System.Drawing.Size(56, 18);
            this.lblToplamSatisTutari.TabIndex = 10;
            this.lblToplamSatisTutari.Text = "______";
            // 
            // lbToplamSatisTutariyazi
            // 
            this.lbToplamSatisTutariyazi.AutoSize = true;
            this.lbToplamSatisTutariyazi.BackColor = System.Drawing.Color.Transparent;
            this.lbToplamSatisTutariyazi.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbToplamSatisTutariyazi.Location = new System.Drawing.Point(66, 63);
            this.lbToplamSatisTutariyazi.Name = "lbToplamSatisTutariyazi";
            this.lbToplamSatisTutariyazi.Size = new System.Drawing.Size(188, 21);
            this.lbToplamSatisTutariyazi.TabIndex = 9;
            this.lbToplamSatisTutariyazi.Text = "Toplam Satış Tutarı : ";
            // 
            // lblSatoktakiUrunSayisi
            // 
            this.lblSatoktakiUrunSayisi.AutoSize = true;
            this.lblSatoktakiUrunSayisi.BackColor = System.Drawing.Color.White;
            this.lblSatoktakiUrunSayisi.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatoktakiUrunSayisi.Location = new System.Drawing.Point(262, 35);
            this.lblSatoktakiUrunSayisi.Name = "lblSatoktakiUrunSayisi";
            this.lblSatoktakiUrunSayisi.Size = new System.Drawing.Size(56, 18);
            this.lblSatoktakiUrunSayisi.TabIndex = 8;
            this.lblSatoktakiUrunSayisi.Text = "______";
            // 
            // lbStoktakiUrunSayisiyazi
            // 
            this.lbStoktakiUrunSayisiyazi.AutoSize = true;
            this.lbStoktakiUrunSayisiyazi.BackColor = System.Drawing.Color.Transparent;
            this.lbStoktakiUrunSayisiyazi.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbStoktakiUrunSayisiyazi.Location = new System.Drawing.Point(66, 33);
            this.lbStoktakiUrunSayisiyazi.Name = "lbStoktakiUrunSayisiyazi";
            this.lbStoktakiUrunSayisiyazi.Size = new System.Drawing.Size(190, 21);
            this.lbStoktakiUrunSayisiyazi.TabIndex = 7;
            this.lbStoktakiUrunSayisiyazi.Text = "Stoktaki Ürün Sayısı : ";
            // 
            // tabPageKasiyerEkle
            // 
            this.tabPageKasiyerEkle.BackColor = System.Drawing.Color.White;
            this.tabPageKasiyerEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageKasiyerEkle.BackgroundImage")));
            this.tabPageKasiyerEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageKasiyerEkle.Controls.Add(this.lblEklenenKasiyer);
            this.tabPageKasiyerEkle.Controls.Add(this.btnKasiyerEkle);
            this.tabPageKasiyerEkle.Controls.Add(this.txtEklenenSigortaNo);
            this.tabPageKasiyerEkle.Controls.Add(this.lblSigortaNo);
            this.tabPageKasiyerEkle.Controls.Add(this.txtEklenenKasiyerSoyadi);
            this.tabPageKasiyerEkle.Controls.Add(this.lblEklenenKasiyerSoyad);
            this.tabPageKasiyerEkle.Controls.Add(this.txtEklenenKasiyerAd);
            this.tabPageKasiyerEkle.Controls.Add(this.lblEklenenKasiyerAd);
            this.tabPageKasiyerEkle.Location = new System.Drawing.Point(4, 26);
            this.tabPageKasiyerEkle.Name = "tabPageKasiyerEkle";
            this.tabPageKasiyerEkle.Size = new System.Drawing.Size(793, 321);
            this.tabPageKasiyerEkle.TabIndex = 4;
            this.tabPageKasiyerEkle.Text = "Kasiyer Ekle";
            this.tabPageKasiyerEkle.Click += new System.EventHandler(this.tabPageKasiyerEkle_Click);
            // 
            // lblEklenenKasiyer
            // 
            this.lblEklenenKasiyer.AutoSize = true;
            this.lblEklenenKasiyer.Location = new System.Drawing.Point(250, 19);
            this.lblEklenenKasiyer.Name = "lblEklenenKasiyer";
            this.lblEklenenKasiyer.Size = new System.Drawing.Size(0, 17);
            this.lblEklenenKasiyer.TabIndex = 28;
            // 
            // btnKasiyerEkle
            // 
            this.btnKasiyerEkle.BackColor = System.Drawing.Color.Chocolate;
            this.btnKasiyerEkle.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasiyerEkle.ForeColor = System.Drawing.Color.White;
            this.btnKasiyerEkle.Location = new System.Drawing.Point(71, 179);
            this.btnKasiyerEkle.Name = "btnKasiyerEkle";
            this.btnKasiyerEkle.Size = new System.Drawing.Size(113, 47);
            this.btnKasiyerEkle.TabIndex = 27;
            this.btnKasiyerEkle.Text = "Ekle";
            this.btnKasiyerEkle.UseVisualStyleBackColor = false;
            this.btnKasiyerEkle.Click += new System.EventHandler(this.btnKasiyerEkle_Click_1);
            // 
            // txtEklenenSigortaNo
            // 
            this.txtEklenenSigortaNo.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklenenSigortaNo.ForeColor = System.Drawing.Color.Black;
            this.txtEklenenSigortaNo.Location = new System.Drawing.Point(175, 123);
            this.txtEklenenSigortaNo.Name = "txtEklenenSigortaNo";
            this.txtEklenenSigortaNo.Size = new System.Drawing.Size(132, 24);
            this.txtEklenenSigortaNo.TabIndex = 25;
            // 
            // lblSigortaNo
            // 
            this.lblSigortaNo.AutoSize = true;
            this.lblSigortaNo.BackColor = System.Drawing.Color.White;
            this.lblSigortaNo.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSigortaNo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblSigortaNo.Location = new System.Drawing.Point(22, 122);
            this.lblSigortaNo.Name = "lblSigortaNo";
            this.lblSigortaNo.Size = new System.Drawing.Size(118, 21);
            this.lblSigortaNo.TabIndex = 26;
            this.lblSigortaNo.Text = "Sigorta No  : ";
            // 
            // txtEklenenKasiyerSoyadi
            // 
            this.txtEklenenKasiyerSoyadi.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklenenKasiyerSoyadi.ForeColor = System.Drawing.Color.Black;
            this.txtEklenenKasiyerSoyadi.Location = new System.Drawing.Point(175, 78);
            this.txtEklenenKasiyerSoyadi.Name = "txtEklenenKasiyerSoyadi";
            this.txtEklenenKasiyerSoyadi.Size = new System.Drawing.Size(132, 24);
            this.txtEklenenKasiyerSoyadi.TabIndex = 23;
            // 
            // lblEklenenKasiyerSoyad
            // 
            this.lblEklenenKasiyerSoyad.AutoSize = true;
            this.lblEklenenKasiyerSoyad.BackColor = System.Drawing.Color.White;
            this.lblEklenenKasiyerSoyad.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEklenenKasiyerSoyad.ForeColor = System.Drawing.Color.Chocolate;
            this.lblEklenenKasiyerSoyad.Location = new System.Drawing.Point(22, 78);
            this.lblEklenenKasiyerSoyad.Name = "lblEklenenKasiyerSoyad";
            this.lblEklenenKasiyerSoyad.Size = new System.Drawing.Size(144, 21);
            this.lblEklenenKasiyerSoyad.TabIndex = 24;
            this.lblEklenenKasiyerSoyad.Text = "Kasiyer Soyadı : ";
            // 
            // txtEklenenKasiyerAd
            // 
            this.txtEklenenKasiyerAd.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklenenKasiyerAd.ForeColor = System.Drawing.Color.Black;
            this.txtEklenenKasiyerAd.Location = new System.Drawing.Point(176, 33);
            this.txtEklenenKasiyerAd.Name = "txtEklenenKasiyerAd";
            this.txtEklenenKasiyerAd.Size = new System.Drawing.Size(131, 24);
            this.txtEklenenKasiyerAd.TabIndex = 21;
            // 
            // lblEklenenKasiyerAd
            // 
            this.lblEklenenKasiyerAd.AutoSize = true;
            this.lblEklenenKasiyerAd.BackColor = System.Drawing.Color.White;
            this.lblEklenenKasiyerAd.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEklenenKasiyerAd.ForeColor = System.Drawing.Color.Chocolate;
            this.lblEklenenKasiyerAd.Location = new System.Drawing.Point(22, 33);
            this.lblEklenenKasiyerAd.Name = "lblEklenenKasiyerAd";
            this.lblEklenenKasiyerAd.Size = new System.Drawing.Size(118, 21);
            this.lblEklenenKasiyerAd.TabIndex = 22;
            this.lblEklenenKasiyerAd.Text = "Kasiyer Adı : ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 508);
            this.Controls.Add(this.tabControlDukkanIslemleri);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControlDukkanIslemleri.ResumeLayout(false);
            this.tabPageUrunKatalogu.ResumeLayout(false);
            this.tabPageUrunKatalogu.PerformLayout();
            this.tabPageUrunEkle.ResumeLayout(false);
            this.tabPageUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdedi)).EndInit();
            this.tabPageUrunGuncelle.ResumeLayout(false);
            this.tabPageUrunGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokUrunAdedi)).EndInit();
            this.tabPageHesapDefteri.ResumeLayout(false);
            this.tabPageHesapDefteri.PerformLayout();
            this.tabPageKasiyerEkle.ResumeLayout(false);
            this.tabPageKasiyerEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDukkanIslemleri;
        private System.Windows.Forms.TabPage tabPageUrunKatalogu;
        private System.Windows.Forms.Button btnSatisIslemleriGecis;
        private System.Windows.Forms.ListBox lbUrunKatalogu;
        private System.Windows.Forms.Label labelUrunKatalogu;
        private System.Windows.Forms.TabPage tabPageUrunEkle;
        private System.Windows.Forms.Label lblEklenenUrun;
        private System.Windows.Forms.NumericUpDown nudUrunAdedi;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapDefteriGoruntule;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.Label lbUrunFiyati;
        private System.Windows.Forms.ComboBox cmbUrunTanimi;
        private System.Windows.Forms.Label lbUrunTanimi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lbUrunAdi;
        private System.Windows.Forms.TabPage tabPageUrunGuncelle;
        private System.Windows.Forms.Button btnHesapDefteri;
        private System.Windows.Forms.Label lblGuncellenenUrun;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.NumericUpDown nudStokUrunAdedi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStokUrunKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageHesapDefteri;
        private System.Windows.Forms.Label lblToplamSatisTutari;
        private System.Windows.Forms.Label lbToplamSatisTutariyazi;
        private System.Windows.Forms.Label lblSatoktakiUrunSayisi;
        private System.Windows.Forms.Label lbStoktakiUrunSayisiyazi;
        private System.Windows.Forms.TabPage tabPageKasiyerEkle;
        private System.Windows.Forms.Label lblEklenenKasiyer;
        private System.Windows.Forms.Button btnKasiyerEkle;
        private System.Windows.Forms.TextBox txtEklenenSigortaNo;
        private System.Windows.Forms.Label lblSigortaNo;
        private System.Windows.Forms.TextBox txtEklenenKasiyerSoyadi;
        private System.Windows.Forms.Label lblEklenenKasiyerSoyad;
        private System.Windows.Forms.TextBox txtEklenenKasiyerAd;
        private System.Windows.Forms.Label lblEklenenKasiyerAd;
    }
}