namespace Kumas_Stok_Takip
{
    partial class Faturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faturalar));
            this._dtGridFaturalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._dtGridFaturalar)).BeginInit();
            this.SuspendLayout();
            // 
            // _dtGridFaturalar
            // 
            this._dtGridFaturalar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dtGridFaturalar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._dtGridFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dtGridFaturalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dtGridFaturalar.Location = new System.Drawing.Point(0, 0);
            this._dtGridFaturalar.Name = "_dtGridFaturalar";
            this._dtGridFaturalar.ReadOnly = true;
            this._dtGridFaturalar.Size = new System.Drawing.Size(494, 402);
            this._dtGridFaturalar.TabIndex = 0;
            // 
            // Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(494, 402);
            this.Controls.Add(this._dtGridFaturalar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Faturalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturalar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Faturalar_FormClosed);
            this.Load += new System.EventHandler(this.Faturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtGridFaturalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dtGridFaturalar;
    }
}