using System;
using System.Collections.Generic;
using System.Text;
using Contreras.Parcial2.EE;
using Contreras.Parcial2.MPP;

namespace Contreras.Parcial2.BLL
{
    public class BLLRenta
    {
        MPPRenta rMpp = new MPPRenta();
        public void Insertar(EERenta r)
        {
            rMpp.Insertar(r);
        }

        public List<EERenta> ObtenerRentas()
        {
            return rMpp.ObtenerRentas();
        }
    }
}
