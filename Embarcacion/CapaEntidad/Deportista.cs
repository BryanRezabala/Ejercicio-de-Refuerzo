using System;
using System.Collections.Generic;
using System.Text;

namespace Embarcacion
{
    class Deportista:Barco
    {
        private double potencia;
        public Deportista(String matricula, double largo, String anioFabricacion, double potencia) : base(matricula, largo, anioFabricacion)
        {
            this.potencia = potencia;
        }

        public override double ModuloFuncion()
        {
            return (0.2 * potencia * base.getLargo());
        }

        public override String toString()
        {
            return base.toString() +
                "Potencia: " + potencia +
                "\n Precio Alquiler: " + ModuloFuncion() + "\n";
        }
    }
}
