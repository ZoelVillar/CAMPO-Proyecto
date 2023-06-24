using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Cache
{
    public static class UserLoginInfo //Static: Los valores son permanentes mientras la app exista
    {
        public static string id_employee { get; set; }
        public static string id_area { get; set; }
        public static string name_user { get; set; }
        public static string language_user { get; set; }
        public static string password_user { get; set; }
        public static bool blocked_user { get; set; }


    }
}
