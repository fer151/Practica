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
    public partial class FormInventario : Form
    {
        List<Inventario> inventarioList = new List<Inventario>();
        public FormInventario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Inventario miInvntario = new Inventario();
            miInvntario.Id = int.Parse(txtId.Text);
            miInvntario.Nombre = txtNombre.Text;
            miInvntario.Cantidad = int.Parse(txtCantidad.Text);
            miInvntario.Precio = double.Parse(txtPrecio.Text);
            inventarioList.Add(miInvntario);
            MostrarDatosCapturados();
            MessageBox.Show("Datos insertados");
        }
        public void MostrarDatosCapturados()
        {
            dgProducto.Rows.Clear();
            foreach(Inventario miInventario in inventarioList)
            {
                dgProducto.Rows.Add(miInventario.Id, miInventario.Nombre, miInventario.Cantidad, miInventario.Precio.ToString("C"), miInventario.CalcularTotal());
            }
        }
    }
}
