using AppEventos.Helpers;
using AppEventos.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppEventos.ViewModels
{
    public class MenuItemViewModel: MenuItem
    {
        private NavigationHelper navigationHelper;

        public MenuItemViewModel()
        {
            navigationHelper = new NavigationHelper();
        }

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(() => navigationHelper.Navigate(PageName));
            }
        }
    }
}
