using System;
using System.Collections.Generic;
using System.Text;

namespace Embarcacion
{
    public class Cliente
    {
        private String nombre;
        private String apellido;
        private String cedula;
        public Cliente(String nombre, String apellido, String cedula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
        }

        public String GetNombre()
        {
            return nombre;
        }

        public String GetApellido()
        {
            return apellido;
        }

        public String GetCedula()
        {
            return cedula;
        }

        public  String toString()
        {
            return "Nombre: " +nombre +", Apellido: "+ apellido +", Cédula: " + cedula;
        }
    }
}
