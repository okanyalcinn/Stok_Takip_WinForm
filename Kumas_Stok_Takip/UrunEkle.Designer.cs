namespace Kumas_Stok_Takip
{
    partial class UrunEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkle));
            this._chkKuruTemizleme = new System.Windows.Forms.CheckBox();
            this._txtCekmePayi = new System.Windows.Forms.TextBox();
            this._chkKurutma = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this._chkCamasirSuyu = new System.Windows.Forms.CheckBox();
            this._txtDerece = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._imgListButon = new System.Windows.Forms.ImageList(this.components);
            this._lblTurKategori2 = new System.Windows.Forms.Label();
            this._dtGridUrunler = new System.Windows.Forms.DataGridView();
            this._cmbDesen = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this._lblTurKategori3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._cmbTur1 = new System.Windows.Forms.ComboBox();
            this._cmbTur3 = new System.Windows.Forms.ComboBox();
            this._cmbTur2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtRenk = new System.Windows.Forms.TextBox();
            this._nmrOran3 = new System.Windows.Forms.NumericUpDown();
            this._nmrOran2 = new System.Windows.Forms.NumericUpDown();
            this._nmrOran1 = new System.Windows.Forms.NumericUpDown();
            this._lblTurKategori1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._chkMakine = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtUrunIsmi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtUrunFiyati = new System.Windows.Forms.TextBox();
            this._txtUzunluk = new System.Windows.Forms.TextBox();
            this._txtGenislik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._txtAgirlik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._nmrAdet = new System.Windows.Forms.NumericUpDown();
            this._imgListDesen = new System.Windows.Forms.ImageList(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this._btnKaydet = new System.Windows.Forms.Button();
            this._btnGuncelle = new System.Windows.Forms.Button();
            this._btnSil = new System.Windows.Forms.Button();
            this._btnTemizle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._dtGridUrunler)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nmrOran3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmrOran2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmrOran1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nmrAdet)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // _chkKuruTemizleme
            // 
            this._chkKuruTemizleme.AutoSize = true;
            this._chkKuruTemizleme.Location = new System.Drawing.Point(37, 56);
            this._chkKuruTemizleme.Name = "_chkKuruTemizleme";
            this._chkKuruTemizleme.Size = new System.Drawing.Size(148, 17);
            this._chkKuruTemizleme.TabIndex = 29;
            this._chkKuruTemizleme.Text = "Kuru Temizleme Yapılabilir";
            this._chkKuruTemizleme.UseVisualStyleBackColor = true;
            // 
            // _txtCekmePayi
            // 
            this._txtCekmePayi.Location = new System.Drawing.Point(113, 155);
            this._txtCekmePayi.Name = "_txtCekmePayi";
            this._txtCekmePayi.Size = new System.Drawing.Size(100, 20);
            this._txtCekmePayi.TabIndex = 35;
            this._txtCekmePayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtUrunFiyati_KeyPress);
            // 
            // _chkKurutma
            // 
            this._chkKurutma.AutoSize = true;
            this._chkKurutma.Location = new System.Drawing.Point(37, 79);
            this._chkKurutma.Name = "_chkKurutma";
            this._chkKurutma.Size = new System.Drawing.Size(185, 17);
            this._chkKurutma.TabIndex = 30;
            this._chkKurutma.Text = "Kurutma Makinesinde Kurutulabilir";
            this._chkKurutma.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Çekme Payı:";
            // 
            // _chkCamasirSuyu
            // 
            this._chkCamasirSuyu.AutoSize = true;
            this._chkCamasirSuyu.Location = new System.Drawing.Point(37, 100);
            this._chkCamasirSuyu.Name = "_chkCamasirSuyu";
            this._chkCamasirSuyu.Size = new System.Drawing.Size(171, 17);
            this._chkCamasirSuyu.TabIndex = 31;
            this._chkCamasirSuyu.Text = "Çamaşır Suyundan Zarar Görür";
            this._chkCamasirSuyu.UseVisualStyleBackColor = true;
            // 
            // _txtDerece
            // 
            this._txtDerece.Location = new System.Drawing.Point(113, 129);
            this._txtDerece.Name = "_txtDerece";
            this._txtDerece.Size = new System.Drawing.Size(100, 20);
            this._txtDerece.TabIndex = 33;
            this._txtDerece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtUrunFiyati_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Derecesi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Desen:";
            // 
            // _imgListButon
            // 
            this._imgListButon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgListButon.ImageStream")));
            this._imgListButon.TransparentColor = System.Drawing.Color.Transparent;
            this._imgListButon.Images.SetKeyName(0, "clean.ico");
            this._imgListButon.Images.SetKeyName(1, "ok.ico");
            this._imgListButon.Images.SetKeyName(2, "reload.ico");
            this._imgListButon.Images.SetKeyName(3, "search.ico");
            this._imgListButon.Images.SetKeyName(4, "silgi.jpg");
            this._imgListButon.Images.SetKeyName(5, "remove.ico");
            this._imgListButon.Images.SetKeyName(6, "remove.ico");
            // 
            // _lblTurKategori2
            // 
            this._lblTurKategori2.AutoSize = true;
            this._lblTurKategori2.Location = new System.Drawing.Point(271, 121);
            this._lblTurKategori2.Name = "_lblTurKategori2";
            this._lblTurKategori2.Size = new System.Drawing.Size(0, 13);
            this._lblTurKategori2.TabIndex = 25;
            // 
            // _dtGridUrunler
            // 
            this._dtGridUrunler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dtGridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._dtGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dtGridUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._dtGridUrunler.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this._dtGridUrunler.Location = new System.Drawing.Point(0, 242);
            this._dtGridUrunler.Name = "_dtGridUrunler";
            this._dtGridUrunler.ReadOnly = true;
            this._dtGridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dtGridUrunler.Size = new System.Drawing.Size(1160, 274);
            this._dtGridUrunler.TabIndex = 47;
            this._dtGridUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dtGridUrunler_CellClick_1);
            // 
            // _cmbDesen
            // 
            this._cmbDesen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._cmbDesen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbDesen.FormattingEnabled = true;
            this._cmbDesen.Location = new System.Drawing.Point(97, 47);
            this._cmbDesen.Name = "_cmbDesen";
            this._cmbDesen.Size = new System.Drawing.Size(164, 21);
            this._cmbDesen.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Türler:";
            // 
            // _lblTurKategori3
            // 
            this._lblTurKategori3.AutoSize = true;
            this._lblTurKategori3.Location = new System.Drawing.Point(271, 147);
            this._lblTurKategori3.Name = "_lblTurKategori3";
            this._lblTurKategori3.Size = new System.Drawing.Size(0, 13);
            this._lblTurKategori3.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Oranlar:";
            // 
            // _cmbTur1
            // 
            this._cmbTur1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._cmbTur1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbTur1.FormattingEnabled = true;
            this._cmbTur1.Location = new System.Drawing.Point(38, 90);
            this._cmbTur1.Name = "_cmbTur1";
            this._cmbTur1.Size = new System.Drawing.Size(121, 21);
            this._cmbTur1.TabIndex = 18;
            this._cmbTur1.SelectedIndexChanged += new System.EventHandler(this._cmbTur1_SelectedIndexChanged);
            // 
            // _cmbTur3
            // 
            this._cmbTur3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._cmbTur3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbTur3.Enabled = false;
            this._cmbTur3.FormattingEnabled = true;
            this._cmbTur3.Location = new System.Drawing.Point(38, 144);
            this._cmbTur3.Name = "_cmbTur3";
            this._cmbTur3.Size = new System.Drawing.Size(121, 21);
            this._cmbTur3.TabIndex = 19;
            this._cmbTur3.SelectedIndexChanged += new System.EventHandler(this._cmbTur3_SelectedIndexChanged);
            // 
            // _cmbTur2
            // 
            this._cmbTur2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._cmbTur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbTur2.Enabled = false;
            this._cmbTur2.FormattingEnabled = true;
            this._cmbTur2.Location = new System.Drawing.Point(38, 117);
            this._cmbTur2.Name = "_cmbTur2";
            this._cmbTur2.Size = new System.Drawing.Size(121, 21);
            this._cmbTur2.TabIndex = 20;
            this._cmbTur2.SelectedIndexChanged += new System.EventHandler(this._cmbTur2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this._txtRenk);
            this.groupBox3.Controls.Add(this._nmrOran3);
            this.groupBox3.Controls.Add(this._nmrOran2);
            this.groupBox3.Controls.Add(this._nmrOran1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this._cmbDesen);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this._lblTurKategori3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this._lblTurKategori2);
            this.groupBox3.Controls.Add(this._cmbTur1);
            this.groupBox3.Controls.Add(this._lblTurKategori1);
            this.groupBox3.Controls.Add(this._cmbTur3);
            this.groupBox3.Controls.Add(this._cmbTur2);
            this.groupBox3.Location = new System.Drawing.Point(552, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 196);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çeşit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Renk:";
            // 
            // _txtRenk
            // 
            this._txtRenk.Location = new System.Drawing.Point(97, 21);
            this._txtRenk.Name = "_txtRenk";
            this._txtRenk.Size = new System.Drawing.Size(164, 20);
            this._txtRenk.TabIndex = 15;
            this._txtRenk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtRenk_KeyPress);
            // 
            // _nmrOran3
            // 
            this._nmrOran3.Enabled = false;
            this._nmrOran3.Location = new System.Drawing.Point(186, 143);
            this._nmrOran3.Name = "_nmrOran3";
            this._nmrOran3.Size = new System.Drawing.Size(75, 20);
            this._nmrOran3.TabIndex = 29;
            // 
            // _nmrOran2
            // 
            this._nmrOran2.Enabled = false;
            this._nmrOran2.Location = new System.Drawing.Point(186, 116);
            this._nmrOran2.Name = "_nmrOran2";
            this._nmrOran2.Size = new System.Drawing.Size(75, 20);
            this._nmrOran2.TabIndex = 28;
            // 
            // _nmrOran1
            // 
            this._nmrOran1.Enabled = false;
            this._nmrOran1.Location = new System.Drawing.Point(186, 90);
            this._nmrOran1.Name = "_nmrOran1";
            this._nmrOran1.Size = new System.Drawing.Size(75, 20);
            this._nmrOran1.TabIndex = 27;
            // 
            // _lblTurKategori1
            // 
            this._lblTurKategori1.AutoSize = true;
            this._lblTurKategori1.Location = new System.Drawing.Point(271, 93);
            this._lblTurKategori1.Name = "_lblTurKategori1";
            this._lblTurKategori1.Size = new System.Drawing.Size(0, 13);
            this._lblTurKategori1.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._chkMakine);
            this.groupBox2.Controls.Add(this._chkKuruTemizleme);
            this.groupBox2.Controls.Add(this._txtCekmePayi);
            this.groupBox2.Controls.Add(this._chkKurutma);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this._chkCamasirSuyu);
            this.groupBox2.Controls.Add(this._txtDerece);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(294, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yıkama Bilgileri:";
            // 
            // _chkMakine
            // 
            this._chkMakine.AutoSize = true;
            this._chkMakine.Location = new System.Drawing.Point(37, 33);
            this._chkMakine.Name = "_chkMakine";
            this._chkMakine.Size = new System.Drawing.Size(124, 17);
            this._chkMakine.TabIndex = 28;
            this._chkMakine.Text = "Makinede Yıkanabilir";
            this._chkMakine.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._txtUrunIsmi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._txtUrunFiyati);
            this.groupBox1.Controls.Add(this._txtUzunluk);
            this.groupBox1.Controls.Add(this._txtGenislik);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._txtAgirlik);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this._nmrAdet);
            this.groupBox1.Location = new System.Drawing.Point(50, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kumaş:";
            // 
            // _txtUrunIsmi
            // 
            this._txtUrunIsmi.Location = new System.Drawing.Point(81, 21);
            this._txtUrunIsmi.Name = "_txtUrunIsmi";
            this._txtUrunIsmi.Size = new System.Drawing.Size(134, 20);
            this._txtUrunIsmi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Uzunluk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genişlik:";
            // 
            // _txtUrunFiyati
            // 
            this._txtUrunFiyati.Location = new System.Drawing.Point(81, 47);
            this._txtUrunFiyati.Name = "_txtUrunFiyati";
            this._txtUrunFiyati.Size = new System.Drawing.Size(134, 20);
            this._txtUrunFiyati.TabIndex = 7;
            this._txtUrunFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtUrunFiyati_KeyPress);
            // 
            // _txtUzunluk
            // 
            this._txtUzunluk.Location = new System.Drawing.Point(81, 75);
            this._txtUzunluk.Name = "_txtUzunluk";
            this._txtUzunluk.Size = new System.Drawing.Size(134, 20);
            this._txtUzunluk.TabIndex = 8;
            this._txtUzunluk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtUrunFiyati_KeyPress);
            // 
            // _txtGenislik
            // 
            this._txtGenislik.Location = new System.Drawing.Point(81, 101);
            this._txtGenislik.Name = "_txtGenislik";
            this._txtGenislik.Size = new System.Drawing.Size(134, 20);
            this._txtGenislik.TabIndex = 9;
            this._txtGenislik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtUrunFiyati_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ağırlık:";
            // 
            // _txtAgirlik
            // 
            this._txtAgirlik.Location = new System.Drawing.Point(81, 127);
            this._txtAgirlik.Name = "_txtAgirlik";
            this._txtAgirlik.Size = new System.Drawing.Size(134, 20);
            this._txtAgirlik.TabIndex = 11;
            this._txtAgirlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtUrunFiyati_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adet:";
            // 
            // _nmrAdet
            // 
            this._nmrAdet.Location = new System.Drawing.Point(81, 153);
            this._nmrAdet.Name = "_nmrAdet";
            this._nmrAdet.Size = new System.Drawing.Size(134, 20);
            this._nmrAdet.TabIndex = 13;
            // 
            // _imgListDesen
            // 
            this._imgListDesen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgListDesen.ImageStream")));
            this._imgListDesen.TransparentColor = System.Drawing.Color.Transparent;
            this._imgListDesen.Images.SetKeyName(0, "18-sal-deseni.jpg");
            this._imgListDesen.Images.SetKeyName(1, "21-pop-art-desenler.jpg");
            this._imgListDesen.Images.SetKeyName(2, "all-over-print.jpg");
            this._imgListDesen.Images.SetKeyName(3, "baklava-dsn.jpg");
            this._imgListDesen.Images.SetKeyName(4, "baliksirti-zigzag.jpg");
            this._imgListDesen.Images.SetKeyName(5, "batik-dsni.jpg");
            this._imgListDesen.Images.SetKeyName(6, "cicekdesen.jpg");
            this._imgListDesen.Images.SetKeyName(7, "cizgili-dsn.jpg");
            this._imgListDesen.Images.SetKeyName(8, "digitaldesen.jpg");
            this._imgListDesen.Images.SetKeyName(9, "duz.jpg");
            this._imgListDesen.Images.SetKeyName(10, "etnikdesen.jpg");
            this._imgListDesen.Images.SetKeyName(11, "geometrik-desen.jpg");
            this._imgListDesen.Images.SetKeyName(12, "grafik-deseni.jpg");
            this._imgListDesen.Images.SetKeyName(13, "kamuflaj-desen.jpg");
            this._imgListDesen.Images.SetKeyName(14, "kazayagi-deseni.jpg");
            this._imgListDesen.Images.SetKeyName(15, "kilim-deseni.jpg");
            this._imgListDesen.Images.SetKeyName(16, "kolaj-deseni.jpg");
            this._imgListDesen.Images.SetKeyName(17, "leopar.jpg");
            this._imgListDesen.Images.SetKeyName(18, "oxford-desen.jpg");
            this._imgListDesen.Images.SetKeyName(19, "puantiyeli-desen.jpg");
            this._imgListDesen.Images.SetKeyName(20, "soyut-desen.jpg");
            this._imgListDesen.Images.SetKeyName(21, "tribal-kabile.jpg");
            this._imgListDesen.Images.SetKeyName(22, "yilan.jpg");
            this._imgListDesen.Images.SetKeyName(23, "zebra.jpg");
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(50, 0, 50, 10);
            this.groupBox5.Size = new System.Drawing.Size(1160, 219);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this._btnKaydet);
            this.groupBox6.Controls.Add(this._btnGuncelle);
            this.groupBox6.Controls.Add(this._btnSil);
            this.groupBox6.Controls.Add(this._btnTemizle);
            this.groupBox6.Location = new System.Drawing.Point(942, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(165, 196);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // _btnKaydet
            // 
            this._btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKaydet.ImageIndex = 1;
            this._btnKaydet.ImageList = this._imgListButon;
            this._btnKaydet.Location = new System.Drawing.Point(14, 12);
            this._btnKaydet.Name = "_btnKaydet";
            this._btnKaydet.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._btnKaydet.Size = new System.Drawing.Size(134, 40);
            this._btnKaydet.TabIndex = 45;
            this._btnKaydet.Text = "Kaydet";
            this._btnKaydet.UseVisualStyleBackColor = true;
            this._btnKaydet.Click += new System.EventHandler(this._btnKaydet_Click);
            // 
            // _btnGuncelle
            // 
            this._btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnGuncelle.ImageIndex = 2;
            this._btnGuncelle.ImageList = this._imgListButon;
            this._btnGuncelle.Location = new System.Drawing.Point(14, 58);
            this._btnGuncelle.Name = "_btnGuncelle";
            this._btnGuncelle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._btnGuncelle.Size = new System.Drawing.Size(134, 40);
            this._btnGuncelle.TabIndex = 46;
            this._btnGuncelle.Text = "Güncelle";
            this._btnGuncelle.UseVisualStyleBackColor = true;
            this._btnGuncelle.Click += new System.EventHandler(this._btnGuncelle_Click);
            // 
            // _btnSil
            // 
            this._btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSil.ImageIndex = 5;
            this._btnSil.ImageList = this._imgListButon;
            this._btnSil.Location = new System.Drawing.Point(14, 104);
            this._btnSil.Name = "_btnSil";
            this._btnSil.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._btnSil.Size = new System.Drawing.Size(134, 40);
            this._btnSil.TabIndex = 44;
            this._btnSil.Text = "Sil";
            this._btnSil.UseVisualStyleBackColor = true;
            this._btnSil.Click += new System.EventHandler(this._btnSil_Click);
            // 
            // _btnTemizle
            // 
            this._btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnTemizle.ImageIndex = 0;
            this._btnTemizle.ImageList = this._imgListButon;
            this._btnTemizle.Location = new System.Drawing.Point(14, 150);
            this._btnTemizle.Name = "_btnTemizle";
            this._btnTemizle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._btnTemizle.Size = new System.Drawing.Size(134, 40);
            this._btnTemizle.TabIndex = 48;
            this._btnTemizle.Text = "Temizle";
            this._btnTemizle.UseVisualStyleBackColor = true;
            this._btnTemizle.Click += new System.EventHandler(this._btnTemizle_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 23);
            this.panel1.TabIndex = 51;
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1160, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._dtGridUrunler);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UrunEkle_FormClosing);
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtGridUrunler)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nmrOran3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmrOran2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmrOran1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nmrAdet)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox _chkKuruTemizleme;
        private System.Windows.Forms.TextBox _txtCekmePayi;
        private System.Windows.Forms.CheckBox _chkKurutma;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox _chkCamasirSuyu;
        private System.Windows.Forms.TextBox _txtDerece;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label _lblTurKategori2;
        private System.Windows.Forms.DataGridView _dtGridUrunler;
        private System.Windows.Forms.ComboBox _cmbDesen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label _lblTurKategori3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox _cmbTur1;
        private System.Windows.Forms.ComboBox _cmbTur3;
        private System.Windows.Forms.ComboBox _cmbTur2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label _lblTurKategori1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox _chkMakine;
        private System.Windows.Forms.TextBox _txtRenk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtUrunIsmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtUrunFiyati;
        private System.Windows.Forms.TextBox _txtUzunluk;
        private System.Windows.Forms.TextBox _txtGenislik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtAgirlik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown _nmrAdet;
        private System.Windows.Forms.NumericUpDown _nmrOran3;
        private System.Windows.Forms.NumericUpDown _nmrOran2;
        private System.Windows.Forms.NumericUpDown _nmrOran1;
        private System.Windows.Forms.ImageList _imgListDesen;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ImageList _imgListButon;
        private System.Windows.Forms.Button _btnKaydet;
        private System.Windows.Forms.Button _btnGuncelle;
        private System.Windows.Forms.Button _btnSil;
        private System.Windows.Forms.Button _btnTemizle;
        private System.Windows.Forms.Panel panel1;
    }
}