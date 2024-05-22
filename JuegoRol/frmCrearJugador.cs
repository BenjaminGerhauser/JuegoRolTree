using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class frmCrearJugador : Form
    {
        public frmCrearJugador()
        {
            InitializeComponent();
        }
        clsConexion conexion = new clsConexion();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<string> datosJugador = new List<string>();
            datosJugador.Add(txtNombre.Text);
            datosJugador.Add(txtAtaque.Text);
            datosJugador.Add(txtImagen.Text);
            datosJugador.Add(comboBox1.Text);
            conexion.cargarJugador(datosJugador);
        }
    }
}
