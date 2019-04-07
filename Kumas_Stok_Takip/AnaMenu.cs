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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void _btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
            this.Hide();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void _btnFirmalar_Click(object sender, EventArgs e)
        {
            FirmaGoster firmagoster = new FirmaGoster();
            firmagoster.Show();
            this.Hide();
        }

        private void _btnFaturaKesme_Click(object sender, EventArgs e)
        {
            FaturaKesme faturakesme = new FaturaKesme();
            faturakesme.Show();
            this.Hide();
        }

        private void _btnStokTakibi_Click(object sender, EventArgs e)
        {
            StokTakibi stoktakibi = new StokTakibi();
            stoktakibi.Show();
            this.Hide();
        }

        private void AnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void _btnFaturalar_Click(object sender, EventArgs e)
        {

            Faturalar faturalar = new Faturalar();
            faturalar.Show();
            this.Hide();

        }
    }
}
