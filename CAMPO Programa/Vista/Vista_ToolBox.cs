using Servicios.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Vista_ToolBox : Form
    {
        public Vista_ToolBox()
        {
            InitializeComponent();
        }

        public bool respuesta;
        private void btnSI_Click(object sender, EventArgs e)
        {
            ClearCache();
            respuesta = true;
            this.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            respuesta= false;
            this.Close();
        }

        public static void ClearCache()
        {
            UserLoginInfo.id_employee = null;
            UserLoginInfo.id_area = null;
            UserLoginInfo.name_user = null;
            UserLoginInfo.language_user = null;
            UserLoginInfo.blocked_user = false;
        }
    }
}
