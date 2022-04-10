using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DATA.Models
{
    public class Kategori
    {
        public Kategori()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public Color Renk { get; set; }
    }
}
