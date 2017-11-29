using System;
using System.Collections.Generic;
using System.Text;

namespace Contreras.Parcial2.EE
{
    public class EECliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }

        public Cliente() { }
    }
}
