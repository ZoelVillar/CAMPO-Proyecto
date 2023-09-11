﻿using BE.Idiomas;
using Microsoft.VisualBasic;
using Negocio.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Usuarios.Idiomas
{
    public partial class Vista_Idiomas : Form
    {
        public Vista_Idiomas()
        {
            InitializeComponent();
        }

        BLL_Idioma BLLIdioma; 
        private void Vista_Idiomas_Load(object sender, EventArgs e)
        {
            BLLIdioma = new BLL_Idioma();

            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            
            ActualizarGrilla();
            ActualizarLista();
        }
        private void ActualizarGrilla()
        {
            dataGrid.Rows.Clear();

            var traducciones = BLLIdioma.retornaTraducciones();

            foreach (var traduccion in traducciones)
            {
                dataGrid.Rows.Add(traduccion.id, traduccion.idIdioma.id, traduccion.idIdioma.nombre, traduccion.tagIdioma.id,traduccion.tagIdioma.tag, traduccion.textoTraducido);
            }
        }

        private void ActualizarLista() 
        { 
            listaIdiomas.Items.Clear();

            var idiomas = BLLIdioma.retornaIdiomas();
            listaIdiomas.Items.Add("Todos");

            foreach (var idioma in idiomas)
            {
                listaIdiomas.Items.Add(idioma.nombre);
            }
        }

        private void listaIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaIdiomas.Text == "Todos") { 
                ActualizarGrilla();
            }
            else
            {
                var idioma = BLLIdioma.retornaIdiomas().Find(x => x.nombre == listaIdiomas.Text);


                var traducciones = BLLIdioma.retornaTraduccionesIdioma(new BE_Idioma() { id = idioma.id, nombre = idioma.nombre});

                dataGrid.Rows.Clear();
                foreach (var traduccion in traducciones) 
                { 
                    dataGrid.Rows.Add(traduccion.id, traduccion.idIdioma.id, traduccion.idIdioma.nombre, traduccion.tagIdioma.id, traduccion.tagIdioma.tag, traduccion.textoTraducido);
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre del idioma: ");
            if (!string.IsNullOrEmpty(nombre))
            {
                BE_Idioma idioma = new BE_Idioma() { nombre = nombre };

                if (BLLIdioma.agregarIdioma(idioma))
                {
                    ActualizarGrilla();
                    ActualizarLista();
                    MessageBox.Show("Exito");
                }
                else MessageBox.Show("mal");
            }
            else MessageBox.Show("mal");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaIdiomas.Items.Count != 0)
            {
                if (listaIdiomas.SelectedItems.Count > 0 && listaIdiomas.SelectedItems.Count < 2)
                {
                    var idioma = BLLIdioma.retornaIdiomas().Find(x => x.nombre == listaIdiomas.Text);
                    DialogResult result = MessageBox.Show($"¿Desea eliminar el idioma {idioma.nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (BLLIdioma.eliminarIdioma(idioma.id))
                        {
                            MessageBox.Show("Idioma eliminado con éxito");
                            ActualizarGrilla();
                            ActualizarLista();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un problema actualizando el Idioma");
                        }

                    }

                }
            }
        }

        private void btnEditarTraduccion_Click(object sender, EventArgs e)
        {
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    BE_Idioma idioma = new BE_Idioma() { id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["idiomaID"].Value), nombre = dataGrid.SelectedRows[0].Cells["idiomaNombre"].Value.ToString()};
                    BE_TagIdioma tag = new BE_TagIdioma() { id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["TagID"].Value), tag = dataGrid.SelectedRows[0].Cells["Tag"].Value.ToString()};

                    string texto = Interaction.InputBox($"Ingrese el texto para el idioma {idioma.nombre} y el tag {tag.tag}: ");
                    if(BLLIdioma.editarTraduccion(idioma, tag, texto))
                    {
                        MessageBox.Show("Actualizacion Exitosa");
                    }
                    else MessageBox.Show("Actualizacion Fallida");

                    ActualizarGrilla();
                    ActualizarLista();
                }
                
            }
        }
    }
}