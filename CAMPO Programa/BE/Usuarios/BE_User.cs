using BE.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Usuarios
{
    public class BE_User
    {
        public BE_User()
        {
        }

        public BE_User(string key_email, string user_name, string user_lastname, int idperfil)
        {
            this.key_email = key_email;
            this.user_name = user_name;
            this.user_lastname = user_lastname;
            this.id_perfil = idperfil;
        }

        public BE_User(string key_email, bool user_blocked, int user_attempts)
        {
            this.key_email = key_email;
            this.user_blocked = user_blocked;
            this.user_attempts = user_attempts;
        }

        public BE_User(string key_email, string user_name, string user_lastname, string user_password, bool user_blocked, int user_attempts, int id_perfil, BE_PermisoCompuesto nombreperfil = null)
        {
            this.key_email = key_email;
            this.user_name = user_name;
            this.user_lastname = user_lastname;
            this.user_password = user_password;
            this.user_blocked = user_blocked;
            this.user_attempts = user_attempts;
            this.id_perfil = id_perfil;
            this.nombre_perfil = nombreperfil;
        }

        public string key_email { get; set; }
        public string user_name { get; set; }
        public string user_lastname { get; set; }
        public string user_password { get; set; }
        public bool user_blocked { get; set; }
        public int user_attempts { get; set; }
        public int id_perfil { get; set; }
        public BE_PermisoCompuesto nombre_perfil { get; set; }
    }
}
