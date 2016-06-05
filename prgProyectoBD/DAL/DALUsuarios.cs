using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace DAL
{
    public class DALUsuarios
    {
        public Boolean verificarUsuario(String nombre, String clave)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select idUsuario from proyectoABD.tbUsuario where @nombre=nombre AND @clave=clave";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@nombre", MySqlDbType.String).Value = nombre;
            cmd.Parameters.Add("@clave", MySqlDbType.String).Value = clave;
            cmd.Connection = con;
            con.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return true;
                }
                con.Close();
            }
            return false;

        }//Fin del metodo verificarUsuario
    }
}
