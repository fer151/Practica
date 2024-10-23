using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Git
{
	internal class Venta
	{
		private string _strNombreProducto;

		public string NombreProducto
		{
			get { return _strNombreProducto; }
			set { _strNombreProducto = value; }
		}

		private int _intCantidadVenta;

		public int CantidadVenta
		{
			get { return _intCantidadVenta; }
			set { _intCantidadVenta = value; }
		}
		private double _dblDescuento;
		private double _dblPrecioUnitario;

		public double PrecioUnitario
		{
			get { return _dblPrecioUnitario; }
			set { _dblPrecioUnitario = value; }
		}

		public double Descuento
		{
			get { return _dblDescuento; }
			set { _dblDescuento = value; }
		}
		private double _dblTotalVenta;

		public double TotalVenta
		{
			get { return _dblTotalVenta; }
			set { _dblTotalVenta = value; }
		}

		public void CalcularVenta()
		{
			TotalVenta = 0;
			TotalVenta = CantidadVenta * PrecioUnitario;
			TotalVenta = TotalVenta - (TotalVenta * Descuento);
			return;
		}
	}
}
