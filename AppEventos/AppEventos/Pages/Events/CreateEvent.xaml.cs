using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;

using Xamarin.Forms;
using AppEventos.Helpers;

namespace AppEventos.Pages.Events
{
    public partial class CreateEvent : ContentPage
    {
        #region Attributes
        private NavigationHelper Navigator;
        #endregion

        #region Properties

        #endregion

        public CreateEvent()
        {
            InitializeComponent();
            dpEventDate.SetValue(DatePicker.MinimumDateProperty, DateTime.Now);
            Navigator = new NavigationHelper();
        }

        #region Methods

        async void OnUpload(object sender, EventArgs e)
        {
            try
            {

                FileData filedata = await CrossFilePicker.Current.PickFile();
                // the dataarray of the file will be found in filedata.DataArray 
                // file name will be found in filedata.FileName;
                //etc etc.
                //TODO: Validar formato de imagen
                var name = filedata.FileName;

            }
            catch (Exception ex)
            {
                //No es necesario controlar
            }
        }

        async void Save(object sender, EventArgs e)
        {

        }

        #endregion

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigator.Navigate("SelectLocation");
        }
    }
}
