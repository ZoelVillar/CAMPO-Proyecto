using AccesosDatos.Bitacora;
using BE.Biatcora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Bitacora
{
    public class BLL_BitacoraCambiosProducto
    {
        DAO_BitacoraCambiosProducto daoBitacoraCambiosProducto = new DAO_BitacoraCambiosProducto();
        public void GuardarBitacoraCambio(BE_BitacoraCambiosProducto bita)
        {
            daoBitacoraCambiosProducto.GuardarBitacoraCambio(bita);
        }

        public List<BE_BitacoraCambiosProducto> RetornarBitacora()
        {
            return daoBitacoraCambiosProducto.RetornarBitacora();
        }

        public void ActivarCambio(BE_BitacoraCambiosProducto bitacora)
        {
            daoBitacoraCambiosProducto.ActivarCambio(bitacora);
        }

    }
}
