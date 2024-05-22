using Mysqlx.Crud;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol
{
    internal class clsCombate
    {
        public int hitDice(string dice)
        {
            Random r = new Random();
            string cantidad = "", valorRandom = "";
            int daño = 0;
            string[] dado = dice.Split('d');
           
            for (int i = 0; i < Convert.ToInt32(dado[0]); i++)
            {
                int random = Convert.ToInt32(dado[1]);
                daño += r.Next(1,random);
            }
            return daño;
        }
        public List<string> leerJson(JObject atributes)
        {
            List<string> datos = new List<string>();
            string image = (string)atributes["image"];
            string hit_dice = (string)atributes["hit_dice"];
            string name = (string)atributes["name"];
            string hit_points = (string)atributes["hit_points"];
            datos.Add(name);
            datos.Add(hit_points);
            datos.Add(image);
            datos.Add(hit_dice);
            return datos;
        }
    }
}
