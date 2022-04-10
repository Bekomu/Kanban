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
    public partial class NotEkleForm : Form
    {
        private readonly Veri _veri;
        private readonly Proje _buProje;
        public NotEkleForm(Veri veri, Proje buProje)
        {
            _veri = veri;
            _buProje = buProje;
            InitializeComponent();
            cboKategoriYukle();
        }
        private void cboKategoriYukle()
        {
            cboKategori.DataSource = null;
            cboKategori.DisplayMember = "Ad";
            cboKategori.ValueMember = "Id";
            cboKategori.DataSource = _veri.Kategoriler;
        }
        private void cboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboKategori.SelectedIndex != -1)
            {
                Kategori seciliKategori = (Kategori)cboKategori.SelectedItem;
                pnlNotYeni.BackColor = seciliKategori.Renk;
            }
        }
        private void txtIcerik_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIcerik.Text))
            {
                lblIcerik.Text = txtIcerik.Text;
                lblKalan.Text = "Kalan : "+(140 - txtIcerik.TextLength).ToString();
            }
        }
        private void txtBaslik_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBaslik.Text))
            {
                lblBaslik.Text = txtBaslik.Text;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBaslik.Text) && 
                !string.IsNullOrEmpty(txtIcerik.Text) &&
                cboKategori.SelectedIndex != -1)
            {
                lblKategori.Text = cboKategori.Text;
                _buProje.NotPaneller.Add(pnlNotYeni);
                MessageBox.Show("Not başarıyla eklendi.");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Başlık, içerik ve kategori bölümleri zorunludur.");
            }
        }
    }
}
