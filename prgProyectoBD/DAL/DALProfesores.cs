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
    public class DALProfesores
    {
        public List<Profesor> listaProfesores()
        {
            List<Profesor> profesores = new List<Profesor>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select idProfesor,nombre, direccion, fechaNacimiento, telefono, email from proyectoABD.tbProfesor";
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
                        Profesor profesor = new Profesor();
                        profesor.idProfesor = reader.GetInt32(0);
                        profesor.nombre = reader.GetString(1);
                        profesor.direccion = reader.GetString(2);
                        profesor.fechaNacimiento = DateTime.Parse(reader.GetString(3));
                        profesor.telefono = reader.GetString(4);
                        profesor.email = reader.GetString(5);
                        profesores.Add(profesor);

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                con.Close();
            }

            return profesores;
        }
        //***************************************************************************************************
        public Profesor getProfesor(int idProfesor)
        {
            Profesor profesor = new Profesor();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select idProfesor,nombre, direccion, fechaNacimiento, telefono, email from proyectoABD.tbProfesor where @idProfesor=idProfesor";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@idProfesor", MySqlDbType.String).Value = idProfesor;
            cmd.Connection = con;
            con.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    try
                    {
                        profesor.idProfesor = reader.GetInt32(0);
                        profesor.nombre = reader.GetString(1);
                        profesor.direccion = reader.GetString(2);
                        profesor.fechaNacimiento = DateTime.Parse(reader.GetString(3));
                        profesor.telefono = reader.GetString(4);
                        profesor.email = reader.GetString(5);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                con.Close();
            }

            return profesor;
        }
        //***************************************************************************************************
        public void eliminarProfesor(int idProfesor)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from proyectoABD.tbProfesor where @idProfesor=idProfesor";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@idProfesor", MySqlDbType.String).Value = idProfesor;
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
        //***************************************************************************************************
        public void agregarProfesor(Profesor profesor)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into proyectoABD.tbProfesor (idProfesor, nombre, direccion, fechaNacimiento, telefono, email) values(@idProfesor, @nombre, @direccion, @fechaNacimiento, @telefono, @email)";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@idProfesor", MySqlDbType.String).Value = profesor.idProfesor;
            cmd.Parameters.Add("@nombre", MySqlDbType.String).Value = profesor.nombre;
            cmd.Parameters.Add("@direccion", MySqlDbType.String).Value = profesor.direccion;
            cmd.Parameters.Add("@fechaNacimiento", MySqlDbType.Timestamp).Value = profesor.fechaNacimiento;
            cmd.Parameters.Add("@telefono", MySqlDbType.String).Value = profesor.telefono;
            cmd.Parameters.Add("@email", MySqlDbType.String).Value = profesor.email;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteReader();

        }
        //***************************************************************************************************
        public void modificarProfesor(Profesor profesor)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update proyectoABD.tbProfesor set nombre=@nombre, direccion=@direccion, fechaNacimiento=@fechaNacimiento, telefono=@telefono, email=@email where idProfesor=@idProfesor";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@idProfesor", MySqlDbType.String).Value = profesor.idProfesor;
            cmd.Parameters.Add("@nombre", MySqlDbType.String).Value = profesor.nombre;
            cmd.Parameters.Add("@direccion", MySqlDbType.String).Value = profesor.direccion;
            cmd.Parameters.Add("@fechaNacimiento", MySqlDbType.Timestamp).Value = profesor.fechaNacimiento;
            cmd.Parameters.Add("@telefono", MySqlDbType.String).Value = profesor.telefono;
            cmd.Parameters.Add("@email", MySqlDbType.String).Value = profesor.email;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
        }
        //***************************************************************************************************
        public void buscarProfesor(int idProfesor)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select from proyectoABD.tbProfesor where @idProfesor=idProfesor";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@idProfesor", MySqlDbType.String).Value = idProfesor;
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
    }
}
