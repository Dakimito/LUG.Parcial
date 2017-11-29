using System;
using System.Collections.Generic;
using System.Text;
using Contreras.Parcial2.EE;
using Contreras.Parcial2.DAL;
using System.Collections;
using System.Data;


namespace Contreras.Parcial2.MPP
{
    public class MPPVehiculo
    {
        Datos data = new Datos();
        public void InsetarActualizar(EEVehiculo v)
        {
            try
            {
                Hashtable table = Hashtable();
                string store = "s_InsertarVehiculo";

                if (v.ID !=0)
                {
                    store = "s_ActualizarVechiculo";
                    table.Add("@IDVehiculo", v.ID);
                }

                table.Add("@Marca", v.Marca);
                table.Add("@Modelo", v.Modelo);
                table.Add("@Patente", v.Patente);
                table.Add("@Tipo", v.Tipo);

                data.Escribir(store, table);
            }
            catch(Exception)
            {
                return;
            }
        }

        public List<EEVehiculo> ObtenerVehiculos()
        {
            List<EEVehiculo> vehs = new List<EEVehiculo>();
            DataTable dt = new DataTable();
            string store = "s_ObtenerVehiculos";

            dt = data.Leer(store);

            if(dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    EEVehiculo v = new EEVehiculo();
                    v.ID = Convert.ToInt32(row["IDVehiculo"].ToString());
                    v.Marca = row["Marca"].ToString();
                    v.Modelo = row["Modelo"].ToString();
                    v.Patente = row["Patente"].ToString();
                    v.Tipo = row["Tipo"].ToString();

                    vehs.Add(v);
                }
            }

            return vehs;
        }

        public void Eliminar(EEVehiculo v)
        {
            try
            {
                string store = "s_EliminarVehiculo";
                Hashtable table = new Hashtable();
                table.Add("@ID", v.ID);

                data.Escribir(store, table);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
