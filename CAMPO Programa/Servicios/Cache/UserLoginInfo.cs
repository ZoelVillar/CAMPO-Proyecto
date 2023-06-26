using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Cache
{
    public static class UserLoginInfo //Static: Los valores son permanentes mientras la app exista
    {
        public static string key_email { get; set; }
        public static string user_name { get; set; }
        public static string user_lastname { get; set; }
        public static string user_password { get; set; }
        public static bool user_blocked { get; set; }
        public static int user_attempts { get; set; }
        public static int id_area { get; set; }
        public static string nombre_area{ get; set; }


    }
}
