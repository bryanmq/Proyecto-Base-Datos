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
            cmd.CommandText = "Select carnet, nombre, direccion, fechaNacimiento, telefono, email from proyectoABD.tbEstudiante";
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
        /*
        public List<Entidades.Empleado> listaEmpleados()
        {
            List<Entidades.Empleado> empleados = new List<Empleado>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select idEmpleado, nombre, telefono, salario, idDepartamento from  curso.empleado";
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
                        Empleado Empleado = new Empleado();

                        Empleado.idEmpleado = reader.GetInt16(0);
                        Empleado.nombre = reader.GetString(1);
                        Empleado.telefono = reader.GetString(2);
                        Empleado.salario = reader.GetInt16(3);
                        Empleado.idDepartamento = reader.GetInt16(4);

                        empleados.Add(Empleado);

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                con.Close();
            }

            return empleados;
        }

        public List<Entidades.Empleado> listaUnEmpleado(int codigo)
        {
            List<Entidades.Empleado> empleados = new List<Empleado>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select idEmpleado, nombre, telefono, salario, idDepartamento from  curso.empleado where idEmpleado=@codigo";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@codigo", MySqlDbType.Int16).Value = codigo;
            cmd.Connection = con;
            con.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    try
                    {
                        Empleado Empleado = new Empleado();

                        Empleado.idEmpleado = reader.GetInt16(0);
                        Empleado.nombre = reader.GetString(1);
                        Empleado.telefono = reader.GetString(2);
                        Empleado.salario = reader.GetInt16(3);
                        Empleado.idDepartamento = reader.GetInt16(4);

                        empleados.Add(Empleado);

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                con.Close();
            }

            return empleados;
        }

        public void eliminaUnEmpleado(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from curso.empleado where idEmpleado=@codigo";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@codigo", MySqlDbType.Int16).Value = codigo;
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

        public void agregarUnEmpleado(Empleado empleados)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into curso.empleado(nombre, telefono, salario, idDepartamento) values(@nombre, @tel, @sal, @idDep)";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@nombre", MySqlDbType.String).Value = empleados.nombre;
            cmd.Parameters.Add("@tel", MySqlDbType.String).Value = empleados.telefono;
            cmd.Parameters.Add("@sal", MySqlDbType.Int16).Value = empleados.salario;
            cmd.Parameters.Add("@idDep", MySqlDbType.Int16).Value = empleados.idDepartamento;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteReader();

        }

        public Empleado getEmpleado(int codigo)
        {
            Empleado empleado = new Empleado();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select idEmpleado, nombre, telefono, salario, idDepartamento from  curso.empleado where idEmpleado=@codigo";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@codigo", MySqlDbType.Int16).Value = codigo;
            cmd.Connection = con;
            con.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    try
                    {
                        empleado.idEmpleado = reader.GetInt16(0);
                        empleado.nombre = reader.GetString(1);
                        empleado.telefono = reader.GetString(2);
                        empleado.salario = reader.GetInt16(3);
                        empleado.idDepartamento = reader.GetInt16(4);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                con.Close();
            }
            return empleado;
        }

        public void modificar(Empleado emp)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update empleado set nombre=@nombre, telefono=@tel, salario=@sal where idEmpleado=@codigo";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@nombre", MySqlDbType.String).Value = emp.nombre;
            cmd.Parameters.Add("@tel", MySqlDbType.String).Value = emp.telefono;
            cmd.Parameters.Add("@sal", MySqlDbType.Int16).Value = emp.salario;
            cmd.Parameters.Add("@idDep", MySqlDbType.Int16).Value = emp.idDepartamento;
            cmd.Parameters.Add("@codigo", MySqlDbType.Int16).Value = emp.idEmpleado;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
        }
         */
    }
}
