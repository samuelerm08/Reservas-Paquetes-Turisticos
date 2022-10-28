using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ReservasTuristicas
{
    public class App
    {     
        //Metodo Inicio de App
        public static void Start()
        {
            Datos datos = new();

            Completo(datos);
        }

        //Metodo de Interfaz Implementada
        static void Completo(IRegistroViaje registroViaje)
        {
            Viaje viaje = new();

            registroViaje.IngresoDatos(viaje);
        }
    }
}
