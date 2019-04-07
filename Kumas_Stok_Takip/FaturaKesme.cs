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
    public partial class FaturaKesme : Form
    {
        public FaturaKesme()
        {
            InitializeComponent();
        }
        KumasStokDBEntities db;
        private void FirmaListele()
        {
            db = new KumasStokDBEntities();
            var liste = db.Firmalar.Select(x => new
            {
                x.ID,
                x.unvan
            }).OrderBy(x => x.unvan).ToList();
            _cmbFirmaUnvani.DisplayMember = "unvan";
            _cmbFirmaUnvani.ValueMember = "ID";
            _cmbFirmaUnvani.DataSource = liste;
        }
        private void KumasListele()
        {
            db = new KumasStokDBEntities();
            var liste = db.Urunler.Select(x => new
            {
                x.ID,
                x.ad
            }).OrderBy(x => x.ad).ToList();
            _cmbKumasAdi.DisplayMember = "ad";
            _cmbKumasAdi.ValueMember = "ID";
            _cmbKumasAdi.DataSource = liste;
        }

        private void FaturaKesme_Load(object sender, EventArgs e)
        {
            FirmaListele();
            KumasListele();
        }

        private void FaturadakileriListele()
        {
            var liste = db.FaturaDetaylari.Select(x => new
            {
                x.id,
                x.faturaID,
                x.Urunler.ad,
                x.adet,
                x.Urunler.fiyat,
                x.toplamFiyat,
                x.urunID
            }).Where(x => x.faturaID == fatura.ID).ToList();
            _dtGridFaturaKesme.DataSource = liste;
            _dtGridFaturaKesme.Columns[0].Visible = false;
            _dtGridFaturaKesme.Columns[1].Visible = false;
            _dtGridFaturaKesme.Columns[2].HeaderText = "Ürün Adı";
            _dtGridFaturaKesme.Columns[3].HeaderText = "Adet";
            _dtGridFaturaKesme.Columns[4].HeaderText = "Fiyat";
            _dtGridFaturaKesme.Columns[5].HeaderText = "Toplam Fiyat";
            _dtGridFaturaKesme.Columns[6].Visible = false;
        }

        private void _cmbKumasAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbKumasAdi.SelectedValue != null)
            {
                int kumas = (int)_cmbKumasAdi.SelectedValue;
                string renk = db.Urunler.Find(kumas).renk;
                _txtRenk.Text = renk;
                int metre = (int)db.Urunler.Find(kumas).metre;
                _txtTopMetresi.Text = metre.ToString();
                string desen = db.Urunler.Find(kumas).Ozellikler.Desenler.ad;
                _txtDesen.Text = desen;
                urunVarMi = false;
            }
        }

        private void _cmbFirmaUnvani_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbFirmaUnvani.SelectedValue != null)
            {
                int firma = (int)_cmbFirmaUnvani.SelectedValue;
                string yetkili = db.Firmalar.Find(firma).yetkili;
                _txtYetkili.Text = yetkili;
                string vergiNo = db.Firmalar.Find(firma).TC;
                _txtVergiNo.Text = vergiNo;
            }
        }
        bool urunVarMi = false;
        List<int> GeciciUrunListesi = new List<int>();
        private void _btnUrunEkle_Click(object sender, EventArgs e)
        {
            float toplam = 0;
            db = new KumasStokDBEntities();
            if (_dtGridFaturaKesme.Rows.Count == 0)
            {
                if (_nmrAdet.Value > 0)
                {
                    try
                    {
                        float fiyat = (float)(db.Urunler.Find((int)_cmbKumasAdi.SelectedValue).fiyat);
                        FaturaDetay faturaDetay = new FaturaDetay();
                        faturaDetay.urunID = (int)_cmbKumasAdi.SelectedValue;
                        faturaDetay.adet = (int)_nmrAdet.Value;
                        int adet = (int)_nmrAdet.Value;
                        faturaDetay.toplamFiyat = (float)(adet * fiyat);
                        db.FaturaDetaylari.Add(faturaDetay);
                        faturaDetay.faturaID = fatura.ID;
                        db.SaveChanges();
                        GeciciUrunListesi.Add(faturaDetay.id);
                        MessageBox.Show("Faturaya ürün Eklendi");
                        FaturadakileriListele();
                        for (int k = 0; k < _dtGridFaturaKesme.Rows.Count; k++)
                        {
                            toplam += Convert.ToSingle(_dtGridFaturaKesme[5, k].Value);
                        }
                        _txtGenelToplam.Text = toplam.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata ile karşılaşıldı" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("0'dan farklı bir değer giriniz");
                }
            }
            else
            {
                for (int i = 0; i < _dtGridFaturaKesme.Rows.Count; i++)
                {
                    if (Convert.ToInt32(_dtGridFaturaKesme[6, i].Value) == (int)_cmbKumasAdi.SelectedValue)
                    {
                        urunVarMi = true;
                        break;
                    }
                }
                if (!urunVarMi)
                {
                    if (_nmrAdet.Value > 0)
                    {
                        try
                        {
                            float fiyat = (float)(db.Urunler.Find((int)_cmbKumasAdi.SelectedValue).fiyat);
                            FaturaDetay faturaDetay = new FaturaDetay();
                            faturaDetay.urunID = (int)_cmbKumasAdi.SelectedValue;
                            faturaDetay.adet = (int)_nmrAdet.Value;
                            int adet = (int)_nmrAdet.Value;
                            faturaDetay.toplamFiyat = (float)(adet * fiyat);
                            db.FaturaDetaylari.Add(faturaDetay);
                            faturaDetay.faturaID = fatura.ID;
                            db.SaveChanges();
                            GeciciUrunListesi.Add(faturaDetay.id);
                            MessageBox.Show("Faturaya ürün Eklendi");
                            FaturadakileriListele();
                            for (int k = 0; k < _dtGridFaturaKesme.Rows.Count; k++)
                            {
                                toplam += Convert.ToSingle(_dtGridFaturaKesme[5, k].Value);
                            }
                            _txtGenelToplam.Text = toplam.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir hata ile karşılaşıldı" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("0'dan farklı bir değer giriniz");
                    }
                }
                else
                {
                    MessageBox.Show("Faturada zaten eklenmiş");
                }

            }
        }
        Fatura fatura;
        int faturaID = -1;
        bool faturayaBasla = false;
        private void _btnFaturaKesmeyeBasla_Click(object sender, EventArgs e)
        {
            fatura = new Fatura();
            fatura.firmaID = (int)_cmbFirmaUnvani.SelectedValue;
            fatura.tarih = _dateTarih.Value;
            db.Faturalar.Add(fatura);
            db.SaveChanges();
            faturaID = fatura.ID;
            _pnlFirmaSecme.Enabled = false;
            _pnlUrunEkleme.Enabled = true;
            _dtGridFaturaKesme.Enabled = true;
            _btnFaturaKaydet.Enabled = true;
            faturayaBasla = true;
        }

        private void _nmrAdet_ValueChanged(object sender, EventArgs e)
        {
            foreach (Urun item in db.Urunler)
            {
                if (item.ID == (int)_cmbKumasAdi.SelectedValue)
                {
                    if (item.adet <= _nmrAdet.Value)
                    {
                        MessageBox.Show("Stokta bu kadar ürün yok. Stokta: " + item.adet + " ürün var.");
                    }
                }
            }
        }

        bool faturaKaydet = false;
        private void _btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                faturaKaydet = true;
                foreach (Fatura item in db.Faturalar)
                {
                    if (item.ID == faturaID)
                    {
                        item.genelToplam = Convert.ToInt32(_txtGenelToplam.Text);
                    }
                }
                db.SaveChanges();
                foreach (Urun item in db.Urunler)
                {
                    for (int i = 0; i < _dtGridFaturaKesme.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(_dtGridFaturaKesme[6, i].Value) == item.ID)
                        {
                            item.adet = item.adet - Convert.ToInt32(_dtGridFaturaKesme[3, i].Value);
                        }
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Fatura kayıt işlemi tamamlandı");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("kayıt hatası!");
            }
        }

        private void FaturaKesme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (faturayaBasla)
            {

                if (!faturaKaydet)
                {
                    DialogResult sonuc = MessageBox.Show("Yapılan değişiklikleri kaydetmeden çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (sonuc == DialogResult.Yes)
                    {
                        for (int i = 0; i < GeciciUrunListesi.Count; i++)
                        {
                            FaturaDetay faturaDetay = db.FaturaDetaylari.Find(GeciciUrunListesi[i]);
                            db.FaturaDetaylari.Remove(faturaDetay);
                            db.SaveChanges();
                        }
                        if (faturaID != -1)
                        {
                            Fatura fatura = db.Faturalar.Find(faturaID);
                            db.Faturalar.Remove(fatura);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }
    }
}
