using Reservas.v3.App;
using Reservas.v3.Core;
using System.Security.Cryptography.X509Certificates;

namespace Reservas.v3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Implementacion i = new();

            i.CalcularPrecioFinal(i, new CalculoCompleto());
            //i.CalcularPrecioFinal(i, new CalculoSintetico());
        }        
    }
}