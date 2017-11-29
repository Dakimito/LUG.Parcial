using System;
using System.Collections.Generic;
using System.Text;
using Contreras.Parcial2.EE;
using Contreras.Parcial2.DAL;
using System.Collections;
using System.Data;

namespace Contreras.Parcial2.MPP
{
    public class MPPCliente
    {
        public Datos data = new Datos();
        public void InsertarActualizar(EECliente c)
        {
            string store = "s_InsertarCliente";
            Hashtable table = new Hashtable();

            if(c.ID != 0)
            {
                store = "s_ActualizarCliente";
                table.Add("@IDCliente", c.ID);
            }

            table.Add("@Nombre", c.Nombre);
            table.Add("@Apellido", c.Apellido);
            table.Add("@DNI", c.DNI);
            table.Add("@FechaNac", c.FechaNac);
            table.Add("@Email", c.Email);

            data.Escribir(store, table);
        }

        public List<EECliente> ObtenerClientes()
        {
            List<EECliente> clientes = new List<EECliente>();
            DataTable dt= new DataTable();

            string store = "s_ObtenerClientes";

            dt = data.Leer(store);

            if(dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    EECliente c = new EECliente();
                    c.ID = Convert.ToInt32(row["IDCliente"].ToString());
                    c.Nombre = row["Nombre"].ToString();
                    c.Apellido = row["Apellido"].ToString();
                    c.DNI = Convert.ToInt32(row["DNI"].ToString());
                    c.FechaNac = Convert.ToDateTime(row["FechaNac"].ToString());
                    c.Email = row["Email"].ToString();

                    clientes.Add(c);
                }
            }

            return clientes;
        }
    }
}
