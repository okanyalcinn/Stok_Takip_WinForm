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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        KumasStokDBEntities db;

        private void Giris_Load(object sender, EventArgs e)
        {
            db = new KumasStokDBEntities();
            var s = db.GirisBilgileri.Select(x => new
            {
                x.ID,
                x.Kullanici,
                x.Sifre,
                x.Hatirla
            }).ToList();

            foreach (var item in s)
            {
                if (item.Hatirla)
                {
                    _chckBeniHatirla.Checked = true;
                    _txtKullaniciAdi.Text = item.Kullanici;
                    _txtSifre.Text = item.Sifre;
                }
                else
                {
                    _chckBeniHatirla.Checked = false;
                }
            }
        }

        private void _btnGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        void GirisYap()
        {
            db = new KumasStokDBEntities();
            foreach (GirisBilgi item in db.GirisBilgileri)
            {
                if (item.Kullanici == _txtKullaniciAdi.Text && item.Sifre == _txtSifre.Text)
                {
                    if (_chckBeniHatirla.Checked)
                    {
                        item.Hatirla = true;                        
                    }
                    else
                    {
                        item.Hatirla = false;
                    }
                    AnaMenu anaMenu = new AnaMenu();
                    anaMenu.Show();
                    this.Hide();
                    break;
                }
            }
            db.SaveChanges();
            
        }

        private void _txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar( Keys.Enter))
            {
                GirisYap();
            }
        }
    }
}
