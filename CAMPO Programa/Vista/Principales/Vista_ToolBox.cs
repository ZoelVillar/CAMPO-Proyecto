﻿using Negocio;
using Negocio.Bitacora;
using Servicios.Cache;
using Servicios.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Usuarios.Idiomas;

namespace Vista
{
    public partial class Vista_ToolBox : Form, IObserver
    {
        public Vista_ToolBox()
        {
            InitializeComponent();
        }

        private void Vista_ToolBox_Load(object sender, EventArgs e)
        {
            IdiomasStatic.Observer.AgregarObservador(this);
            Actualizar();
        }

        public bool respuesta;
        private void btnSI_Click(object sender, EventArgs e)
        {


            BLL_Bitacora bitacora = new BLL_Bitacora();
            if(bitacora.registrarBitacoraEvento($"Usurio Logout", this.GetType().Name.Substring("Vista_".Length), 3))
            {
                respuesta = true;
                this.Close();
                BLL_User User = new BLL_User();

                SessionManager.Logout();
                User.CloseConnection();
            }
            else
            {
                respuesta = true;
                this.Close();
                BLL_User User = new BLL_User();

                SessionManager.Logout();
                User.CloseConnection();
            }

        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            respuesta= false;
            this.Close();
        }


        public void Actualizar()
        {
            IdiomasTraduccionServicios asd = new IdiomasTraduccionServicios();
            asd.CambiarIdiomaEnFormulario(this);
        }
    }
}
