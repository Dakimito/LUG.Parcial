using System;
using System.Collections.Generic;
using System.Text;
using Contreras.Parcial2.EE;
using Contreras.Parcial2.MPP;

namespace Contreras.Parcial2.BLL
{
    public class BLLCliente
    {
        MPPCliente cMpp = new MPPCliente();
        public void Insertar (EECliente c)
        {
            cMpp.InsertarActualizar(c);
        }

        public void Actualizar (EECliente c)
        {
            cMpp.InsertarActualizar(c);
        }

        public List<EECliente> ObtenerClientes()
        {
            return cMpp.ObtenerClientes();
        }
    }
}
