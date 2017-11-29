using System;
using System.Collections.Generic;
using System.Text;
using Contreras.Parcial2.EE;
using Contreras.Parcial2.MPP;
using System.Data;

namespace Contreras.Parcial2.BLL
{
    public class BLLReporte
    {
        MPPReporte rMpp = new MPPReporte();
        public DataSet ObtenerReporte(string store)
        {
            return rMpp.ObtenerReporte(store);
        }
    }
}
