using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;

namespace AppEventos.Helpers
{
    public class OAuthHelper
    {
        public OAuth2Authenticator LoginWithProvider(string Provider)
        {
            OAuth2Authenticator auth = null;
            switch (Provider)
            {
                case "Google":
                    {
                        auth = new OAuth2Authenticator(
                                    // For Google login, for configure refer https://code.msdn.microsoft.com/Register-Identity-Provider-41955544
                                    ConstantsHelper.CLIENT_ID,
                                    ConstantsHelper.CLIENT_SECRET,
                                    // Below values do not need changing
                                    ConstantsHelper.SCOPE,
                                    new Uri(ConstantsHelper.AUTHORIZE_URL),
                                    new Uri(ConstantsHelper.REDIRECT_URL),// Set this property to the location the user will be redirected too after successfully authenticating
                                    new Uri(ConstantsHelper.ACCESS_TOKEN_URL)
                                    );

                        break;
                    }

            }
            return auth;
        }
    }
}
