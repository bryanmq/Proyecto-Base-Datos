using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Lógica
{
    public class LNUsuarios
    {
        public DALUsuarios dalUsuarios;

        public LNUsuarios()
        {
            dalUsuarios = new DALUsuarios();
        }

        public Boolean verifiarUsuario(String usuario, String clave)
        {
            if (dalUsuarios.verificarUsuario(usuario, clave))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fin del metodo verificarUsuario
        
    }
}
