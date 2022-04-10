using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban.DATA.Models
{
    public class Veri
    {
        public Veri()
        {
            Projeler = new List<Proje>();
            Kategoriler = new List<Kategori>();
        }
        public List<Proje> Projeler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}
