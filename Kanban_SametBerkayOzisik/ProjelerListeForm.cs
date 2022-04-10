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
    public partial class ProjelerListeForm : Form
    {
        private readonly Veri _veri;
        public event EventHandler plfEventHandler;
        public ProjelerListeForm(Veri veri)
        { 
            InitializeComponent();
            _veri = veri;
        }
        public void dgvGuncelle()
        {
            dgvProjeListe.DataSource = null;
            dgvProjeListe.DataSource = _veri.Projeler;
            dgvProjeListe.Columns[0].Visible = false;
            dgvProjeListe.Columns[1].HeaderText = "Proje Adı";
            dgvProjeListe.Columns[2].Visible = false;
            dgvProjeListe.Columns[3].Visible = false;
        }
        public void dgvProjeListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            plfEventHandler(sender, e);
        }
    }
}
