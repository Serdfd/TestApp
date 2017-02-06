using AppEventos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;

namespace AppEventos.Helpers
{
    public class GoogleInfoHelper
    {
        public async void GetGoogleInfo(object account)
        {
            var request = new OAuth2Request("GET", new Uri(ConstantsHelper.USER_INFO_URL), null, (Account)account);
            var response = await request.GetResponseAsync();
            if (response != null)
            {
                App.CurrentUser.UserInfo = JsonConvert.DeserializeObject<GoogleInfo>(response.GetResponseText());
            }
        }
    }
}
