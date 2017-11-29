using System;
using System.Collections.Generic;
using System.Text;

namespace Contreras.Parcial2.EE
{
    public class EEVehiculo
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public string Tipo { get; set; }

        public Vehiculo() { }

        public override string ToString()
        {
            return Tipo + " - " + Marca + " - " + Modelo;
        }
    }
}
