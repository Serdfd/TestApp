using AppEventos.Helpers;
using AppEventos.Infraestructure;
using AppEventos.Models;
using AppEventos.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppEventos
{
    public partial class App : Application
    {
        #region Attributes
        static string _Token;
        #endregion

        #region Properties
        public static NavigationPage Navigator { get; internal set; }

        public static MasterPage Master { get; internal set; }

        public static User CurrentUser { get; set; }
                
        public static string Token{ get { return _Token; }}

        public static bool IsLoggedIn
        {
            get { return !string.IsNullOrWhiteSpace(_Token); }
        }
        #endregion

        #region Constructors
        public App()
        {
            InitializeComponent();
            

            if (CurrentUser != null)
            {
                var mainViewModel = InstanceLocator.GetInstance().Main;
                mainViewModel.LoadUser(CurrentUser);
                MainPage = new MasterPage();
            }
            else
            {
                MainPage = new LoginPage();
            }
        }
        #endregion

        #region Methods
        public static void SaveToken(string token)
        {
            _Token = token;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static void SuccessfulLoginAction()
        {
            
        }

        #endregion
    }
}
