using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
using Entidades;

namespace DAL
{
    public class DALEstudiantes
    {
        public List<Estudiante> listaEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select carnetEstudiante, nombre, direccion, fechaNacimiento, telefono, email from proyectoABD.tbEstudiante";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Connection = con;
            con.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    try
                    {
                        Estudiante estudiante = new Estudiante();

                        estudiante.carnet = reader.GetString(0);
                        estudiante.nombre = reader.GetString(1);
                        estudiante.direccion = reader.GetString(2);
                        estudiante.fechaNacimiento = DateTime.Parse(reader.GetString(3));
                        estudiante.telefono = reader.GetString(4);
                        estudiante.email = reader.GetString(5);
                        estudiantes.Add(estudiante);

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                con.Close();
            }

            return estudiantes;
        }

        public Estudiante getEstudiante(String carnetEstudiante)
        {
            Estudiante estudiante = new Estudiante();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select carnetEstudiante, nombre, direccion, fechaNacimiento, telefono, email from proyectoABD.tbEstudiante where @carnetEstudiante=carnetEstudiante";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@carnetEstudiante", MySqlDbType.String).Value = carnetEstudiante;
            cmd.Connection = con;
            con.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    try
                    {
                        estudiante.carnet = reader.GetString(0);
                        estudiante.nombre = reader.GetString(1);
                        estudiante.direccion = reader.GetString(2);
                        estudiante.fechaNacimiento = DateTime.Parse(reader.GetString(3));
                        estudiante.telefono = reader.GetString(4);
                        estudiante.email = reader.GetString(5);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                con.Close();
            }

            return estudiante;
        }

        public void eliminarEstudiante(String carnetEstudiante)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from proyectoABD.tbEstudiante where @carnetEstudiante=carnetEstudiante";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@carnetEstudiante", MySqlDbType.String).Value = carnetEstudiante;
            cmd.Connection = con;
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void agregarEstudiante(Estudiante estudiante)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into proyectoABD.tbEstudiante (carnetEstudiante, nombre, direccion, fechaNacimiento, telefono, email) values(@carnetEstudiante, @nombre, @direccion, @fechaNacimiento, @telefono, @email)";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@carnetEstudiante", MySqlDbType.String).Value = estudiante.carnet;
            cmd.Parameters.Add("@nombre", MySqlDbType.String).Value = estudiante.nombre;
            cmd.Parameters.Add("@direccion", MySqlDbType.String).Value = estudiante.direccion;
            cmd.Parameters.Add("@fechaNacimiento", MySqlDbType.Timestamp).Value = estudiante.fechaNacimiento;
            cmd.Parameters.Add("@telefono", MySqlDbType.String).Value = estudiante.telefono;
            cmd.Parameters.Add("@email", MySqlDbType.String).Value = estudiante.email;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteReader();

        }

        public void modificarEstudiante(Estudiante estudiante)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update proyectoABD.tbEstudiante set nombre=@nombre, direccion=@direccion, fechaNacimiento=@fechaNacimiento, telefono=@telefono, email=@email where carnetEstudiante=@carnetEstudiante";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@carnetEstudiante", MySqlDbType.String).Value = estudiante.carnet;
            cmd.Parameters.Add("@nombre", MySqlDbType.String).Value = estudiante.nombre;
            cmd.Parameters.Add("@direccion", MySqlDbType.String).Value = estudiante.direccion;
            cmd.Parameters.Add("@fechaNacimiento", MySqlDbType.Timestamp).Value = estudiante.fechaNacimiento;
            cmd.Parameters.Add("@telefono", MySqlDbType.String).Value = estudiante.telefono;
            cmd.Parameters.Add("@email", MySqlDbType.String).Value = estudiante.email;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
