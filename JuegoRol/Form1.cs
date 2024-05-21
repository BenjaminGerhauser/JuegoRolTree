using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System.Net;

namespace JuegoRol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TreeView treeViewX;

            clsConexion con = new clsConexion();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            con.cargar(treeView1, "SELECT type FROM monstruario GROUP BY type");
            //treeViewX = new TreeView();

            //Controls.Add(treeViewX);

            //// Crear un nodo raíz
            //TreeNode nodoRaiz = treeViewX.Nodes.Add("Root Node");

            //// Crear un nodo secundario
            //TreeNode nodoHijo = nodoRaiz.Nodes.Add("Child Node");

            //TreeNode nodoRaiz2 = treeViewX.Nodes.Add("hacker bordiga");

            //TreeNode nodoHijo2 = nodoRaiz2.Nodes.Add("Child Node");
            //TreeNode nodoHijo3 = nodoRaiz2.Nodes.Add("Child Node");

            //TreeNode nodoHijo4 = nodoHijo3.Nodes.Add("Child Node");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show("Nodo seleccionado: " + e.Node.Text);
        }


        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            con.caracteristicas(dataGridView1, e.Node.Text);
            JObject atributesMonster = con.api(e.Node.Text);
            string urlImage = con.leerApi(atributesMonster);
            if (urlImage != "") pictureBox1.ImageLocation = $"https://www.dnd5eapi.co{urlImage}";
        }
    }
}