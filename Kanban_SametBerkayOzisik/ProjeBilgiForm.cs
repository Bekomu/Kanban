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
    public partial class ProjeBilgiForm : Form
    {
        private readonly Proje _yeniProje;
        private readonly Veri _veri;
        public ProjeBilgiForm(Proje yeniProje, Veri veri)
        {
            InitializeComponent();
            _yeniProje = yeniProje;
            _veri = veri;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ProjeEkle();
        }
        private void ProjeEkle()
        {
            if (!string.IsNullOrEmpty(txtAd.Text))
            {
                _yeniProje.Ad = txtAd.Text;
                _veri.Projeler.Add(_yeniProje);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Proje adı girilmesi zorunludur.");
                return;
            }
        }
        private void txtAd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProjeEkle();
            }
        }
    }
}
