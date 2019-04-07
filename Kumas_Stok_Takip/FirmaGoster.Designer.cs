namespace Kumas_Stok_Takip
{
    partial class FirmaGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaGoster));
            this._dtGridFirmaGoster = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnFirmaEkle = new System.Windows.Forms.Button();
            this._imgListButon = new System.Windows.Forms.ImageList(this.components);
            this._btnFirmaGuncelle = new System.Windows.Forms.Button();
            this._btnFirmaSil = new System.Windows.Forms.Button();
            this._btnFirmaTemizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lblKarakterSayac = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._txtAdres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtFax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtSabitHat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtGSM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtYetkili = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtVergiNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._txtUnvan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._dtGridFirmaGoster)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _dtGridFirmaGoster
            // 
            this._dtGridFirmaGoster.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dtGridFirmaGoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._dtGridFirmaGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dtGridFirmaGoster.Dock = System.Windows.Forms.DockStyle.Top;
            this._dtGridFirmaGoster.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this._dtGridFirmaGoster.Location = new System.Drawing.Point(0, 229);
            this._dtGridFirmaGoster.Name = "_dtGridFirmaGoster";
            this._dtGridFirmaGoster.ReadOnly = true;
            this._dtGridFirmaGoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dtGridFirmaGoster.Size = new System.Drawing.Size(908, 261);
            this._dtGridFirmaGoster.TabIndex = 0;
            this._dtGridFirmaGoster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dtGridFirmaGoster_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Size = new System.Drawing.Size(908, 206);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnFirmaEkle);
            this.groupBox2.Controls.Add(this._btnFirmaGuncelle);
            this.groupBox2.Controls.Add(this._btnFirmaSil);
            this.groupBox2.Controls.Add(this._btnFirmaTemizle);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(729, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 196);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // _btnFirmaEkle
            // 
            this._btnFirmaEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFirmaEkle.ImageIndex = 1;
            this._btnFirmaEkle.ImageList = this._imgListButon;
            this._btnFirmaEkle.Location = new System.Drawing.Point(23, 11);
            this._btnFirmaEkle.Name = "_btnFirmaEkle";
            this._btnFirmaEkle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._btnFirmaEkle.Size = new System.Drawing.Size(134, 40);
            this._btnFirmaEkle.TabIndex = 50;
            this._btnFirmaEkle.Text = "Kaydet";
            this._btnFirmaEkle.UseVisualStyleBackColor = true;
            this._btnFirmaEkle.Click += new System.EventHandler(this._btnFirmaEkle_Click);
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
            // _btnFirmaGuncelle
            // 
            this._btnFirmaGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFirmaGuncelle.ImageIndex = 2;
            this._btnFirmaGuncelle.ImageList = this._imgListButon;
            this._btnFirmaGuncelle.Location = new System.Drawing.Point(23, 57);
            this._btnFirmaGuncelle.Name = "_btnFirmaGuncelle";
            this._btnFirmaGuncelle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._btnFirmaGuncelle.Size = new System.Drawing.Size(134, 40);
            this._btnFirmaGuncelle.TabIndex = 51;
            this._btnFirmaGuncelle.Text = "Güncelle";
            this._btnFirmaGuncelle.UseVisualStyleBackColor = true;
            this._btnFirmaGuncelle.Click += new System.EventHandler(this._btnFirmaGuncelle_Click);
            // 
            // _btnFirmaSil
            // 
            this._btnFirmaSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFirmaSil.ImageIndex = 5;
            this._btnFirmaSil.ImageList = this._imgListButon;
            this._btnFirmaSil.Location = new System.Drawing.Point(23, 103);
            this._btnFirmaSil.Name = "_btnFirmaSil";
            this._btnFirmaSil.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._btnFirmaSil.Size = new System.Drawing.Size(134, 40);
            this._btnFirmaSil.TabIndex = 49;
            this._btnFirmaSil.Text = "Sil";
            this._btnFirmaSil.UseVisualStyleBackColor = true;
            this._btnFirmaSil.Click += new System.EventHandler(this._btnFirmaSil_Click);
            // 
            // _btnFirmaTemizle
            // 
            this._btnFirmaTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFirmaTemizle.ImageIndex = 0;
            this._btnFirmaTemizle.ImageList = this._imgListButon;
            this._btnFirmaTemizle.Location = new System.Drawing.Point(23, 149);
            this._btnFirmaTemizle.Name = "_btnFirmaTemizle";
            this._btnFirmaTemizle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._btnFirmaTemizle.Size = new System.Drawing.Size(134, 40);
            this._btnFirmaTemizle.TabIndex = 52;
            this._btnFirmaTemizle.Text = "Temizle";
            this._btnFirmaTemizle.UseVisualStyleBackColor = true;
            this._btnFirmaTemizle.Click += new System.EventHandler(this._btnFirmaTemizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._lblKarakterSayac);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this._txtAdres);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this._txtMail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._txtFax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._txtSabitHat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._txtGSM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._txtYetkili);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtVergiNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._txtUnvan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // _lblKarakterSayac
            // 
            this._lblKarakterSayac.AutoSize = true;
            this._lblKarakterSayac.Location = new System.Drawing.Point(438, 160);
            this._lblKarakterSayac.Name = "_lblKarakterSayac";
            this._lblKarakterSayac.Size = new System.Drawing.Size(35, 13);
            this._lblKarakterSayac.TabIndex = 53;
            this._lblKarakterSayac.Text = "label9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // _txtAdres
            // 
            this._txtAdres.Location = new System.Drawing.Point(479, 92);
            this._txtAdres.MaxLength = 50;
            this._txtAdres.Multiline = true;
            this._txtAdres.Name = "_txtAdres";
            this._txtAdres.Size = new System.Drawing.Size(224, 88);
            this._txtAdres.TabIndex = 51;
            this._txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtAdres_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Adres:";
            // 
            // _txtMail
            // 
            this._txtMail.Location = new System.Drawing.Point(479, 55);
            this._txtMail.Name = "_txtMail";
            this._txtMail.Size = new System.Drawing.Size(224, 20);
            this._txtMail.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Mail:";
            // 
            // _txtFax
            // 
            this._txtFax.Location = new System.Drawing.Point(479, 22);
            this._txtFax.Name = "_txtFax";
            this._txtFax.Size = new System.Drawing.Size(224, 20);
            this._txtFax.TabIndex = 47;
            this._txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._sayi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Fax:";
            // 
            // _txtSabitHat
            // 
            this._txtSabitHat.Location = new System.Drawing.Point(177, 160);
            this._txtSabitHat.Name = "_txtSabitHat";
            this._txtSabitHat.Size = new System.Drawing.Size(224, 20);
            this._txtSabitHat.TabIndex = 45;
            this._txtSabitHat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._sayi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Sabit Hat:";
            // 
            // _txtGSM
            // 
            this._txtGSM.Location = new System.Drawing.Point(177, 124);
            this._txtGSM.Name = "_txtGSM";
            this._txtGSM.Size = new System.Drawing.Size(224, 20);
            this._txtGSM.TabIndex = 43;
            this._txtGSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._sayi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "GSM:";
            // 
            // _txtYetkili
            // 
            this._txtYetkili.Location = new System.Drawing.Point(177, 89);
            this._txtYetkili.Name = "_txtYetkili";
            this._txtYetkili.Size = new System.Drawing.Size(224, 20);
            this._txtYetkili.TabIndex = 41;
            this._txtYetkili.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._harf_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Yetkili:";
            // 
            // _txtVergiNo
            // 
            this._txtVergiNo.Location = new System.Drawing.Point(177, 22);
            this._txtVergiNo.Name = "_txtVergiNo";
            this._txtVergiNo.Size = new System.Drawing.Size(224, 20);
            this._txtVergiNo.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Vegi No:";
            // 
            // _txtUnvan
            // 
            this._txtUnvan.Location = new System.Drawing.Point(177, 55);
            this._txtUnvan.Name = "_txtUnvan";
            this._txtUnvan.Size = new System.Drawing.Size(224, 20);
            this._txtUnvan.TabIndex = 38;
            this._txtUnvan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._harf_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ünvan:";
            // 
            // _timer1
            // 
            this._timer1.Enabled = true;
            this._timer1.Interval = 1000;
            this._timer1.Tick += new System.EventHandler(this._timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 23);
            this.panel2.TabIndex = 5;
            // 
            // FirmaGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(908, 490);
            this.Controls.Add(this._dtGridFirmaGoster);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FirmaGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirmaGoster_FormClosing);
            this.Load += new System.EventHandler(this.FirmaGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtGridFirmaGoster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dtGridFirmaGoster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtVergiNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtUnvan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtSabitHat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtGSM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtYetkili;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtFax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList _imgListButon;
        private System.Windows.Forms.Button _btnFirmaEkle;
        private System.Windows.Forms.Button _btnFirmaGuncelle;
        private System.Windows.Forms.Button _btnFirmaSil;
        private System.Windows.Forms.Button _btnFirmaTemizle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _lblKarakterSayac;
        private System.Windows.Forms.Timer _timer1;
        private System.Windows.Forms.Panel panel2;
    }
}