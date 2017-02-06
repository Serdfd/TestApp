using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;

namespace AppEventos.Models
{
    public class User
    {
        public GoogleInfo UserInfo { get; set; }
        public string acces_token { get; set; }
        public Account Account { get; set; }
    }
}
