namespace Kumas_Stok_Takip
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this._chckBeniHatirla = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtSifre = new System.Windows.Forms.TextBox();
            this._txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this._btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._imgListButon = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _chckBeniHatirla
            // 
            this._chckBeniHatirla.AutoSize = true;
            this._chckBeniHatirla.Location = new System.Drawing.Point(190, 83);
            this._chckBeniHatirla.Name = "_chckBeniHatirla";
            this._chckBeniHatirla.Size = new System.Drawing.Size(78, 17);
            this._chckBeniHatirla.TabIndex = 8;
            this._chckBeniHatirla.Text = "Beni hatırla";
            this._chckBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // _txtSifre
            // 
            this._txtSifre.Location = new System.Drawing.Point(190, 49);
            this._txtSifre.Name = "_txtSifre";
            this._txtSifre.PasswordChar = '*';
            this._txtSifre.Size = new System.Drawing.Size(100, 20);
            this._txtSifre.TabIndex = 7;
            this._txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtSifre_KeyPress);
            // 
            // _txtKullaniciAdi
            // 
            this._txtKullaniciAdi.Location = new System.Drawing.Point(190, 13);
            this._txtKullaniciAdi.Name = "_txtKullaniciAdi";
            this._txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this._txtKullaniciAdi.TabIndex = 5;
            // 
            // _btnGiris
            // 
            this._btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnGiris.ImageIndex = 7;
            this._btnGiris.ImageList = this._imgListButon;
            this._btnGiris.Location = new System.Drawing.Point(190, 115);
            this._btnGiris.Name = "_btnGiris";
            this._btnGiris.Size = new System.Drawing.Size(100, 39);
            this._btnGiris.TabIndex = 10;
            this._btnGiris.Text = "Giriş";
            this._btnGiris.UseVisualStyleBackColor = true;
            this._btnGiris.Click += new System.EventHandler(this._btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            this._imgListButon.Images.SetKeyName(7, "key.png");
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 168);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._chckBeniHatirla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtSifre);
            this.Controls.Add(this._txtKullaniciAdi);
            this.Controls.Add(this._btnGiris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _chckBeniHatirla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtSifre;
        private System.Windows.Forms.TextBox _txtKullaniciAdi;
        private System.Windows.Forms.Button _btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList _imgListButon;
    }
}

