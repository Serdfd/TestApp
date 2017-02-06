using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppEventos.Helpers.Enums;

namespace AppEventos.Models
{
    public class InvitedEventItem
    {
        public int EventId { get; set; }
        public string Tittle { get; set; }
        public DateTime Date { get; set; }
        public string Creator { get; set; }
        public string Image { get; set; }
        public EventState State { get; set; }
        public string DisplayState
        {
            get
            {
                switch ((int)State)
                {
                    case 1: return "Pendiente";
                    case 2: return "Aceptado";
                    case 3: return "Rechazado";
                    default: return "Pendiente";
                };
            }
        }
        public string StateColor
        {
            get
            {
                switch ((int)State)
                {
                    case 1: return "#FDCA45";
                    case 2: return "#6ACA25";
                    case 3: return "#FF0000";
                    default: return "#FDCA45";
                };
            }
        }
        public string DisplayDate { get { return Date.ToString("dd/MM/yyyy"); } }
    }
}
