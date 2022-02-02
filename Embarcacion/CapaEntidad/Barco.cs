using System;
using System.Collections.Generic;
using System.Text;

namespace Embarcacion
{
    public class Barco
    {
        String matricula;
        double largo;
        String anioFabricacion;
        public Barco(String matricula, double largo, String anioFabricacion)
        {
            this.matricula = matricula;
            this.largo = largo;
            this.anioFabricacion = anioFabricacion;
        }

        public double getLargo()
        {
            return largo;
        }

        public virtual double ModuloFuncion()
        {
            return 1;
        }

        public virtual String toString()
        {
            return "Matricula" + matricula +
                "\nlargo" + largo +
                "\nAño Fabricación: " + anioFabricacion+"\n";
        }
    }
}
