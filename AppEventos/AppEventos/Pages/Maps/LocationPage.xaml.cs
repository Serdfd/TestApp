using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AppEventos.Pages.Maps
{
    public partial class LocationPage : ContentPage
    {
        #region Attributes
        public bool IsSelect;
        public double Latitude;
        public double Longitude;
        private Geocoder geoCoder;
        private Map Map;
        public string Address;
        #endregion

        #region Properties

        #endregion

        public LocationPage(bool isSelect,double latitude = 6.254299,double longitude = -75.581563)
        {
            InitializeComponent();
            this.IsSelect = isSelect;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.geoCoder = new Geocoder();

            var position = new Position(this.Latitude, this.Longitude);

            ReverseGeocoding(position);

            this.Map = new Map(
            MapSpan.FromCenterAndRadius(
                position, Distance.FromMiles(0.3)))
                {
                    IsShowingUser = true,
                    HeightRequest = 100,
                    WidthRequest = 960,
                    VerticalOptions = LayoutOptions.FillAndExpand
                };

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(this.Map);
            Content = stack;
            this.Map.MapType = MapType.Street;

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Ubicación del evento",
                Address = this.Address
            };
            this.Map.Pins.Add(pin);
        }

        #region Methods

        async void ReverseGeocoding(Position position)
        {
            var possibleAddresses = await geoCoder.GetAddressesForPositionAsync(position);

            //var strAddress = string.Empty;

            //foreach (var address in possibleAddresses)
            //    strAddress += address + "\n";
            if (possibleAddresses != null && possibleAddresses.Any())
            {
                this.Address = possibleAddresses.ElementAt(0);
                this.Map.Pins.ElementAt(0).Address = this.Address;
            }
        }

        #endregion
    }
}
