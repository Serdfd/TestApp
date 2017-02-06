using AppEventos.Helpers;
using AppEventos.Pages.Providers;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppEventos.ViewModels
{
    public class LoginViewModel
    {
        #region Attributes

        private NavigationHelper navigationHelper;

        #endregion

        #region Commands

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        #endregion

        #region Methods
                
        private async void Login()
        {
            await App.Navigator.PushAsync(new ProviderLoginPage());
        }

        #endregion


    }
}
