using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        #region Atributos
        private String codigoCurso, descripcion, aula;
        private int idProfesor, creditos;
        #endregion

        #region Constructores
        public Curso(String codigoCurso, String descripcion, int idProfesor, int creditos, String aula)
        {
            this.codigoCurso = codigoCurso;
            this.descripcion = descripcion;
            this.idProfesor = idProfesor;
            this.creditos = creditos;
            this.aula = aula;
        }

        public Curso()
        {
            this.codigoCurso = "";
            this.descripcion = "";
            this.idProfesor = 0;
            this.creditos = 0;
            this.aula = "";
        }
        #endregion

        #region Metodos
        public String mCodigoCurso
        {
            set { codigoCurso = value; }
            get { return codigoCurso; }
        }

        public String mDescripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public int mIDProfesor
        {
            set { idProfesor = value; }
            get { return idProfesor; }
        }

        public int mCreditos
        {
            set { creditos = value; }
            get { return creditos; }
        }

        public String mAula
        {
            set { aula = value; }
            get { return aula; }
        }

        #endregion
    }
}
