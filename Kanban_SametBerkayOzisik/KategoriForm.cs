using Kanban.DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_SametBerkayOzisik
{
    public partial class KategoriForm : Form
    {
        private readonly Veri _veri;
        public KategoriForm(Veri veri)
        {
            InitializeComponent();
            _veri = veri;
            lstKategorilerYukle();
            pboRenk.BackColor = Color.FromArgb(255, 255, 153);
        }
        private void lstKategorilerYukle()
        {
            lstKategoriler.DataSource = null;
            lstKategoriler.DisplayMember = "Ad";
            lstKategoriler.DataSource = _veri.Kategoriler;
            lstKategoriler.SelectedIndex = lstKategoriler.Items.Count-1;
        }
        private void pboRenk_Click(object sender, EventArgs e)
        {
            ColorDialog renkSecici = new ColorDialog();
            if (renkSecici.ShowDialog() == DialogResult.OK)
            {
                pboRenk.BackColor = renkSecici.Color;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKategoriAd.Text))
            {
                Kategori yeniKategori = new Kategori();
                yeniKategori.Ad = txtKategoriAd.Text;
                yeniKategori.Renk = pboRenk.BackColor;
                _veri.Kategoriler.Add(yeniKategori);
                txtKategoriAd.Text = "";
                pboRenk.BackColor = Color.FromArgb(255, 255, 153);
                lstKategorilerYukle();
            }
            else
            {
                MessageBox.Show("Bir kategori adı girmelisiniz.");
            }
        }
        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex != -1)
            {
                Kategori secili = (Kategori)lstKategoriler.SelectedItem;
                pboKategoriRenk.BackColor = secili.Renk;
            }
        }
        private void lstKategoriler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show(
                    "Secili kategoriyi silmek istediğinizden emin misiniz ?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    Kategori silinecek = (Kategori)lstKategoriler.SelectedItem;
                    _veri.Kategoriler.Remove(silinecek);
                    lstKategorilerYukle();
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
