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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        int secilenID = -1;
        KumasStokDBEntities db;
        private void UrunEkle_Load(object sender, EventArgs e)
        {
            db = new KumasStokDBEntities();
            UrunListele();
            DesenListele();
            TurListele();
        }
        private void UrunListele()
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
                UrunMakine = x.YikamaBilgileri.makine,
                UrunKuruTemizleme = x.YikamaBilgileri.kuruTemizleme,
                UrunKurutucu = x.YikamaBilgileri.kurutucu,
                UrunCamasirSuyu = x.YikamaBilgileri.camasirSuyu,
                UrunDerece = x.YikamaBilgileri.derece,
                UrunCekmaPayi = x.YikamaBilgileri.cekmePayi,
                UrunDesen = x.Ozellikler.Desenler.ad,
                UrunTur1 = x.Ozellikler.Turler.ad,
                UrunOran1 = x.Ozellikler.oran1,
                UrunTur2 = x.Ozellikler.Turler1.ad,
                UrunOran2 = x.Ozellikler.oran2,
                UrunTur3 = x.Ozellikler.Turler2.ad,
                UrunOran3 = x.Ozellikler.oran3
            }).ToList();
            _dtGridUrunler.DataSource = liste;
            _dtGridUrunler.Columns[0].Visible = false;
            _dtGridUrunler.Columns[1].HeaderText = "Kumaş Adı";
            _dtGridUrunler.Columns[1].Width = 120;
            _dtGridUrunler.Columns[2].HeaderText = "Fiyat";
            _dtGridUrunler.Columns[2].Width = 50;
            _dtGridUrunler.Columns[3].HeaderText = "Uzunluk";
            _dtGridUrunler.Columns[3].Width = 50;
            _dtGridUrunler.Columns[4].HeaderText = "Genişlik";
            _dtGridUrunler.Columns[4].Width = 50;
            _dtGridUrunler.Columns[5].HeaderText = "Ağırlık";
            _dtGridUrunler.Columns[5].Width = 40;
            _dtGridUrunler.Columns[6].HeaderText = "Renk";
            _dtGridUrunler.Columns[6].Width = 50;
            _dtGridUrunler.Columns[7].HeaderText = "Adet";
            _dtGridUrunler.Columns[7].Width = 40;
            _dtGridUrunler.Columns[8].HeaderText = "Çamaşır Makinesinde";
            _dtGridUrunler.Columns[8].Width = 80;
            _dtGridUrunler.Columns[9].HeaderText = "Kuru Temizlemede";
            _dtGridUrunler.Columns[9].Width = 70;
            _dtGridUrunler.Columns[10].HeaderText = "Kurutma makinesinde";
            _dtGridUrunler.Columns[10].Width = 70;
            _dtGridUrunler.Columns[11].HeaderText = "Çamaşır Suyu Kullanımı";
            _dtGridUrunler.Columns[11].Width = 80;
            _dtGridUrunler.Columns[12].HeaderText = "Yıkama Derecesi";
            _dtGridUrunler.Columns[12].Width = 55;
            _dtGridUrunler.Columns[13].HeaderText = "Çekme Payı";
            _dtGridUrunler.Columns[13].Width = 50;
            _dtGridUrunler.Columns[14].HeaderText = "Desen";
            _dtGridUrunler.Columns[14].Width = 50;
            _dtGridUrunler.Columns[15].HeaderText = "Kumaş Türü1";
            _dtGridUrunler.Columns[15].Width = 45;
            _dtGridUrunler.Columns[16].HeaderText = "Oranı";
            _dtGridUrunler.Columns[16].Width = 40;
            _dtGridUrunler.Columns[17].HeaderText = "Kumaş Türü2";
            _dtGridUrunler.Columns[17].Width = 45;
            _dtGridUrunler.Columns[18].HeaderText = "Oranı";
            _dtGridUrunler.Columns[18].Width = 40;
            _dtGridUrunler.Columns[19].HeaderText = "Kumaş Türü3";
            _dtGridUrunler.Columns[19].Width = 45;
            _dtGridUrunler.Columns[20].HeaderText = "Oranı";
            _dtGridUrunler.Columns[20].Width = 40;
        }

        private void DesenListele()
        {
            db = new KumasStokDBEntities();
            var liste = db.Desenler.Select(x => new
            {
                x.ID,
                x.ad
            }).OrderBy(x => x.ad).ToList();
            _cmbDesen.DisplayMember = "ad";
            _cmbDesen.ValueMember = "ID";
            string[] desenler = new string[24];
            int i =0;
            foreach (var item in liste)
            {
                desenler[i] = item.ad;
                i++;
            }       
            _cmbDesen.DataSource = liste;
        }

        private void TurListele()
        {
            var liste = db.Turler.Select(x => new
            {
                x.ID,
                x.ad
            }).OrderBy(x => x.ad).ToList();
            _cmbTur1.DisplayMember = "ad";
            _cmbTur1.ValueMember = "ID";
            _cmbTur1.DataSource = liste;
        }
        int tur1secim = 0;
        int tur2secim = 0;
        private void _cmbTur1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbTur1.SelectedIndex != 0)
            {
                _nmrOran1.Enabled = true;
                tur1secim = (int)_cmbTur1.SelectedValue;
            }
            var liste = db.Turler.Select(x => new
            {
                x.ID,
                x.ad,
                x.kategoriID
            }).OrderBy(x => x.ad).Where(x => x.ID != tur1secim).ToList();
            _cmbTur2.DisplayMember = "ad";
            _cmbTur2.ValueMember = "ID";
            _cmbTur2.DataSource = liste;

            int kategoriID = 0;
            foreach (Tur item in db.Turler)
            {
                if (item.ID == tur1secim)
                {
                    kategoriID = item.kategoriID;
                    break;
                }
            }
            if (_cmbTur1.SelectedIndex != 0)
            {
                foreach (Kategori item in db.Kategoriler)
                {
                    if (item.ID == kategoriID)
                    {
                        _lblTurKategori1.Text = item.ad;
                        break;
                    }
                }
                _cmbTur2.Enabled = true;
            }
            else
            {
                _lblTurKategori1.Text = "";
                _nmrOran1.Enabled = false;
                _nmrOran1.Value = 0;
            }
        }

        private void _cmbTur2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbTur2.SelectedIndex != 0)
            {
                _nmrOran2.Enabled = true;
                tur2secim = (int)_cmbTur2.SelectedValue;
            }
            var liste = db.Turler.Select(x => new
            {
                x.ID,
                x.ad,
                x.kategoriID
            }).OrderBy(x => x.ad).Where(x => x.ID != tur1secim && x.ID != tur2secim).ToList();
            _cmbTur3.DisplayMember = "ad";
            _cmbTur3.ValueMember = "ID";
            _cmbTur3.DataSource = liste;
            int kategoriID = 0;
            foreach (Tur item in db.Turler)
            {
                if (item.ID == tur2secim)
                {
                    kategoriID = item.kategoriID;
                    break;
                }
            }
            if (_cmbTur2.SelectedIndex != 0)
            {
                foreach (Kategori item in db.Kategoriler)
                {
                    if (item.ID == kategoriID)
                    {
                        _lblTurKategori2.Text = item.ad;
                        break;
                    }
                }
                _cmbTur3.Enabled = true;
            }
            else
            {
                _lblTurKategori2.Text = "";
                _nmrOran2.Enabled = false;
                _nmrOran2.Value = 0;
            }
        }

        private void _cmbTur3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbTur3.SelectedIndex != 0)
                _nmrOran3.Enabled = true;
            int tur3secim = (int)_cmbTur3.SelectedValue;
            int kategoriID = 0;
            foreach (Tur item in db.Turler)
            {
                if (item.ID == tur3secim)
                {
                    kategoriID = item.kategoriID;
                    break;
                }
            }
            foreach (Kategori item in db.Kategoriler)
            {
                if (item.ID == kategoriID)
                {
                    _lblTurKategori3.Text = item.ad;
                    break;
                }
            }
            if (_cmbTur2.SelectedIndex == 0)
            {
                _nmrOran3.Enabled = false;
                _nmrOran3.Value = 0;
            }
        }

        private void _btnKaydet_Click(object sender, EventArgs e)
        {

            db = new KumasStokDBEntities();
            try
            {
                Urun urun = new Urun();
                urun.ad = _txtUrunIsmi.Text;
                urun.fiyat = Convert.ToSingle(_txtUrunFiyati.Text);
                urun.metre = Convert.ToInt32(_txtUzunluk.Text);
                urun.genislik = Convert.ToInt32(_txtGenislik.Text);
                urun.agirlik = Convert.ToSingle(_txtAgirlik.Text);
                urun.renk = _txtRenk.Text;
                urun.adet = (int)_nmrAdet.Value;

                YikamaBilgi yikama = new YikamaBilgi();
                yikama.makine = _chkMakine.Checked;
                yikama.kuruTemizleme = _chkKuruTemizleme.Checked;
                yikama.kurutucu = _chkKurutma.Checked;
                yikama.camasirSuyu = _chkCamasirSuyu.Checked;
                yikama.derece = Convert.ToInt32(_txtDerece.Text);
                yikama.cekmePayi = Convert.ToInt32(_txtCekmePayi.Text);
                db.YikamaBilgileri.Add(yikama);
                urun.yikamaID = yikama.ID;

                Ozellik ozellik = new Ozellik();
                ozellik.desenID = (int)_cmbDesen.SelectedValue;
                ozellik.turID1 = Convert.ToInt32(_cmbTur1.SelectedValue);
                ozellik.turID2 = Convert.ToInt32(_cmbTur2.SelectedValue);
                ozellik.turID3 = Convert.ToInt32(_cmbTur3.SelectedValue);
                ozellik.oran1 = Convert.ToInt32(_nmrOran1.Value);
                ozellik.oran2 = Convert.ToInt32(_nmrOran2.Value);
                ozellik.oran3 = Convert.ToInt32(_nmrOran3.Value);
                db.Ozellikler.Add(ozellik);
                urun.ozellikID = ozellik.ID;

                db.Urunler.Add(urun);
                if ((_nmrOran1.Value + _nmrOran2.Value + _nmrOran3.Value) == 100)
                {
                    db.SaveChanges();
                    MessageBox.Show("Ürün Eklendi");
                    UrunListele();
                }
                else
                {
                    MessageBox.Show("Oranlar tutarlı girilmedi");
                }
            }         
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı" + ex);
            }
        }

        private void _btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                if (secilenID != -1)
                {
                    Urun urun = db.Urunler.Find(secilenID);
                    db.Urunler.Remove(urun);
                    db.SaveChanges();
                    UrunListele();
                    MessageBox.Show("Seçilen ürün silindi");
                }
            }
        }

        private void _btnGuncelle_Click(object sender, EventArgs e)
        {
            db = new KumasStokDBEntities();

            try
            {
                if (secilenID != -1)
                {
                    Urun urun = db.Urunler.Find(secilenID);
                    urun.ad = _txtUrunIsmi.Text;
                    urun.fiyat = Convert.ToSingle(_txtUrunFiyati.Text);
                    urun.metre = Convert.ToInt32(_txtUzunluk.Text);
                    urun.genislik = Convert.ToInt32(_txtGenislik.Text);
                    urun.agirlik = Convert.ToSingle(_txtAgirlik.Text);
                    urun.renk = _txtRenk.Text;
                    urun.adet = (int)_nmrAdet.Value;
                    urun.YikamaBilgileri.makine = _chkMakine.Checked;
                    urun.YikamaBilgileri.kuruTemizleme = _chkKuruTemizleme.Checked;
                    urun.YikamaBilgileri.kurutucu = _chkKurutma.Checked;
                    urun.YikamaBilgileri.camasirSuyu = _chkCamasirSuyu.Checked;
                    urun.YikamaBilgileri.derece = Convert.ToInt32(_txtDerece.Text);
                    urun.YikamaBilgileri.cekmePayi = Convert.ToInt32(_txtCekmePayi.Text);
                    urun.Ozellikler.desenID =(int) _cmbDesen.SelectedValue; 
                    urun.Ozellikler.turID1 = (int)_cmbTur1.SelectedValue;
                    urun.Ozellikler.oran1 = Convert.ToInt32(_nmrOran1.Value);
                    urun.Ozellikler.turID2 = (int)_cmbTur2.SelectedValue;
                    urun.Ozellikler.turID3 = (int)_cmbTur3.SelectedValue;
                    urun.Ozellikler.oran2 = Convert.ToInt32(_nmrOran2.Value);
                    urun.Ozellikler.oran3 = Convert.ToInt32(_nmrOran3.Value);
                    db.SaveChanges();
                    UrunListele();
                    MessageBox.Show("Urun bilgileri güncellendi");
                }
                else
                {
                    MessageBox.Show("Bir ürün seçiniz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void _btnTemizle_Click(object sender, EventArgs e)
        {
            secilenID = -1;
            _txtUrunIsmi.Clear();
            _txtUrunFiyati.Clear();
            _txtUzunluk.Clear();
            _txtGenislik.Clear();
            _txtAgirlik.Clear();
            _txtRenk.Clear();
            _nmrAdet.Value = 0;
            _chkMakine.Checked = false;
            _chkKuruTemizleme.Checked = false;
            _chkKurutma.Checked = false;
            _chkCamasirSuyu.Checked = false;
            _txtDerece.Clear();
            _txtCekmePayi.Clear();
            _cmbDesen.SelectedIndex = 0;
            _cmbTur1.SelectedIndex = 0;
            _nmrOran1.Value = 0;
            _cmbTur2.SelectedIndex = 0;
            _nmrOran2.Value = 0;
            _cmbTur3.SelectedIndex = 0;
            _nmrOran3.Value = 0;
            _lblTurKategori1.Text = "";
            _lblTurKategori2.Text = "";
            _lblTurKategori3.Text = "";
        }

        private void _dtGridUrunler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilenID = Convert.ToInt32(_dtGridUrunler.CurrentRow.Cells[0].Value);
                _txtUrunIsmi.Text = _dtGridUrunler.CurrentRow.Cells[1].Value.ToString();
                _txtUrunFiyati.Text = _dtGridUrunler.CurrentRow.Cells[2].Value.ToString();
                _txtUzunluk.Text = _dtGridUrunler.CurrentRow.Cells[3].Value.ToString();
                _txtGenislik.Text = _dtGridUrunler.CurrentRow.Cells[4].Value.ToString();
                _txtAgirlik.Text = _dtGridUrunler.CurrentRow.Cells[5].Value.ToString();
                _txtRenk.Text = _dtGridUrunler.CurrentRow.Cells[6].Value.ToString();
                _nmrAdet.Value = Convert.ToDecimal(_dtGridUrunler.CurrentRow.Cells[7].Value.ToString());
                _chkMakine.Checked = Convert.ToBoolean(_dtGridUrunler.CurrentRow.Cells[8].Value.ToString());
                _chkKuruTemizleme.Checked = Convert.ToBoolean(_dtGridUrunler.CurrentRow.Cells[9].Value.ToString());
                _chkKurutma.Checked = Convert.ToBoolean(_dtGridUrunler.CurrentRow.Cells[10].Value.ToString());
                _chkCamasirSuyu.Checked = Convert.ToBoolean(_dtGridUrunler.CurrentRow.Cells[11].Value.ToString());
                _txtDerece.Text = _dtGridUrunler.CurrentRow.Cells[12].Value.ToString();
                _txtCekmePayi.Text = _dtGridUrunler.CurrentRow.Cells[13].Value.ToString();
                _cmbDesen.Text =_dtGridUrunler.CurrentRow.Cells[14].Value.ToString();
                _cmbTur1.Text = _dtGridUrunler.CurrentRow.Cells[15].Value.ToString();
                _nmrOran1.Value = Convert.ToDecimal(_dtGridUrunler.CurrentRow.Cells[16].Value.ToString());
                _cmbTur2.Text = _dtGridUrunler.CurrentRow.Cells[17].Value.ToString();
                _nmrOran2.Value = Convert.ToDecimal(_dtGridUrunler.CurrentRow.Cells[18].Value.ToString());
                _cmbTur3.Text = _dtGridUrunler.CurrentRow.Cells[19].Value.ToString();
                _nmrOran3.Value = Convert.ToDecimal(_dtGridUrunler.CurrentRow.Cells[20].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata " + ex);
            }
        }

        private void _txtRenk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void _txtUrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void UrunEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }
    }
}


