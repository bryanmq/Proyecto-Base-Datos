﻿using System;
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
    public class DALCursos
    {


        //***********************************************************
        //Metodo devolver la lista de cursos
        //***********************************************************
        public List<Curso> listaCursos()
        {
            List<Curso> cursos = new List<Curso>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select codigoCurso, descripcion, idProfesor, creditos, aula from proyectoABD.tbCurso";
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
                        Curso curso = new Curso();

                        curso.mCodigoCurso = reader.GetString(0);
                        curso.mDescripcion = reader.GetString(1);
                        curso.mIDProfesor = Convert.ToInt32(reader.GetString(2));
                        curso.mCreditos = Convert.ToInt32(reader.GetString(3));
                        curso.mAula = reader.GetString(4);
                      
                        cursos.Add(curso);

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                con.Close();
            }

            return cursos;
        }

        //*************************************************************
        //METODO SELECT curso
        //*************************************************************
        public Curso getCurso(String codigoCurso)
        {
            Curso curso = new Curso();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select codigoCurso, descripcion, idProfesor, creditos, aula from proyectoABD.tbCurso where @codigoCurso=codigoCurso";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@carnetEstudiante", MySqlDbType.String).Value = codigoCurso;
            cmd.Connection = con;
            con.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    try
                    {
                        curso.mCodigoCurso = reader.GetString(0);
                        curso.mDescripcion = reader.GetString(1);
                        curso.mIDProfesor = Convert.ToInt32(reader.GetString(2));
                        curso.mCreditos = Convert.ToInt32(reader.GetString(3));
                        curso.mAula = reader.GetString(4);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                con.Close();
            }

            return curso;
        }

        //********************************************************************
        //DELETE FROM TBCURSO
        //********************************************************************
        public void eliminarCurso(String codigoCurso)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from proyectoABD.tbCurso where @codigoCurso=codigoCurso";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@codigoCurso", MySqlDbType.String).Value = codigoCurso;
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

        //**********************************************************************
        //insertar en TBCURSO
        //***********************************************************************
        public void insertarCurso(Curso curso)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into proyectoABD.tbCurso (codigoCurso, descripcion, idProfesor, creditos, aula) values(@carnetEstudiante, @nombre, @direccion, @fechaNacimiento, @telefono, @email)";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@codigoCurso", MySqlDbType.String).Value = curso.mCodigoCurso;
            cmd.Parameters.Add("@descripcion", MySqlDbType.String).Value = curso.mDescripcion;
            cmd.Parameters.Add("@idProfesor", MySqlDbType.String).Value = curso.mIDProfesor;
            cmd.Parameters.Add("@creditos", MySqlDbType.Timestamp).Value = curso.mCreditos;
            cmd.Parameters.Add("@aula", MySqlDbType.String).Value = curso.mAula;

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteReader();

        }

        //**************************************************************************
        //Modificacion de Curso;;;;;:::;:;:;:;::::;:;:;;:;;:;:;:;:;:;:;:;:;:;:;:;:;:
        //**************************************************************************
        public void modificarCurso(Curso curso)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update proyectoABD.tbEstudiante set nombre=@nombre, direccion=@direccion, fechaNacimiento=@fechaNacimiento, telefono=@telefono, email=@email where carnetEstudiante=@carnetEstudiante";
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);
            cmd.Parameters.Add("@codigoCurso", MySqlDbType.String).Value = curso.mCodigoCurso;
            cmd.Parameters.Add("@descipcion", MySqlDbType.String).Value = curso.mDescripcion;
            cmd.Parameters.Add("@idProfesor", MySqlDbType.Timestamp).Value = curso.mIDProfesor;
            cmd.Parameters.Add("@creditos", MySqlDbType.String).Value = curso.mCreditos;
            cmd.Parameters.Add("@aula", MySqlDbType.String).Value = curso.mAula;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
