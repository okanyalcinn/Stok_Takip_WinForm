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
    public partial class FirmaGoster : Form
    {
        public FirmaGoster()
        {
            InitializeComponent();
        }
        KumasStokDBEntities db;
        public static int seciliID = -1;
        int satir_no = -1;
        private void _btnFirmaEkle_Click(object sender, EventArgs e)
        {
            db = new KumasStokDBEntities();
            try
            {
                Firma firma = new Firma();
                firma.TC = _txtVergiNo.Text;
                firma.unvan = _txtUnvan.Text;
                firma.yetkili = _txtYetkili.Text;
                firma.GSM = _txtGSM.Text;
                firma.sabitHat = _txtSabitHat.Text;
                firma.fax = _txtFax.Text;
                firma.ePosta = _txtMail.Text;
                firma.adres = _txtAdres.Text;
                db.Firmalar.Add(firma);
                db.SaveChanges();
                FirmaGoster firmagoster = (FirmaGoster)Application.OpenForms["FirmaGoster"];
                firmagoster.FirmaListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı" + ex);
            }
        }

        private void _btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            db = new KumasStokDBEntities();
            try
            {
                if (FirmaGoster.seciliID != -1)
                {
                    Firma firma = db.Firmalar.Find(FirmaGoster.seciliID);
                    firma.TC = _txtVergiNo.Text;
                    firma.unvan = _txtUnvan.Text;
                    firma.yetkili = _txtYetkili.Text;
                    firma.GSM = _txtGSM.Text;
                    firma.sabitHat = _txtSabitHat.Text;
                    firma.fax = _txtFax.Text;
                    firma.ePosta = _txtMail.Text;
                    firma.adres = _txtAdres.Text;
                    db.SaveChanges();
                    FirmaGoster firmagoster = (FirmaGoster)Application.OpenForms["FirmaGoster"];
                    firmagoster.FirmaListele();
                    MessageBox.Show("Firma bilgileri güncellendi");
                }
                else
                {
                    MessageBox.Show("Bir firma seçiniz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void FirmaListele()
        {
            db = new KumasStokDBEntities();
            var liste = db.Firmalar.Select(x => new
            {
                FirmaID = x.ID,
                FirmaVergiNO = x.TC,
                FirmaUnvan = x.unvan,
                FirmaYetkili = x.yetkili,
                FirmaGSM = x.GSM,
                FirmaSabitHat = x.sabitHat,
                FirmaFax = x.fax,
                FirmaMail = x.ePosta,
                FirmaAdres = x.adres

            }).ToList();
            _dtGridFirmaGoster.DataSource = liste;
            _dtGridFirmaGoster.Columns[0].Visible = false;
            _dtGridFirmaGoster.Columns[1].HeaderText = "Vergi No";
            _dtGridFirmaGoster.Columns[1].Width = 80;
            _dtGridFirmaGoster.Columns[2].HeaderText = "Ünvanı";
            _dtGridFirmaGoster.Columns[2].Width = 110;
            _dtGridFirmaGoster.Columns[3].HeaderText = "Yetkili";
            _dtGridFirmaGoster.Columns[3].Width = 90;
            _dtGridFirmaGoster.Columns[4].HeaderText = "GSM";
            _dtGridFirmaGoster.Columns[4].Width = 90;
            _dtGridFirmaGoster.Columns[5].HeaderText = "Sabit Hat";
            _dtGridFirmaGoster.Columns[5].Width = 90;
            _dtGridFirmaGoster.Columns[6].HeaderText = "Fax";
            _dtGridFirmaGoster.Columns[6].Width = 90;
            _dtGridFirmaGoster.Columns[7].HeaderText = "Mail";
            _dtGridFirmaGoster.Columns[7].Width = 90;
            _dtGridFirmaGoster.Columns[8].HeaderText = "                              Adres";
            _dtGridFirmaGoster.Columns[8].Width = 225;
        }

        private void FirmaGoster_Load(object sender, EventArgs e)
        {
            FirmaListele();
        }

        private void _btnFirmaSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Firmayı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                if (seciliID != -1)
                {
                    try
                    {
                        Firma firma = db.Firmalar.Find(seciliID);
                        db.Firmalar.Remove(firma);
                        db.SaveChanges();
                        FirmaListele();
                        MessageBox.Show("Seçilen firma silindi");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex);
                    }
                }
            }
        }

        bool FirmaSecimi = false;
        private void _dtGridFirmaGoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliID = Convert.ToInt32(_dtGridFirmaGoster.CurrentRow.Cells[0].Value);
            FirmaSecimi = true;
            satir_no = (int)_dtGridFirmaGoster.CurrentRow.Cells[0].Value;
            _txtVergiNo.Text = _dtGridFirmaGoster.CurrentRow.Cells[1].Value.ToString();
            _txtUnvan.Text = _dtGridFirmaGoster.CurrentRow.Cells[2].Value.ToString();
            _txtYetkili.Text = _dtGridFirmaGoster.CurrentRow.Cells[3].Value.ToString();
            _txtGSM.Text = _dtGridFirmaGoster.CurrentRow.Cells[4].Value.ToString();
            _txtSabitHat.Text = _dtGridFirmaGoster.CurrentRow.Cells[5].Value.ToString();
            _txtFax.Text = _dtGridFirmaGoster.CurrentRow.Cells[6].Value.ToString();
            _txtMail.Text = _dtGridFirmaGoster.CurrentRow.Cells[7].Value.ToString();
            _txtAdres.Text = _dtGridFirmaGoster.CurrentRow.Cells[8].Value.ToString();
        }

        private void _sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _harf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void _timer1_Tick(object sender, EventArgs e)
        {
            _lblKarakterSayac.Text = (_txtAdres.MaxLength - say).ToString();
        }

        int say = 0;
        private void _txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && say < _txtAdres.MaxLength)
            {
                say++;
            }
            else
            {
                say--;
            }
        }

        private void _btnFirmaTemizle_Click(object sender, EventArgs e)
        {
            seciliID = -1;
            _txtAdres.Clear();
            _txtFax.Clear();
            _txtGSM.Clear();
            _txtMail.Clear();
            _txtSabitHat.Clear();
            _txtUnvan.Clear();
            _txtVergiNo.Clear();
            _txtYetkili.Clear();
        }

        private void FirmaGoster_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaMenu ana = new AnaMenu();
            ana.Show();
        }
    }
}
