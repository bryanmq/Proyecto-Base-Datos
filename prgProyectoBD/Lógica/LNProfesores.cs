using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Lógica
{
    public class LNProfesores
    {
        public DALProfesores dalProfesores;

        public LNProfesores()
        {
            dalProfesores = new DALProfesores();
        }

        public List<Profesor> listaProfesores()
        {
            return dalProfesores.listaProfesores();
        }

        public Profesor listaProfesores(int idProfesor)
        {
            return dalProfesores.getProfesor(idProfesor);
        }
        public void eliminarProfesor(int idProfesor)
        {
            dalProfesores.eliminarProfesor(idProfesor);
        }
        public void agregarProfesor(Profesor profesor)
        {
            dalProfesores.agregarProfesor(profesor);
        }

        public void modificarProfesor(Profesor profesor)
        {
            dalProfesores.modificarProfesor(profesor);
        }
    }
}
