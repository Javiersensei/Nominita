using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Empleado.cs.Datos;
using Empleado.cs.Entidades;

namespace Empleado.cs.Datos
{
    public class DTMoneda
    {
        conexion con = new conexion();

        public List<Empleado.cs.Entidades.Moneda> ListarMoneda()
        {
            List<Empleado.cs.Entidades.Moneda> listaMoneda= new List<Empleado.cs.Entidades.Moneda>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Nomina;");
            sb.Append("Select * from Nomina.Moneda;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Empleado.cs.Entidades.Moneda a = new Empleado.cs.Entidades.Moneda()
                    {
                        idmoneda= Convert.ToInt32(idr["IDMoneda"]),
                        signoMoneda = idr["SignoMoneda"].ToString(),
                        cambio = (float)Convert.ToDecimal(idr["Cambio"]),
                        origenMoneda = idr["OrigenMoneda"].ToString(),
                        nombreMoneda = idr["NombreMoneda"].ToString(),
                        //Last_update = Convert.ToDateTime(idr["last_update"])
                    };

                    listaMoneda.Add(a);

                }
                idr.Close();

                return listaMoneda;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return listaMoneda;
        }

       
        public DTMoneda()
        {
        }
    }
}
