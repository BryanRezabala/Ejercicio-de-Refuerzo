using System;
using System.Collections.Generic;
using System.Text;

namespace Embarcacion
{
    class Principal
    {
        static void Main(string[] args)
        {
            List<Alquiler> alquileres = new List<Alquiler>();
            List<Alquiler> alquileresHoy;
            Cliente cliente1 = new Cliente("Joanthan","Ignacio Huapaya","435465876");
            Cliente cliente2 = new Cliente("Pedro", "Rojas Retamozo", "65875687");
            Cliente cliente3 = new Cliente("Maria", "Valverde Barreto", "34542345");
            Cliente cliente4 = new Cliente("Juana", "Espinoza Sevillano", "23546788");

            //uso del polimorfismo
            Barco barco1 = new Yate("GH-435",13.4,"04/05/1990",45.3,4);
            Barco barco2 = new Deportista("GH-123", 15.7, "05/09/2000", 55.3);
            Barco barco3= new Velero("GH-433", 12.3, "05/11/2004", 5);
            Barco barco4 = new Yate("GH-125", 12.1, "02/11/1995", 29.3, 3);

            //lista de alquileres
            alquileres.Add(new Alquiler("02/02/2022", "07/02/2022", 3, barco1, cliente1, 3));
            alquileres.Add(new Alquiler("02/02/2022", "06/02/2022", 1, barco2, cliente2, 2));
            alquileres.Add(new Alquiler("02/02/2022", "05/02/2022", 2, barco3, cliente3, 1));
            alquileres.Add(new Alquiler("02/02/2022", "08/02/2022", 5, barco4, cliente4, 4));
            alquileres.Add(new Alquiler("10/02/2022", "13/02/2022", 2, barco1, cliente1, 1));
            alquileres.Add(new Alquiler("11/02/2022", "13/02/2022", 1, barco2, cliente2, 1));

            int opcion;
            int pos = 0;
            do
            {
                
                    opcion = menu();
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese cédula del cliente: ");
                            String cedula = Console.ReadLine();
                            pos = mostrarAlquiler(alquileres, cedula);
                            if (pos == -1)
                            {
                                Console.Write("Cédula de cliente no encontrado\n");
                            }
                            else
                            {
                                Console.Write(alquileres[pos].toString() + "\n");
                            }
                            break;
                        case 2:
                            Console.Write("Ingrese fecha: ");
                            String fecha = Console.ReadLine();
                            alquileresHoy = mostrarAlquileresFecha(alquileres, fecha);
                            foreach (Alquiler e in alquileresHoy)
                            {
                                Console.Write($"{e.toString()} ");
                            }
                            break;
                        case 3:
                            alquileresHoy = mostrarAlquileres(alquileres);
                            foreach (Alquiler e in alquileresHoy)
                            {
                                Console.Write($"{e.toString()} ");
                            }
                            break;
                        case 4: Console.Write("Hasta luego, que tenga buen día\n"); break;
                        default: Console.Write("Opción incorrecta vuelva ingresar\n"); break;
                    }
               
                
 
            } while (opcion!=4);

        }

        public static int menu()
        {
            Console.Write("\n1.- Alquiler por identificador del cliente\n");
            Console.Write("2.- Alquileres en un dia especifico\n");
            Console.Write("3.- alquileres donde el costo es mayor o igual a 50\n");
            Console.Write("4.- Salir\n");
            Console.Write("Seleccione una opción\n");
            int op = int.Parse(Console.ReadLine());
            return op;
        }

        public static int mostrarAlquiler(List<Alquiler> alquileres, String cedula)
        {
            return alquileres.FindIndex(e => e.GetCliente().GetCedula() == cedula);//uso de expresion lambda
        }

        public static List<Alquiler> mostrarAlquileresFecha(List<Alquiler> alquileres,String fecha)
        {
            List<Alquiler> alquileresHoy = alquileres.FindAll((i) =>
            {
                if (i.GetFechaInicial().Equals(fecha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            return alquileresHoy;
        }

        public static List<Alquiler> mostrarAlquileres(List<Alquiler> alquileres)
        {
            List<Alquiler> alquileresHoy = alquileres.FindAll((i) =>
            {
                if (i.GetBarco().ModuloFuncion()>=50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            return alquileresHoy;
        }
    }
}
