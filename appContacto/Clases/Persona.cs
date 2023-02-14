using System;

namespace appContacto
{
  internal class Persona
  {
		protected string nombre;
    protected string apellidoPaterno;
    protected string apellidoMaterno;
    protected DateTime? fechaNacimiento;

    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }
    public string ApellidoPaterno
    {
      get { return apellidoPaterno; }
      set { apellidoPaterno = value; }
    }
    public string ApellidoMaterno
    {
      get { return apellidoMaterno; }
      set { apellidoMaterno = value; }
    }
    public DateTime? FechaNacimiento
    {
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

    public int Edad
    {
      get { return (DateTime.Today.Year -  fechaNacimiento.Value.Year ); }
    }
    public string RFC
    {
      get 
      {
        string rfc = "XXXX000000";
        ///
        return rfc; 
      }
    }


    public Persona() 
    {
      nombre = "";
      apellidoPaterno = "";
      apellidoMaterno = "";
      fechaNacimiento = null;
    }
    public Persona(string nombre, string apellidoPaterno, string apellidoMaterno, DateTime? fechaNacimiento)
    {
      this.nombre = nombre ;
      this.apellidoPaterno = apellidoPaterno ;
      this.apellidoMaterno = apellidoMaterno ;
      this.fechaNacimiento = fechaNacimiento;
    }

    public override string ToString()
    {
      return nombre + " " + apellidoPaterno + " " + apellidoMaterno+ " "+ fechaNacimiento.Value.ToString("d");
    }

  }
}
