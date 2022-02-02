using System;
using System.Collections.Generic;
using System.Text;

namespace Embarcacion
{
    class Velero:Barco
    {
        private int cantMastiles;
        public Velero(String matricula, double largo, String anioFabricacion, int cantMastiles) :base(matricula, largo, anioFabricacion)
        {
            this.cantMastiles = cantMastiles;
        }

        public override double ModuloFuncion()
        {
            return (0.2 * cantMastiles* base.getLargo());
        }

        public override String toString()
        {
            return base.toString() +
                "Cantidad mastiles: " + cantMastiles+
                "\n Precio Alquiler: " + ModuloFuncion()+"\n";
        }
    }
}
