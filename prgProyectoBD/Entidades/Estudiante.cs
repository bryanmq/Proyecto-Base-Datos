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
        private String carnet, nombre, direccion, fechaNacimiento, telefono, email;
        #endregion

        public Estudiante()
        {
            this.carnet = "";
            this.nombre = "";
            this.direccion = "";
            this.fechaNacimiento = "";
            this.telefono = "";
            this.email = "";
        }
        public Estudiante(String nombre, String direccion, String fechaNacimiento, String telefono, String email)
        {

        }

        public void setCarnet(String carnet)
        {
            this.carnet = carnet;
        }

        public String getCarnet()
        {
            return this.carnet;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String getDireccion()
        {
            return this.direccion;
        }

        public void setFechaNac(String fechaNac)
        {
            this.fechaNacimiento = fechaNac;
        }

        public String getFechaNac()
        {
            return this.fechaNacimiento;
        }

        public void seTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public String getTelefono()
        {
            return this.telefono;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getEmail()
        {
            return this.email;
        }

    }
}
