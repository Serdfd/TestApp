using AppEventos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.ViewModels
{
    public class EventViewModel
    {
        #region Attributes
        public DateTime dateDatePicker { get; set; }
        #endregion

        #region Properties
        public ObservableCollection<MyEventItem> MyEvents { get; set; }
        public ObservableCollection<InvitedEventItem> InvitedEvents { get; set; }

        #endregion

        #region Methods
        private async void LoadMyEvents()
        {
            var events = new List<MyEventItem>();
            events.Add(new MyEventItem
            {
                Date = DateTime.Now,
                EventId=1,
                Tittle="Evento 1"
            });

            events.Add(new MyEventItem
            {
                Date = DateTime.Now,
                EventId = 1,
                Tittle = "Evento 2"
            });

            events.Add(new MyEventItem
            {
                Date = DateTime.Now,
                EventId = 1,
                Tittle = "Evento 3"
            });

        }

        private async void LoadInvitedEvents()
        {
            var events = new List<InvitedEventItem>();

            events.Add(new InvitedEventItem
            {
                Date = DateTime.Now,
                EventId = 1,
                Tittle = "Evento 1",
                Creator = "seflorez@personalsoft.com.co",
                Image = "https://www.librerianacional.com/custom/include/SugarFields/Fields/ExistayaFile/files/img/20150822033525_la%20chica.png"
            });

            events.Add(new InvitedEventItem
            {
                Date = DateTime.Now,
                EventId = 1,
                Tittle = "Evento 1",
                Creator = "seflorez@personalsoft.com.co",
                Image = "https://www.librerianacional.com/custom/include/SugarFields/Fields/ExistayaFile/files/img/20150822033525_la%20chica.png"
            });

            events.Add(new InvitedEventItem
            {
                Date = DateTime.Now,
                EventId = 1,
                Tittle = "Evento 1",
                Creator = "seflorez@personalsoft.com.co",
                Image = "https://www.librerianacional.com/custom/include/SugarFields/Fields/ExistayaFile/files/img/20150822033525_la%20chica.png"
            });

        }
        #endregion
    }
}
