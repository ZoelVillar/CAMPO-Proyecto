using Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Principales.Administracion
{
    public partial class Vista_DigitoVerificador : Form
    {
        public Vista_DigitoVerificador()
        {
            InitializeComponent();
        }
        BLL_DigitoVerificador BLL_DigitoVerificador;
        private void Vista_DigitoVerificador_Load(object sender, EventArgs e)
        {
            BLL_DigitoVerificador = new BLL_DigitoVerificador();
        }

        private void btnActualizarDigitos_Click(object sender, EventArgs e)
        {
            BLL_DigitoVerificador.UpdateDigitosVerificadores("Users");
            BLL_DigitoVerificador.UpdateDigitosVerificadores("Venta");
            BLL_DigitoVerificador.UpdateDigitosVerificadores("Compra");
            BLL_DigitoVerificador.UpdateDigitosVerificadores("Producto");

            Vista_Principal mainMenu = new Vista_Principal();
            mainMenu.Show();
            this.Hide();
        }

        private void btnRealizarRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "SQL SERVER database backup files|*.bak";
            opn.Title = "Database Restore";
            if (opn.ShowDialog() == DialogResult.OK)
            {
                BLL_Backup backup = new BLL_Backup();
                if (backup.RestaurarBackup(opn.FileName))
                {
                    MessageBox.Show("Restore de la base de datos generado exitosamente");
                    Vista_Principal mainMenu = new Vista_Principal();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hubo un error restaurando la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
