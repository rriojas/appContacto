using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appContacto
{
  public partial class Form1 : Form
  {
    Persona p;
    Contacto c;
    public Form1()
    {
      InitializeComponent();

    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      c= new Contacto();
      c.Nombre = txtNombre.Text;
      c.ApellidoPaterno = txtApellidoPaterno.Text;
      c.ApellidoMaterno = txtApellidoMaterno.Text;
      c.FechaNacimiento = dtpFechaNacimiento.Value;
      c.Telefono = txtTelefono.Text;
      c.Correo= txtCorreo.Text;

      MessageBox.Show(c.ToString());
      //p= new Persona();
      //p.Nombre= txtNombre.Text;
      //p.ApellidoPaterno=  txtApellidoPaterno.Text;
      //p.ApellidoMaterno= txtApellidoMaterno.Text;
      //p.FechaNacimiento = dtpFechaNacimiento.Value;

      //MessageBox.Show(p.ToString());
    }
  }
}
