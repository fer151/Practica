using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Git
{
    internal class Cliente
    {
		private string _strNombre;

		public string Nombre
		{
			get { return _strNombre; }
			set { _strNombre = value; }
		}
		private DateTime _dtnFechaNacimiento;

		public DateTime FechaNacimiento
		{
			get { return _dtnFechaNacimiento; }
			set { _dtnFechaNacimiento = value; }
		}
		private string _strGenero;

		public string Genero
		{
			get { return _strGenero; }
			set { _strGenero = value; }
		}
		private string _strTelefono;

		public string Telefono
		{
			get { return _strTelefono; }
			set { _strTelefono = value; }
		}

	}
}
