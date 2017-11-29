using System;
using System.Collections.Generic;
using System.Text;

namespace Contreras.Parcial2.EE
{
    public class EERenta
    {
        public int IDVehiculo { get; set; }
        public int IDCliente { get; set; }
        public int Dias { get; set; }
        public int Importe { get; set; }

        public Renta() { }
    }
}
