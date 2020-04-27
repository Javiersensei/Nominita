using System;
namespace Empleado.cs.Properties
{
    public class Deduccion
    {
        private int idDeducciones;
        private int idTipoDeduccion;
        private int idEmpleados;
        private DateTime fechaDeduccion;

        public int iddeducciones { get => idDeducciones; set => idDeducciones = value; }
        public int idtipodeduccion { get => idTipoDeduccion; set => idTipoDeduccion = value; }
        public int idempleado { get => idEmpleados; set => idEmpleados = value; }
        public DateTime fechadeduccion { get => fechaDeduccion; set => fechaDeduccion = value; }

        public Deduccion()
        {
        }
    }
}
