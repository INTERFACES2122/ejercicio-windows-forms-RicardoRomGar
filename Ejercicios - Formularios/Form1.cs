using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios___Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int datoSeleccionado;

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            checarDatos();
        }

        private void textBox_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checarDatos();
            }
        }

        private void textBox_ApellidoPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checarDatos();
            }
        }

        private void textBox_ApellidoMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checarDatos();
            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            DataView.Rows.Clear();
        }

        //Este codigo lo obtuve de Internet (como una guia o ayuda) y lo adapte a mi formulario, no logre hacer que se ocultaran los datos que no coinciden con los filtros de busqueda, solo se seleccionan.
        private void textBox_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                foreach (DataGridViewRow Row in DataView.Rows)
                {
                    int strFila = Row.Index;
                    string valorNom = Convert.ToString(Row.Cells[0].Value);
                    string valorApPat = Convert.ToString(Row.Cells[1].Value);
                    string valorApMat = Convert.ToString(Row.Cells[2].Value);

                    if (valorNom == this.textBox_Buscar.Text || valorApPat == this.textBox_Buscar.Text || valorApMat == this.textBox_Buscar.Text)
                    {
                        DataView.Rows[strFila].Selected = true;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in DataView.Rows)
                {
                    row.Selected = true;
                }
            }
        }

        private void checarDatos()
        {
            if (textBox_Nombre.Text == "" || textBox_ApellidoPat.Text == "" || textBox_ApellidoMat.Text == "")
            {
                MessageBox.Show("Ningún campo puede quedar vacío", "Error al agregar");
            }
            else
            {
                DataGridViewRow registro = new DataGridViewRow();
                registro.CreateCells(DataView);
                registro.Cells[0].Value = textBox_Nombre.Text;
                registro.Cells[1].Value = textBox_ApellidoPat.Text;
                registro.Cells[2].Value = textBox_ApellidoMat.Text;
                DataView.Rows.Add(registro);

                textBox_Nombre.Clear();
                textBox_ApellidoPat.Clear();
                textBox_ApellidoMat.Clear();
            }
        }
    }
}
