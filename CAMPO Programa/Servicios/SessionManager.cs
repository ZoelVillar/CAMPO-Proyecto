using BE;
using BE.Permisos;
using BE.Usuarios;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Cache
{
    public class SessionManager 
    {

        private static SessionManager _session;
        public BE_User Usuario { get; set; }
        private static object _lock = new object();

        public static SessionManager getSession
        {
            get
            {
                if(_session == null)
                {
                    _session = new SessionManager();
                }

                return _session;
            }
        } 

        public static void Login(BE_User usuario)
        {
            lock (_lock)
            {
                if(_session == null)
                {
                    _session = new SessionManager();
                    _session.Usuario = usuario;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada");
                }
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }
        }

    }
}
