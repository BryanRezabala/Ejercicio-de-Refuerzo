using System;
using System.Collections.Generic;
using System.Text;

namespace Embarcacion
{
    class Yate:Barco
    {
        private double potencia;
        private int cantCamarotes;
        public Yate(String matricula, double largo, String anioFabricacion, double potencia, int cantCamarotes) : base(matricula, largo, anioFabricacion)
        {
            this.potencia = potencia;
            this.cantCamarotes = cantCamarotes;
        }


        public override double ModuloFuncion()
        {
            return (0.2 * (potencia+ cantCamarotes) * base.getLargo());
        }

        public override String toString()
        {
            return base.toString() +
                "Potencia: " + potencia +
                "\nCantidad Camarotes: " + cantCamarotes+
                "\n Precio Alquiler: " + ModuloFuncion() + "\n";
        }
    }
}
