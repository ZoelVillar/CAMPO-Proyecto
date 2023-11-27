using AccesosDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class BLL_DigitoVerificador
    {
       DAO_DigitoVerificador daoDigitoVerificador = new DAO_DigitoVerificador();
        public bool UpdateDigitosVerificadores(string tabla)
        {
            return daoDigitoVerificador.UpdateDigitosVerificadores(tabla);
        }

        public bool VerificarDigito(string Tabla)
        {
            return daoDigitoVerificador.VerificarDigito(Tabla);
        }
    }
}
