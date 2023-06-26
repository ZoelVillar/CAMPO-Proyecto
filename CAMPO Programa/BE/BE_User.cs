using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_User
    {
        public BE_User()
        {
        }

        public BE_User(string key_email, string user_name, string user_lastname, int id_area)
        {
            this.key_email = key_email;
            this.user_name = user_name;
            this.user_lastname = user_lastname;
            this.id_area = id_area;
        }

        public BE_User(string key_email, bool user_blocked, int user_attempts)
        {
            this.key_email = key_email;
            this.user_blocked = user_blocked;
            this.user_attempts = user_attempts;
        }

        public BE_User(string key_email, string user_name, string user_lastname, string user_password, bool user_blocked, int user_attempts, int id_area, string nombre_area = null)
        {
            this.key_email = key_email;
            this.user_name = user_name;
            this.user_lastname = user_lastname;
            this.user_password = user_password;
            this.user_blocked = user_blocked;
            this.user_attempts = user_attempts;
            this.id_area = id_area;
            this.nombre_area = nombre_area;
        }

        public string key_email { get; set; }
        public string user_name { get; set; }
        public string user_lastname { get; set; }
        public string user_password { get; set; }
        public bool user_blocked { get; set; }
        public int user_attempts { get; set; }
        public int id_area { get; set; }
        public string nombre_area { get; set; }
    }
}
