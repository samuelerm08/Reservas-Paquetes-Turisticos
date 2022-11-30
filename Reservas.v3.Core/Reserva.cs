using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas.v3.Core;

namespace Reservas.v3.Core
{
    public class Reserva
    {
        public string NombrePack { get; set; }
        public double PrecioInicial { get; set; }
        public string Continente { get; set; }
        public int CantPersonas { get; set; }
        public string Anticipo { get; set; }
        public int CantDias { get; set; }
        public string MedioTransporte { get; set; }

        public override string ToString()
        {
            return $"Nombre del Pack: {NombrePack}\n" +
                   $"Precio Inicial: {PrecioInicial}\n" +
                   $"Continente: {Continente}\n" +
                   $"Cantidad Personas: {CantPersonas}\n" +
                   $"Anticipo: {Anticipo}\n" +
                   $"Cantidad de Dias: {CantDias}\n" +
                   $"Medio de Transporte: {MedioTransporte}";
        }
    }
}
