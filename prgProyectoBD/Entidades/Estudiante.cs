using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        #region Atributos
        private String _carnet, _nombre, _direccion, _telefono, _email;
        private DateTime _fechaNacimiento;
        #endregion

        public String carnet
        {
            get { return _carnet; }
            set { _carnet = value; }
        }

        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public String telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public String email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
