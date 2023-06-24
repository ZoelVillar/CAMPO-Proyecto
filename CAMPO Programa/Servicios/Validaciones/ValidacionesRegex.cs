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
        public bool validarUserName(string nombre)
        {
            string pattern = @"^(?!.*\s{2})[a-zA-Z][a-zA-Z0-9_-]*(?:\s[a-zA-Z0-9_-]+)*$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(nombre);
        }

        public bool validarContraseña(string nombre)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d\\s]).{8,20}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(nombre);
        }

    }
}
