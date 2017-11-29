using System;
using System.Collections.Generic;
using System.Text;
using Contreras.Parcial2.EE;
using Contreras.Parcial2.MPP;

namespace Contreras.Parcial2.BLL
{
    public class BLLVehiculo
    {
        MPPVehiculo vMpp = new MPPVehiculo();
        public void Insertar (EEVehiculo v)
        {
            vMpp.InsetarActualizar(v);
        }

        public void Actualizar (EEVehiculo v)
        {
            vMpp.InsetarActualizar(v);
        }

        public void Eliminar (EEVehiculo v)
        {
            vMpp.Eliminar(v);
        }

        public List<EEVehiculo> ObtenerVehiculos()
        {
            return vMpp.ObtenerVehiculos();
        }
    }
}
