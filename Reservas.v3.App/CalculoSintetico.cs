using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas.v3.Core;

namespace Reservas.v3.App
{
    public class CalculoSintetico : IPrecioFinal
    {
        public double Calculo(Reserva reserva)
        {
            double totalReserva = reserva.PrecioInicial;

            if (reserva.Continente == "America")
            {
                totalReserva *= 0.95;
            }

            totalReserva *= reserva.CantPersonas * 2;

            return totalReserva;
        }
    }
}
