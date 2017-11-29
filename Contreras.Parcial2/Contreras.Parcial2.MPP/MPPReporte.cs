using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Contreras.Parcial2.MPP
{
    public class MPPReporte
    {
        Datos data = new Datos();
        public DataSet ObtenerReporte(string store)
        {
            DataSet ds = new DataSet();

            ds = data.LeerDS(store);

            return ds;
        }
    }
}
