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
    public class BLL_Bitacora
    {
        DAO_BitaciraEventos daoBiEventos = new DAO_BitaciraEventos();
        public List<BE_BitacoraEventos> retornarBitacoraEventos()
        {
            return daoBiEventos.retornarBitacoraEventos();
        }

        public List<BE_BitacoraCambios> retornarBitacoraCambios()
        {
            return daoBiEventos.retornarBitacoraCambios();
        }

        public bool restaurarCambio(string reverseSQL)
        {
            return daoBiEventos.restaurarCambio(reverseSQL);
        }

            public bool guardarBitacora()
        {
            return true;
        }
    }
}
