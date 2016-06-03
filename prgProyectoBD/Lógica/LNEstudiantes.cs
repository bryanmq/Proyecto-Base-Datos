using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Lógica
{
    public class LNEstudiantes
    {
        public DALEstudiantes dalEstudiantes;

        public LNEstudiantes()
        {
            dalEstudiantes = new DALEstudiantes();
        }

        public List<Estudiante> listaEstudiantes()
        {
            return dalEstudiantes.listaEstudiantes();
        }

        public Estudiante listaEstudiante(String codigo)
        {
            return dalEstudiantes.getEstudiante(codigo);
        }

        public void eliminarEstudiante(String carnet)
        {
            dalEstudiantes.eliminarEstudiante(carnet);
        }

        public void agregarEstudiante(Estudiante estudiante)
        {
            dalEstudiantes.agregarEstudiante(estudiante);
        }

        public void modificarEstudiante(Estudiante estudiante)
        {
            dalEstudiantes.modificarEstudiante(estudiante);
        }
    }
}
