using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Models
{
    public class MyEventItem
    {
        public int EventId { get; set; }
        public DateTime Date { get; set; }
        public string Tittle { get; set; }
        public string DisplayDate { get { return Date.ToString("dd/MM/yyyy"); } }
    }
}
