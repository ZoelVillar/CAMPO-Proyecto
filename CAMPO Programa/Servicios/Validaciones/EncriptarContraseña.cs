using Servicios.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Servicios.Validaciones
{
    public class EncriptarContraseña
    {
        public string Encriptar(string contraseña)
        {
            var Hash = BCrypt.Net.BCrypt.HashPassword(contraseña, 12);
            return Hash;
        }

        public bool ValidarContraseñaUsuario(string contraseñaX, string contraseñaY)
        {
            return BCrypt.Net.BCrypt.Verify(contraseñaX, contraseñaY);
        }
    }
}
