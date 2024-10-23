using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Git
{
    internal class Inventario
    {
		private int _intId;

		public int Id
		{
			get { return _intId; }
			set { _intId = value; }
		}
		private string _strNombre;

		public string Nombre
		{
			get { return _strNombre; }
			set { _strNombre = value; }
		}
		private int _intCantidad;

		public int Cantidad
		{
			get { return _intCantidad; }
			set { _intCantidad = value; }
		}
		private double _dblPrecio;

		public double Precio
		{
			get { return _dblPrecio; }
			set { _dblPrecio = value; }
		}
		public double CalcularTotal()
		{
			return (Precio*Cantidad);
		}
	}
}
