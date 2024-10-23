using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Git
{
    public partial class FormClientes : Form
    {
        List<Cliente> listaCliente = new List<Cliente>();
        public FormClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Cliente miCliente = new Cliente();
            miCliente.Nombre = txtNombre.Text;
            miCliente.FechaNacimiento = dgtFecha.Value;
            miCliente.Genero = cboGenero.Text;
            miCliente.Telefono = txtTelefono.Text;
            listaCliente.Add(miCliente);
            MostrarDatos();
            MessageBox.Show("Datos insertados");
        }   
        public void MostrarDatos()
        {
            dgCliente.Rows.Clear();
            foreach (Cliente miCliente in listaCliente)
            {
                dgCliente.Rows.Add(miCliente.Nombre, miCliente.FechaNacimiento, miCliente.Genero, miCliente.Telefono);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
