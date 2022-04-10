using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban.DATA.Models
{
    public class Proje
    {
        public Proje()
        {
            Notlar = new List<Not>();
            OlusturulmaZamani = DateTime.Now;
            Id = Guid.NewGuid();
            NotPaneller = new List<Panel>();
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public ICollection<Not> Notlar { get; set; }
        public List<Panel> NotPaneller { get; set; }
    }
}
