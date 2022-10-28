using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ReservasTuristicas
{
    public class CalculadorPrecio
    {
        //Atributos               
        public Viaje viaje = new();        

        //Metodos
        public void Registro()
        {
            Console.WriteLine("Nombre del Pack");
            viaje.NombrePack = Console.ReadLine();

            Console.WriteLine("Cantidad de dias del Pack");
            viaje.CantidadDias = Convert.ToInt16(Console.ReadLine());
        }

        public void Descuento()
        {           

            Console.WriteLine("Precio Inicial del Pack");
            viaje.PrecioInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Continente de destino (Inicial Mayuscula)");
            viaje.NombreContinente = Console.ReadLine();

            if (viaje.NombreContinente == "America")
            {
                viaje.PrecioInicial -= (viaje.PrecioInicial * 0.05);
            }

            viaje.Total = viaje.PrecioInicial;            
        }

        public void Personas()
        {
            Console.WriteLine("Cantidad de personas");
            viaje.CantidadPersonas = Convert.ToInt16(Console.ReadLine());

            viaje.Total *= viaje.CantidadPersonas;
            
        }

        public void Anticipado()
        {
            Console.WriteLine("Reserva Anticipada? (Si / No)");
            viaje.Anticipo = Console.ReadLine();

            if (viaje.Anticipo == "Si")
            {
                viaje.Total -= (viaje.Total * 0.05);
            }
            
        }

        public void MedioTransporte()
        {
            Console.WriteLine("Medio de Transporte (Inicial Mayuscula)");
            viaje.MedioTransporte = Console.ReadLine();

            switch (viaje.MedioTransporte)
            {
                case "Maritimo":
                    viaje.Total += (viaje.Total * 0.5);
                    break;

                case "Terrestre":
                    viaje.Total += (viaje.Total * 0.3);
                    break;

                case "Aereo":
                    viaje.Total += (viaje.Total * 0.4);
                    break;
            }                        
        }    
        
        public void TotalFinal()
        {
            Console.WriteLine("Estos son sus datos: " + Environment.NewLine);
            Console.WriteLine(ToString());

            Console.WriteLine("Son correctos? 1.Si | 2. No");
            int op = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            if (op == 1)
            {
                Console.WriteLine($"El total final del Pack es: {viaje.Total}");
            }            
        }

        public override string ToString()
        {
            return $"Nombre del Pack: {viaje.NombrePack}\nPrecio Inicial: {viaje.PrecioInicial}\nContinente: {viaje.NombreContinente}\nCantidad de Personas: {viaje.CantidadPersonas}\nReserva Anticipada: {viaje.Anticipo}\nCantidad de días del Pack: {viaje.CantidadDias}\nMedio de Transporte: {viaje.MedioTransporte}\n";
        }
    }
}
