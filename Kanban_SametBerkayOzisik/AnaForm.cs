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
    public partial class AnaForm : Form
    {
        Veri veri;
        ProjelerListeForm plf;
        public DataGridViewCellCancelEventArgs e;
        ProjeForm form;

        public AnaForm()
        {
            veri = new Veri();
            InitializeComponent();
        }
        private void projeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proje yeniProje = new Proje();
            ProjeBilgiForm pbf = new ProjeBilgiForm(yeniProje, veri);
            DialogResult dr = pbf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                plf.dgvGuncelle();
            }
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            plf = new ProjelerListeForm(veri);
            plf.Text = "Proje Listesi";
            plf.MdiParent = this;
            plf.plfEventHandler += Plf_plfEventHandler;
            plf.Dock = DockStyle.Left;
            plf.MaximizeBox = false;
            plf.MinimizeBox = false;
            plf.ControlBox = false;
            plf.Show();
        }

        private void Plf_plfEventHandler(object sender, EventArgs e)
        {
            DataGridView dgvListe = (DataGridView)sender;
            Guid seciliId = (Guid)dgvListe.SelectedRows[0].Cells[0].Value;
            ProjeAc(seciliId);
        }

        public void ProjeAc(Guid seciliId)
        {
            bool asd = false;
            for (int i = 1; i < MdiChildren.Count(); i++)
            {
                if ((Guid)MdiChildren[i].Tag == seciliId)
                {
                    MdiChildren[i].Show();
                    asd = true;
                }
                else
                {
                    MdiChildren[i].Hide();
                }
            }
            if (asd == false)
            {
                form = new ProjeForm(veri, seciliId);
                form.Tag = seciliId;
                Proje proje = veri.Projeler.First(x => x.Id == seciliId);
                form.Text = " - - - - - " + proje.Ad + " - - - - - " + proje.OlusturulmaZamani.ToString() + " - - - - - ";
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                // hareket etmesini engelleyen kodu yaz.
                form.MdiParent = this;
                form.Dock = DockStyle.Right;
                form.MdiParent = this;
                form.Show();
            }
        }
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriForm form = new KategoriForm(veri);
            form.ShowDialog();
        }
    }
}
