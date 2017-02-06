using AppEventos.Helpers;
using AppEventos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.ViewModels
{
    public class MainViewModel
    {
        #region Attributes
        
        #endregion

        #region Properties

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public UserViewModel UserLoged { get; set; }

        #endregion

        #region Constructors

        public MainViewModel()
        {
            // Create observable collections
            Menu = new ObservableCollection<MenuItemViewModel>();

            // Create views
            UserLoged = new UserViewModel();
            
            // Load data
            LoadMenu();
        }

        #endregion

        #region Methods
        public void LoadUser(User user)
        {
            UserLoged.FullName = "XXXXXXXXXX";
            UserLoged.Photo = "https://www.librerianacional.com/custom/include/SugarFields/Fields/ExistayaFile/files/img/20150822033525_la%20chica.png";
            UserLoged.Email = "XXXXXXXXXX";
        }


        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModel
            {
                Icon = "event.png",
                PageName = "Events",
                Title = "Eventos",
            });
            
            Menu.Add(new MenuItemViewModel
            {
                Icon = "key.png",
                PageName = "Logout",
                Title = "Cerrar Sesion",
            });
        }
        #endregion
    }
}
