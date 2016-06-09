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
        private int _codigoUsuario;
        private DateTime _fechaNacimiento;
        #endregion
//***************************************************************************************************
        public Profesor(int codigoUsuario, String nombre, DateTime fechaNacimiento, String direccion, String telefono, String email)
        {
            this._codigoUsuario = codigoUsuario;
            this._nombre = nombre;
            this._fechaNacimiento = fechaNacimiento;
            this._direccion = direccion;
            this._telefono = telefono;
            this._email = email;
        }
 //***************************************************************************************************
        public Profesor()
        {

        }
        //***************************************************************************************************
        public int codigoUsuario
        {
            get { return _codigoUsuario; }
            set { _codigoUsuario = value; }
        }


        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public String direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
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
