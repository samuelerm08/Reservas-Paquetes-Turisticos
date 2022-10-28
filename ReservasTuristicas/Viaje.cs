using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasTuristicas
{
    public class Viaje
    {        
        //Atributos
        private int cantidadPersonas;
        private string? nombreContinente;
        private double precioInicial;
        private string? anticipo;
        private string? medioTransporte;
        private string? nombrePack;
        private int cantidadDias;
        private double total;

        //GetsSets
        public int CantidadPersonas { get => cantidadPersonas; set => cantidadPersonas = value; }        
        public string? NombreContinente { get => nombreContinente; set => nombreContinente = value; }
        public double PrecioInicial { get => precioInicial; set => precioInicial = value; }
        public string? Anticipo { get => anticipo; set => anticipo = value; }
        public string? MedioTransporte { get => medioTransporte; set => medioTransporte = value; }
        public string? NombrePack { get => nombrePack; set => nombrePack = value; }
        public int CantidadDias { get => cantidadDias; set => cantidadDias = value; }
        public double Total { get => total; set => total = value; }
    }
}
