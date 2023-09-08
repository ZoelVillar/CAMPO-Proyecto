using AccesosDatos.Bitacora;
using AccesosDatos.Inventario;
using BE.Biatcora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Bitacora
{
    public class BLL_BitacoraEventos
    {
        DAO_BitaciraEventos daoBiEventos = new DAO_BitaciraEventos();
        public List<BE_BitacoraEventos> retornarBitacora()
        {
            return daoBiEventos.retornarBitacora();
        }

        public bool guardarBitacora()
        {
            return true;
        }
    }
}
