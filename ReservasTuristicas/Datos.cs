using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasTuristicas
{
    public class Datos : IRegistroViaje
    {
        //Atributos
        private readonly CalculadorPrecio CalculadorPrecio = new();              

        //Ingreso de Datos e Implementacion de Metodo de la Interfaz
        public void IngresoDatos(Viaje viaje)
        {
            CalculadorPrecio.Registro();

            CalculadorPrecio.Descuento();
           
            CalculadorPrecio.Personas();            

            CalculadorPrecio.Anticipado();
                        
            CalculadorPrecio.MedioTransporte();

            Console.Clear();                        

            CalculadorPrecio.TotalFinal();            
        }                
    }
}
