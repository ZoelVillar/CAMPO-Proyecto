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
            UserLoginInfo.key_email = "";
            UserLoginInfo.user_name = "";
            UserLoginInfo.user_lastname = "";
            UserLoginInfo.user_password = "";
            UserLoginInfo.user_blocked = false;
            UserLoginInfo.user_attempts = 000;
            UserLoginInfo.id_area = 000;
        }
    }
}
