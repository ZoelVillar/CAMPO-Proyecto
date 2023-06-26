using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesosDatos;
using BE;


namespace Negocio
{
    public class BLL_Areas
    {
        Dao_Areas DaoAreas = new Dao_Areas();

        public bool retornaAreas()
        {
            return DaoAreas.retornaAreas();
        }
    }
}
