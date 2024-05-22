using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Mysqlx.Crud;
namespace JuegoRol
{
    internal class clsConexion
    {
        string sql = "";
        DataTable tabla;
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=juegorol;Uid=root;Pwd=;");
        MySqlDataAdapter ada;
        MySqlCommand com;

        public DataTable consultar(string sql)
        {
            tabla = new DataTable();
            ada = new MySqlDataAdapter(sql,con);
            ada.Fill(tabla);
            return tabla;
        }

        public void cargar(TreeView tree,string sql)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void nombre(TreeNode nodoPadre,string type)
        {
            string sql = $"SELECT name FROM monstruario WHERE type = '{type}'";
            tabla = consultar(sql);
            foreach (DataRow r in tabla.Rows)
            {
                nodoPadre.Nodes.Add(r["name"].ToString());
                //caract(nodoPadre, r["name"].ToString());
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
            string sql = $"SELECT size,hit_points,strength,dexterity,constitution,intelligence,wisdom,charisma,xp FROM monstruario WHERE name = '{nombre}'";
            tabla = consultar(sql);
            grilla.DataSource = tabla;
        }
        public JObject api(string mounstruo)
        {
            try
            {
                DataTable TApi = consultar($"SELECT url FROM monstruario WHERE name = '{mounstruo}'");
                string urlApi = TApi.Rows[0]["url"].ToString();
                using (var client = new HttpClient())
                {
                    string url = $"https://www.dnd5eapi.co{urlApi}";
                    client.DefaultRequestHeaders.Clear();
                    var respuesta = client.GetAsync(url).Result;
                    var res = respuesta.Content.ReadAsStringAsync().Result;
                    dynamic r = JObject.Parse(res);
                    string atributesMonster = res;
                    JObject jsonAtributes = JObject.Parse(res);
                    return jsonAtributes;
                    //MessageBox.Show(res);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public string leerApi(JObject atributesMonster) 
        {
            try
            {
                //string atributes = JsonConvert.DeserializeObject(atributesMonster).ToString();
                string urlImage = (string)atributesMonster["image"];
                //MessageBox.Show(urlImage);
                return urlImage;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }
        public void cargarJugador(List<string> datosJugador)
        {
            
            //INSERT INTO `jugador` (`nombre`, `ataque`, `imagen`, `tipo`) VALUES('ogro', 'martillazo', '.....', 'ogro');
            //ada = new MySqlDataAdapter(sql, con);
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=juegorol;Uid=root;Pwd=;"))
                {
                    string nombre = datosJugador[0];
                    string ataque = datosJugador[1];
                    string imagen = datosJugador[2];
                    string tipo = datosJugador[3];
                    conn.Open();

                    string sql = $@"INSERT INTO `jugador` (`nombre`, `ataque`, `imagen`, `tipo`)
                            VALUES ('{nombre}', '{ataque}','{imagen}', '{tipo}');";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: {0}", ex.Message);
            }

        }
    }
}
