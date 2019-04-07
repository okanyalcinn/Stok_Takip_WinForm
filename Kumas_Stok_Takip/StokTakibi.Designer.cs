namespace Kumas_Stok_Takip
{
    partial class StokTakibi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokTakibi));
            this._dtGridStok = new System.Windows.Forms.DataGridView();
            this._btnBilgiGuncelle = new System.Windows.Forms.Button();
            this._imgListButon = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this._txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._txtUrunAra = new System.Windows.Forms.TextBox();
            this._btnAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dtGridStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmrAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _dtGridStok
            // 
            this._dtGridStok.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dtGridStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._dtGridStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dtGridStok.Dock = System.Windows.Forms.DockStyle.Top;
            this._dtGridStok.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this._dtGridStok.Location = new System.Drawing.Point(0, 0);
            this._dtGridStok.Name = "_dtGridStok";
            this._dtGridStok.ReadOnly = true;
            this._dtGridStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dtGridStok.Size = new System.Drawing.Size(748, 325);
            this._dtGridStok.TabIndex = 0;
            this._dtGridStok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dtGridStok_CellClick);
            this._dtGridStok.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this._dtGridStok_CellFormatting);
            // 
            // _btnBilgiGuncelle
            // 
            this._btnBilgiGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnBilgiGuncelle.ImageIndex = 2;
            this._btnBilgiGuncelle.ImageList = this._imgListButon;
            this._btnBilgiGuncelle.Location = new System.Drawing.Point(575, 335);
            this._btnBilgiGuncelle.Name = "_btnBilgiGuncelle";
            this._btnBilgiGuncelle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._btnBilgiGuncelle.Size = new System.Drawing.Size(161, 57);
            this._btnBilgiGuncelle.TabIndex = 1;
            this._btnBilgiGuncelle.Text = "Stoğu Güncelle";
            this._btnBilgiGuncelle.UseVisualStyleBackColor = true;
            this._btnBilgiGuncelle.Click += new System.EventHandler(this._btnBilgiGuncelle_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı:";
            // 
            // _txtUrunAdi
            // 
            this._txtUrunAdi.Location = new System.Drawing.Point(449, 338);
            this._txtUrunAdi.Name = "_txtUrunAdi";
            this._txtUrunAdi.ReadOnly = true;
            this._txtUrunAdi.Size = new System.Drawing.Size(120, 20);
            this._txtUrunAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adet:";
            // 
            // _nmrAdet
            // 
            this._nmrAdet.Location = new System.Drawing.Point(449, 368);
            this._nmrAdet.Name = "_nmrAdet";
            this._nmrAdet.Size = new System.Drawing.Size(120, 20);
            this._nmrAdet.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // _txtUrunAra
            // 
            this._txtUrunAra.Location = new System.Drawing.Point(132, 360);
            this._txtUrunAra.Name = "_txtUrunAra";
            this._txtUrunAra.Size = new System.Drawing.Size(164, 20);
            this._txtUrunAra.TabIndex = 7;
            this._txtUrunAra.TextChanged += new System.EventHandler(this._txtUrunAra_TextChanged);
            // 
            // _btnAra
            // 
            this._btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnAra.ImageIndex = 3;
            this._btnAra.ImageList = this._imgListButon;
            this._btnAra.Location = new System.Drawing.Point(300, 338);
            this._btnAra.Name = "_btnAra";
            this._btnAra.Size = new System.Drawing.Size(75, 54);
            this._btnAra.TabIndex = 8;
            this._btnAra.Text = "Ara";
            this._btnAra.UseVisualStyleBackColor = true;
            this._btnAra.Click += new System.EventHandler(this._btnAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Adı:";
            // 
            // StokTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 404);
            this.Controls.Add(this._btnAra);
            this.Controls.Add(this._txtUrunAra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._nmrAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtUrunAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnBilgiGuncelle);
            this.Controls.Add(this._dtGridStok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StokTakibi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokTakibi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StokTakibi_FormClosing);
            this.Load += new System.EventHandler(this.StokTakibi_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtGridStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmrAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dtGridStok;
        private System.Windows.Forms.Button _btnBilgiGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _nmrAdet;
        private System.Windows.Forms.ImageList _imgListButon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox _txtUrunAra;
        private System.Windows.Forms.Button _btnAra;
        private System.Windows.Forms.Label label3;
    }
}