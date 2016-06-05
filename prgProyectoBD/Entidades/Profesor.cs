using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor
    {
        #region Atributos
        private String _nombre,_direccion, _telefono, _email;
        private int _idProfesor;
        private DateTime _fechaNacimiento;
        #endregion
//***************************************************************************************************
        public Profesor(int idProfesor, String nombre, String direccion, DateTime fechaNacimiento, String telefono, String email)
        {
            this._idProfesor = idProfesor;
            this._nombre = nombre;
            this._direccion = direccion;
            this._fechaNacimiento = fechaNacimiento;
            this._telefono = telefono;
            this._email = email;
        }
 //***************************************************************************************************
        public Profesor()
        {

        }
        //***************************************************************************************************
        public int idProfesor
        {
            get { return _idProfesor; }
            set { _idProfesor = value; }
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
