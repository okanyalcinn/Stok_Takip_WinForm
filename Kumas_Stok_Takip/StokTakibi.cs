using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kumas_Stok_Takip
{
    public partial class StokTakibi : Form
    {
        public StokTakibi()
        {
            InitializeComponent();
        }
        KumasStokDBEntities db;
        int secilenID = -1;
        private void StokListele()
        {
            db = new KumasStokDBEntities();
            var liste = db.Urunler.Select(x => new
            {
                UrunID = x.ID,
                UrunAd = x.ad,
                UrunFiyat = x.fiyat,
                UrunMetre = x.metre,
                UrunGenislik = x.genislik,
                UrunAgirlik = x.agirlik,
                UrunRenk = x.renk,
                UrunAdet = x.adet,

            }).ToList();
            _dtGridStok.DataSource = liste;
            _dtGridStok.Columns[0].Visible = false;

        }
        private void StokTakibi_Load(object sender, EventArgs e)
        {
            StokListele();
        }

        private void _dtGridStok_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < _dtGridStok.RowCount; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToInt32(_dtGridStok.Rows[i].Cells["UrunAdet"].Value) <= 50)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }

                else
                {
                    renk.BackColor = Color.Green;
                }
                _dtGridStok.Rows[i].DefaultCellStyle = renk;

            }


        }


        private void _dtGridStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new KumasStokDBEntities();
            try
            {
                secilenID = Convert.ToInt32(_dtGridStok.CurrentRow.Cells[0].Value);

                _txtUrunAdi.Text = _dtGridStok.CurrentRow.Cells[1].Value.ToString();
                _nmrAdet.Value = Convert.ToDecimal(_dtGridStok.CurrentRow.Cells[7].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }

        }

        private void _btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            db = new KumasStokDBEntities();

            try
            {
                if (secilenID != -1)
                {
                    Urun urun = db.Urunler.Find(secilenID);

                    urun.ad = _txtUrunAdi.Text;
                    urun.adet = (int)_nmrAdet.Value;
               
                db.SaveChanges();
                StokListele();
                MessageBox.Show("Ürün stok bilgisi güncellendi");
                }
                else
                {
                MessageBox.Show("Bir ürün seçiniz!");
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }
        }

        private void StokTakibi_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }

        private void _btnAra_Click(object sender, EventArgs e)
        {
            db = new KumasStokDBEntities();
            var liste = db.Urunler.Select(x => new
            {
                UrunID = x.ID,
                UrunAd = x.ad,
                UrunFiyat = x.fiyat,
                UrunMetre = x.metre,
                UrunGenislik = x.genislik,
                UrunAgirlik = x.agirlik,
                UrunRenk = x.renk,
                UrunAdet = x.adet,

            }).Where(x => x.UrunAd.Contains(_txtUrunAra.Text)).ToList(); 
            _dtGridStok.DataSource = liste;
            _dtGridStok.Columns[0].Visible = false;
            if (_dtGridStok.Rows.Count == 0)
            {
                MessageBox.Show("Aradığınız Ürün Kaydı Bulunamadı");
                StokListele();
            }
        }

        private void _txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (_txtUrunAra.Text == "")
            {
                StokListele();
            }
           
        }
    }
}
