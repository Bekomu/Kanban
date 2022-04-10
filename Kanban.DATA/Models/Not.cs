using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DATA.Models
{
    public class Not
    {
        public Not()
        {
            OlusturulmaZamani = DateTime.Now;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public Kategori Kategori { get; set; }
    }
}
