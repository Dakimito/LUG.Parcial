using System;
using System.Collections.Generic;
using System.Text;
using Contreras.Parcial2.EE;
using Contreras.Parcial2.DAL;
using System.Collections;
using System.Data;

namespace Contreras.Parcial2.MPP
{
    public class MPPRenta
    {
        Datos data = new Datos();
        public void Insertar(EERenta r)
        {
            string store = "s_InsertarRenta";
            Hashtable table = new Hashtable();

            table.Add("@IDCliente", r.IDCliente);
            table.Add("@IDVehiculo", r.IDVehiculo);
            table.Add("@Dias", r.Dias);
            table.Add("@Importe", r.Importe);

            data.Escribir(store, table);
        }

        public List<EERenta> ObtenerRentas()
        {
            List<EERenta> rentas = new List<EERenta>();
            DataTable dt = DataTable();

            string store = "s_ObtenerRentas";

            dt = data.Leer(store);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    EERenta r = new EERenta();
                    r.IDCliente = Convert.ToInt32(row["IDCliente"].ToString());
                    r.IDVehiculo = Convert.ToInt32(row["IDVehiculo"].ToString());
                    r.Dias = Convert.ToInt32(row["Dias"].ToString());
                    r.Importe = Convert.ToInt32(row["Importe"].ToString());

                    rentas.Add(r);
                }
            }

            return rentas;
        }
    }
}
