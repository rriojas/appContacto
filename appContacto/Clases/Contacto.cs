using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appContacto
{
  internal class Contacto : Persona
  {
		private string telefono;
    private string correo;

    public string Telefono
    {
      get { return telefono; }
      set { telefono = value.Replace(" ", "").Replace(".","").Substring(0,10); }
    }
    public string Correo
		{
			get { return correo; }
			set { correo = value; }
		}

    public Contacto(): base()
    {
      correo = string.Empty;
      telefono= string.Empty;
    }
    public Contacto(string nombre,string apellidoPaterno, string apellidoMaterno, DateTime? fechaNacimiento, string telefono, string correo): base(nombre,apellidoPaterno,apellidoMaterno,fechaNacimiento )
    {
      this.correo = correo;
      this.telefono = telefono;
    }

    public override string ToString()
    {
      return base.ToString()+ " "+ telefono+" "+ correo ;
        // nombre + " " + apellidoPaterno + " " + apellidoMaterno;
    }

  }
}
