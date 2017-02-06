using AppEventos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Infraestructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public LoginViewModel Login { get; set; }
        public EventViewModel Event { get; set; }
        public UserViewModel User { get; set; }

        public InstanceLocator()
        {
            // Singleton
            instance = this;

            Main = new MainViewModel();
            //TODO: TEST ELIMINAR!!!!
            Main.LoadUser(new Models.User());
            Event = new EventViewModel();
            Login = new LoginViewModel();
            User = new UserViewModel();
        }

        #region Singleton

        static InstanceLocator instance;

        public static InstanceLocator GetInstance()
        {
            if (instance == null)
            {
                instance = new InstanceLocator();
            }

            return instance;
        }

        #endregion
    }
}
