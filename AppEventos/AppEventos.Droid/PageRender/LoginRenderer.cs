using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using AppEventos.Pages.Providers;
using AppEventos.Droid.PageRender;
using Xamarin.Forms.Platform.Android;
using AppEventos.Helpers;
using AppEventos.Pages;

[assembly: ExportRenderer(typeof(ProviderLoginPage), typeof(LoginRenderer))]
namespace AppEventos.Droid.PageRender
{
    public class LoginRenderer: PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            var activity = this.Context as Activity;

            //Create OauthProviderSetting class with Oauth Implementation.
            OAuthHelper oauth = new OAuthHelper();

            var auth = oauth.LoginWithProvider("Google");

            // After identity provider login completed 
            auth.Completed += (sender, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    //App.CurrentUser = new Models.User();
                    //App.CurrentUser.acces_token = eventArgs.Account.Properties["access_token"];
                    //App.CurrentUser.Account = eventArgs.Account;
                    //App.SaveToken(eventArgs.Account.Properties["access_token"]);

                    ////Open Home Page                    
                    NavigationHelper.SetMainPage(new Models.User());

                }
                else
                {
                    // The user cancelled
                }
            };

            activity.StartActivity(auth.GetUI(activity));
            
        }
    }
}