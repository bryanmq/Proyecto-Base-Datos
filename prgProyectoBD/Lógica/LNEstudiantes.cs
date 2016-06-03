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
        private DALEstudiantes dalEstudiantes;

        public LNEstudiantes()
        {
            dalEstudiantes = new DALEstudiantes();
        }

        public List<Estudiante> listarEmpleados()
        {
            return dalEstudiantes.listaEstudiantes();
        }
    }
}
