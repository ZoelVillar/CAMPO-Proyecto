using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesosDatos;
using BE;
using BE.Usuarios;
using Servicios.Cache;

namespace Negocio
{
    public class BLL_User
    {
        Dao_User DaoUser = new Dao_User();

        public bool CrearUsuario(BE_User usuario)
        {
            return DaoUser.CrearUsuario(usuario);
        }

        public bool ModificarUsuario(BE_User usuario)
        {
            return DaoUser.ModificarUsuario(usuario);
        }
        public bool ActualizarContraseña(BE_User usuario)
        {
            return DaoUser.ActualizarContraseña(usuario);
        }

        public bool EditarRestricciones(BE_User usuario)
        {
            return DaoUser.EditarRestricciones(usuario);
        }

        public bool LoginUser(string user)
        {
            return DaoUser.Login(user);
        }

        public List<BE_User> ObtenerUsuarios()
        {
            return DaoUser.ObtenerUsuarios();
        }

        public BE_User retornaUsuario(string usuario)
        {
            return DaoUser.retornaUsuario(usuario);
        }

        public bool userExist(string name_user)
        {
            return DaoUser.userExist(name_user);
        }

        public void CloseConnection()
        {
            DaoUser.closeConnection();
        }

        public bool comprobarConexion()
        {
            return DaoUser.comprobarConexion();
        }
    }
}
