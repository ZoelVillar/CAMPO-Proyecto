using Servicios.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Cache;

namespace Servicios.Validaciones
{
    public class EncriptarContraseña
    {
        public string Encriptar(string contraseña)
        {
            var Hash = BCrypt.Net.BCrypt.HashPassword(contraseña, 12);
            return Hash;
        }

        public bool Validar(string contraseña)
        {
            //bool isPasswordValid = BCrypt.Net.BCrypt.Verify(contraseña, UserLoginInfo.password_user);
            //return isPasswordValid;
            return true;
        }
    }
}
