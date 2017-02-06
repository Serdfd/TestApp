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
    public partial class MyEvents : ContentPage
    {
        private NavigationHelper Navigator;
        public MyEvents()
        {
            InitializeComponent();
            Navigator = new NavigationHelper();

            var events = new List<MyEventItem>();
            events.Add(new MyEventItem
            {
                Date = DateTime.Now,
                EventId = 1,
                Tittle = "Evento 1"
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

            listView.ItemsSource = events;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigator.Navigate("CreateEvent");
        }
    }
}
