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
    public partial class Faturalar : Form
    {
        public Faturalar()
        {
            InitializeComponent();
        }
        KumasStokDBEntities db;
        private void Faturalar_Load(object sender, EventArgs e)
        {
            db = new KumasStokDBEntities();
            var liste = db.Faturalar.Select(x => new
            {
                x.ID,
                x.Firmalar.TC,
                x.Firmalar.unvan,
                x.Firmalar.yetkili,
                x.tarih,
                x.genelToplam           
            }).ToList();
            _dtGridFaturalar.DataSource = liste;
            _dtGridFaturalar.Columns[0].Visible = false;
            _dtGridFaturalar.Columns[1].HeaderText = "Vergi No";
            _dtGridFaturalar.Columns[1].Width = 70;
            _dtGridFaturalar.Columns[2].HeaderText = "Ünvan";
            _dtGridFaturalar.Columns[2].Width = 80;
            _dtGridFaturalar.Columns[3].HeaderText = "Yetkili";
            _dtGridFaturalar.Columns[3].Width = 80;
            _dtGridFaturalar.Columns[4].HeaderText = "Tarih";
            _dtGridFaturalar.Columns[4].Width = 100;
            _dtGridFaturalar.Columns[5].HeaderText = "Genel Toplam";
            _dtGridFaturalar.Columns[5].Width = 120;
           
        }

        private void Faturalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu ana = new AnaMenu();
            ana.Show();
        }
    }
}
