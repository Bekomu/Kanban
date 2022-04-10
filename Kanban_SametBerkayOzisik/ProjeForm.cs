using Kanban.DATA;
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
    public partial class ProjeForm : Form
    {
        Panel todoEkrani;
        Panel doingEkrani;
        Panel doneEkrani;
        Panel pnlNot;
        List<Panel> todoPaneller;
        List<Panel> doingPaneller;
        List<Panel> donePaneller;
        Proje buProje;
        private readonly Veri _veri;
        private readonly Guid _projeId;
        public ProjeForm(Veri veri, Guid projeId)
        {
            _veri = veri;
            _projeId = projeId;
            buProje = _veri.Projeler.First(x => x.Id == _projeId);
            todoPaneller = new List<Panel>();
            doingPaneller = new List<Panel>();
            donePaneller = new List<Panel>();
            InitializeComponent();
            DurumBolumOlustur();
        }
        private void DurumBolumDuzenle()
        {
            if (todoPaneller.Count > 0)
            {
                todoPaneller[0].Top = todoEkrani.Top + 50;
                if (todoPaneller.Count > 1)
                {
                    for (int i = 1; i < todoPaneller.Count; i++)
                    {
                        todoPaneller[i].Top = todoPaneller[i - 1].Bottom + 50;
                    }
                }
            }
            if (doingPaneller.Count > 0)
            {
                doingPaneller[0].Top = todoEkrani.Top + 50;
                if (doingPaneller.Count > 0)
                {
                    for (int i = 1; i < doingPaneller.Count; i++)
                    {
                        doingPaneller[i].Top = doingPaneller[i - 1].Bottom + 50;
                    }
                }
            }
            if (donePaneller.Count > 0)
            {
                donePaneller[0].Top = todoEkrani.Top + 50;
                if (donePaneller.Count > 1)
                {
                    for (int i = 1; i < donePaneller.Count; i++)
                    {
                        donePaneller[i].Top = donePaneller[i - 1].Bottom + 50;
                    }
                }
            }
        }
        private void DurumBolumOlustur()
        {
            todoEkrani = new Panel();
            doingEkrani = new Panel();
            doneEkrani = new Panel();

            todoEkrani.Top = this.Top + 25;
            todoEkrani.BackColor = Color.FromArgb(153, 230, 255);
            todoEkrani.Width = this.Width / 3 - 7;
            todoEkrani.Left = this.Left;
            todoEkrani.Height = this.Height;
            Controls.Add(todoEkrani);

            doingEkrani.Top = this.Top + 25;
            doingEkrani.BackColor = Color.FromArgb(255, 204, 153);
            doingEkrani.Width = this.Width / 3 - 3;
            doingEkrani.Left = todoEkrani.Right;
            doingEkrani.Height = this.Height;
            Controls.Add(doingEkrani);

            doneEkrani.Top = this.Top + 25;
            doneEkrani.BackColor = Color.FromArgb(153, 255, 204);
            doneEkrani.Width = this.Width / 3 - 3;
            doneEkrani.Left = doingEkrani.Right;
            doneEkrani.Height = this.Height;
            Controls.Add(doneEkrani);
        }
        private void ProjeForm_SizeChanged(object sender, EventArgs e)
        {
            todoEkrani.Width = this.Width / 3 - 7;
            todoEkrani.Height = this.Height + 1000;

            doingEkrani.Left = todoEkrani.Right;
            doingEkrani.Width = this.Width / 3 - 3;
            doingEkrani.Height = this.Height + 1000;

            doneEkrani.Left = doingEkrani.Right;
            doneEkrani.Width = this.Width / 3 - 3;
            doneEkrani.Height = this.Height + 1000;

            foreach (var item in buProje.NotPaneller)
            {
                if (item.Left < todoEkrani.Width / 2 + 10)
                {
                    item.Left = todoEkrani.Width / 2 - 100;
                }
                if (item.Left > todoEkrani.Width / 2 + 10 && item.Left < todoEkrani.Width + doingEkrani.Width / 2 - 10)
                {
                    item.Left = todoEkrani.Width + doingEkrani.Width / 2 - 100;
                }
                if (item.Left > todoEkrani.Width + doingEkrani.Width / 2 - 10)
                {
                    item.Left = todoEkrani.Width + doingEkrani.Width + doneEkrani.Width / 2 - 100;
                }
            }
        }
        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            pnlNot = new Panel();
            NotEkleForm form = new NotEkleForm(_veri, buProje);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (buProje.NotPaneller.Count == 1)
                {
                    pnlNot = buProje.NotPaneller[0];
                    ControlExtension.Draggable(pnlNot, true);
                    pnlNot.Left = todoEkrani.Width / 2 - 100;
                    pnlNot.Top = todoEkrani.Top + 50;
                    this.Controls.Add(pnlNot);
                    todoPaneller.Add(pnlNot);
                    pnlNot.BringToFront();
                }
                else
                {
                    pnlNot = buProje.NotPaneller[buProje.NotPaneller.Count-1];
                    ControlExtension.Draggable(pnlNot, true);
                    pnlNot.Left = todoEkrani.Width / 2 - 100;
                    if (todoPaneller.Count == 0)
                    {
                        pnlNot.Left = todoEkrani.Width / 2 - 100;
                        pnlNot.Top = todoEkrani.Top + 50;
                        this.Controls.Add(pnlNot);
                        todoPaneller.Add(pnlNot);
                        pnlNot.BringToFront();
                    }
                    else
                    {
                        pnlNot.Left = todoEkrani.Width / 2 - 100;
                        pnlNot.Top = todoPaneller[todoPaneller.Count - 1].Bottom + 50;
                        this.Controls.Add(pnlNot);
                        todoPaneller.Add(pnlNot);
                        pnlNot.BringToFront();
                    }
                }
            }
            pnlNot.MouseUp += PnlNot_MouseUp;
        }
        private void PnlNot_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (var item in buProje.NotPaneller)
            {
                if (item.Top < this.Top + 50)
                {
                    item.Top = this.Top + 50;
                }
                if (item.Left < todoEkrani.Width / 2 + 20)  // todo paneli
                {
                    Panel tasinacak = (Panel)item;
                    if (doingPaneller.Contains(tasinacak))
                    {
                        todoPaneller.Add(tasinacak);
                        doingPaneller.Remove(tasinacak);
                    }
                    if (donePaneller.Contains(tasinacak))
                    {
                        todoPaneller.Add(tasinacak);
                        donePaneller.Remove(tasinacak);
                    }
                    item.Left = todoEkrani.Width / 2 - 100;
                }
                if (item.Left > todoEkrani.Width / 2 + 10 &&
                    item.Left < todoEkrani.Width + doingEkrani.Width / 2 - 10) // doing paneli
                {
                    Panel tasinacak = (Panel)item;
                    if (todoPaneller.Contains(tasinacak))
                    {
                        doingPaneller.Add(tasinacak);
                        todoPaneller.Remove(tasinacak);
                    }
                    if (donePaneller.Contains(tasinacak))
                    {
                        doingPaneller.Add(tasinacak);
                        donePaneller.Remove(tasinacak);
                    }
                    item.Left = todoEkrani.Width + doingEkrani.Width / 2 - 100;
                }
                if (item.Left > todoEkrani.Width + doingEkrani.Width / 2 - 10)  // done paneli
                {
                    Panel tasinacak = item;
                    if (todoPaneller.Contains(tasinacak))
                    {
                        donePaneller.Add(tasinacak);
                        todoPaneller.Remove(tasinacak);
                    }
                    if (doingPaneller.Contains(tasinacak))
                    {
                        donePaneller.Add(tasinacak);
                        doingPaneller.Remove(tasinacak);
                    }
                    item.Left = todoEkrani.Width + doingEkrani.Width + doneEkrani.Width / 2 - 100;
                }
            }
            DurumBolumDuzenle();
        }
        private void ProjeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Çıkmak istiyor musunuz ?",
                "Çıkma onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if(dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.Hide();
                e.Cancel = true;
            }
        }
    }
}
