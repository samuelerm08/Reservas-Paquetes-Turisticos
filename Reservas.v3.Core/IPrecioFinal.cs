using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas.v3.Core;

namespace Reservas.v3.Core
{
    public interface IPrecioFinal
    {
        double Calculo(Reserva reserva);
    }
}
