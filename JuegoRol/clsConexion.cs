using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace JuegoRol
{
    internal class clsConexion
    {
        string sql = "";
        DataTable tabla;
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=juegorol;Uid=root;Pwd=;");
        MySqlDataAdapter ada;
        MySqlCommand com;

        private DataTable consultar(string sql)
        {
            tabla = new DataTable();
            ada = new MySqlDataAdapter(sql,con);
            ada.Fill(tabla);
            return tabla;
        }
        public void cargar(TreeView tree,string sql)
        {
            tree.Nodes.Clear();
            tabla = consultar(sql);
            TreeNode nodoRaiz = tree.Nodes.Add("Types");
            foreach (DataRow r in tabla.Rows)
            {
                TreeNode nodoHijo = nodoRaiz.Nodes.Add(r["type"].ToString());
                string type = r["type"].ToString();
                nombre(nodoHijo, type);

            }
        }
        private void nombre(TreeNode nodoPadre,string type)
        {
            string sql = $"SELECT name FROM monstruario WHERE type = '{type}'";
            tabla = consultar(sql);
            foreach (DataRow r in tabla.Rows)
            {
                nodoPadre.Nodes.Add(r["name"].ToString());
                caract(nodoPadre, r["name"].ToString());
            }

        }
        private void caract(TreeNode nodoPadre, string nombre)
        {
            string sql = $"SELECT * FROM monstruario WHERE name = '{nombre}'";
            tabla = consultar(sql);
            foreach (DataRow r in tabla.Rows)
            {
                nodoPadre.Nodes.Add(r["size"].ToString());
                nodoPadre.Nodes.Add(r["hit_points"].ToString());
                nodoPadre.Nodes.Add(r["strength"].ToString());
                nodoPadre.Nodes.Add(r["dexterity"].ToString());
                nodoPadre.Nodes.Add(r["constitution"].ToString());
                nodoPadre.Nodes.Add(r["intelligence"].ToString());
                nodoPadre.Nodes.Add(r["wisdom"].ToString());
                nodoPadre.Nodes.Add(r["charisma"].ToString());
                nodoPadre.Nodes.Add(r["xp"].ToString());
            }
            
        }
        public void caracteristicas(DataGridView grilla, string nombre)
        {
            string sql = $"SELECT * FROM monstruario WHERE name = '{nombre}'";
            tabla = consultar(sql);
            grilla.DataSource = tabla;
        }
    }
}
