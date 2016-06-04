using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {

        #region Atributos
        private string _nombre, _clave;
        private int _estado, _idUsuario;
        #endregion


        public Usuario(int idUsuario, string nombre, string clave, int estado )
        {
            this._idUsuario = idUsuario;
            this._nombre = nombre;
            this._clave = clave;
            this._estado = estado;
        }
        public Usuario()
        {

        }

        public int idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public int estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        
    }
}
