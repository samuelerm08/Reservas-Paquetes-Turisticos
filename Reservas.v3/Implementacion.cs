using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas.v3.Core;
using Reservas.v3.App;

namespace Reservas.v3
{
    public class Implementacion : Reserva
    {
        public Implementacion()
        {
            Console.WriteLine("Nombre del Pack: ");
            NombrePack = Console.ReadLine();

            Console.WriteLine("Precio Inicial: ");
            PrecioInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Continente de destino: ");
            Continente = Console.ReadLine();

            Console.WriteLine("Cantidad de Personas: ");
            CantPersonas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Posee anticipo? 1. Si | 2.No ");
            Anticipo = Console.ReadLine();

            Console.WriteLine("Cantidad de dias: ");
            CantDias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Medio de transporte: ");
            MedioTransporte = Console.ReadLine();

            Console.Clear();
        }

        public void CalcularPrecioFinal(Reserva r, IPrecioFinal precioF)
        {
            Console.WriteLine("Estos son sus datos: " +
                                  Environment.NewLine +
                                           ToString() +
                                  Environment.NewLine +
                              "Son Correctos? 1.Si | 2.No");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("El precio final es: " + precioF.Calculo(r));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Fin del calculo");
            }

        }
    }
}