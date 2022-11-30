using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas.v3.Core;

namespace Reservas.v3.App
{
    public class CalculoCompleto : IPrecioFinal
    {
        public double Calculo(Reserva reserva)
        {
            double totalReserva = reserva.PrecioInicial;

            if (reserva.Continente == "America")
            {
                totalReserva *= 0.95;                
            }

            totalReserva *= reserva.CantPersonas;            

            if (reserva.Anticipo == "1")
            {
                totalReserva *= 0.95;                
            }

            switch (reserva.MedioTransporte)
            {
                case "terrestre":
                    totalReserva *= 1.3;
                    
                    break;

                case "aereo":
                    totalReserva *= 1.4;
                    break;

                case "maritimo":
                    totalReserva *= 1.5;
                    break;                    
            }

            return totalReserva;
        }
    }
}
