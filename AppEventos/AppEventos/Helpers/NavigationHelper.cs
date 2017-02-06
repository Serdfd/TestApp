using AppEventos.Infraestructure;
using AppEventos.Models;
using AppEventos.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppEventos.Helpers
{
    public class NavigationHelper
    {
        #region Attributes
        #endregion

        public NavigationHelper()
        {

        }

        public async void Navigate(string PageName)
        {
            switch (PageName)
            {
                case "Events":
                    await App.Navigator.PushAsync(new Pages.Events.Events());
                    break;
                case "CreateEvent":
                    await App.Navigator.PushAsync(new Pages.Events.CreateEvent());
                    break;
                case "ViewEvent":
                    await App.Navigator.PushAsync(new Pages.Events.ViewEvent());
                    break;
                case "SelectLocation":
                    await App.Navigator.PushAsync(new Pages.Maps.LocationPage(true));
                    break;
                case "Logout":
                    Logout();                    
                    break;
                default:
                    break;
            }
            App.Master.IsPresented = false;
        }


        public async void PopAsync()
        {
            await App.Navigator.PopAsync();
        }

        public static void SetMainPage(User user)
        {
            var mainViewModel = InstanceLocator.GetInstance().Main;
            mainViewModel.LoadUser(user);
            App.Current.MainPage =  new MasterPage();
        }

        private void Logout()
        {
            App.SaveToken(string.Empty);
            App.CurrentUser = null;
            App.Current.MainPage = new LoginPage();
        }
    }
}
