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
    public partial class FormVentas : Form
    {
        List<Venta> listaVentas = new List<Venta>();
        public double ventastotales = 0;
        public FormVentas()
        {
            InitializeComponent();
        }

        private void btnCapturarVenta_Click(object sender, EventArgs e)
        {
            Venta miVenta1 = new Venta();
            miVenta1.NombreProducto = txtNombreProducto.Text;
            miVenta1.PrecioUnitario = double.Parse(txtPrecioUnitario.Text);
            miVenta1.CantidadVenta = int.Parse(txtCantidad.Text);
            miVenta1.Descuento = double.Parse(txtDescuento.Text.Replace("%","")) * 0.01;
            miVenta1.CalcularVenta();
           
            listaVentas.Add(miVenta1);
            MostrarDatos();
        }

        public void MostrarDatos() 
        {
            ventastotales = 0;
            dgVentas.Rows.Clear();
            
            foreach (Venta miVenta in listaVentas)
            {
                
                ventastotales += miVenta.TotalVenta;
                dgVentas.Rows.Add(miVenta.NombreProducto, miVenta.CantidadVenta, miVenta.PrecioUnitario.ToString("C"), (miVenta.Descuento * 100) + "%",miVenta.TotalVenta.ToString("C"), ventastotales.ToString("C"));
            }
        }
    }
}
