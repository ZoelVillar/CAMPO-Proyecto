using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Servicios.Validaciones
{
    public class ValidarRegex
    {
        public bool validarEmail(string email)
        {
            string emailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(@"
                + @"([a-z0-9-]+(?!-)\.)+[a-z]{2,6}$)";
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        public bool validarContraseña(string contraseña)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d\\s]).{8,20}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(contraseña);
        }

    }
}
