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
        DAO_Bitacora daoBitacora = new DAO_Bitacora();
        public List<BE_BitacoraEventos> retornarBitacoraEventos()
        {
            return daoBitacora.retornarBitacoraEventos();
        }
        public bool registrarBitacoraEvento(string accion, string Modulo, int Accion)
        {
            return daoBitacora.registrarBitacoraEvento(accion, Modulo, Accion);
        }

        public List<BE_BitacoraCambios> retornarBitacoraCambios()
        {
            return daoBitacora.retornarBitacoraCambios();
        }

        public bool restaurarCambio(string reverseSQL)
        {
            return daoBitacora.restaurarCambio(reverseSQL);
        }

    }
}
