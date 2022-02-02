using System;
using System.Collections.Generic;
using System.Text;

namespace Embarcacion
{
    public class Alquiler
    {
        private String fechaInicial;
        private String fechaFinal;
        private int posAmarre;
        private Barco barco;
        private const double precioFijo = 1.8;
        private int cantDiasOcupacion;
        private double precioAlquiler;
        private Cliente cliente;
 
        public Alquiler(String fechaInicial, String fechaFinal, int posAmarre, Barco barco, Cliente cliente, int cantDiasOcupacion)
        {
            this.fechaInicial = fechaInicial;
            this.fechaFinal = fechaFinal;
            this.posAmarre = posAmarre;
            this.barco = barco;
            this.cantDiasOcupacion = cantDiasOcupacion;
            precioAlquiler = cantDiasOcupacion * barco.ModuloFuncion() * precioFijo;
            this.cliente = cliente;
        }

        public String GetFechaInicial()
        {
            return fechaInicial;
        }

        public String GetFechaFinal()
        {
            return fechaFinal;
        }


        public int GetPosAmarre()
        {
            return posAmarre;
        }

        public Barco GetBarco()
        {
            return barco;
        }

        public Cliente GetCliente()
        {
            return cliente;
        }

        
        public  String toString()
        {
            return "\n\nFecha Inicial: " + fechaInicial +
                "\nFecha Final: " + fechaFinal +
                "\nPosición Amarre: " + posAmarre +
                "\nCantidad Dias Ocupación: " + cantDiasOcupacion +
                "\nCliente: " + cliente.toString() +
                "\nBarco: " + barco.toString();
        }
    }


}
