using Newtonsoft.Json.Linq;
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
    public partial class frmCombate : Form
    {
        public frmCombate()
        {
            InitializeComponent();
        }
        clsConexion conexion = new clsConexion();
        clsCombate combate = new clsCombate();
        List<string> datos = new List<string>();
        string hit_diceEnemigo = "";
        private void frmCombate_Load(object sender, EventArgs e)
        {
            JObject atributesJson = conexion.api("Aboleth");
            datos = combate.leerJson(atributesJson);
            picEnemigo.ImageLocation = $"https://www.dnd5eapi.co{datos[2]}";
            lblNombreEnemigo.Text = datos[0];
            progressEnemigo.Maximum = Convert.ToInt32(datos[1]);
            progressEnemigo.Value = Convert.ToInt32(datos[1]);
            hit_diceEnemigo = datos[3];
        }

        private void picEnemigo_Click(object sender, EventArgs e)
        {
            int daño = combate.hitDice(hit_diceEnemigo);
            progressEnemigo.Value -= daño;
        }
    }
}
