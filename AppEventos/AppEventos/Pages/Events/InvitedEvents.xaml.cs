using AppEventos.Helpers;
using AppEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppEventos.Pages.Events
{
    public partial class InvitedEvents : ContentPage
    {
        #region Attributes
        private NavigationHelper Navigator;
        #endregion
        public InvitedEvents()
        {
            InitializeComponent();
            Navigator = new NavigationHelper();

            var events = new List<InvitedEventItem>();

            events.Add(new InvitedEventItem
            {
                Date = DateTime.Now,
                EventId = 1,
                Tittle = "Evento 1",
                Creator = "seflorez@personalsoft.com.co",
                Image = "http://www.intrawallpaper.com/static/images/82317_cNdkQg0.jpg",
                State = Helpers.Enums.EventState.Pendiente
            });

            events.Add(new InvitedEventItem
            {
                Date = DateTime.Now,
                EventId = 1,
                Tittle = "Evento 1",
                Creator = "seflorez@personalsoft.com.co",
                Image = "http://www.intrawallpaper.com/static/images/82317_cNdkQg0.jpg",
                State = Helpers.Enums.EventState.Aceptado
            });

            events.Add(new InvitedEventItem
            {
                Date = DateTime.Now,
                EventId = 1,
                Tittle = "Evento 1",
                Creator = "seflorez@personalsoft.com.co",
                Image = "http://www.intrawallpaper.com/static/images/82317_cNdkQg0.jpg",
                State = Helpers.Enums.EventState.Rechazado
            });

            listView.ItemsSource = events;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigator.Navigate("ViewEvent");
        }
    }
}
