using System;
namespace Empleado.cs.Properties
{
    public class TipoDeducciones
    {
        private int idTipoDeduccion;
        private String TipoDeduccion;
        private float CantidadDeducida;
        private String DescripcionDeduccion;

        public int idtipodeduccion { get => idTipoDeduccion; set => idTipoDeduccion = value; }
        public String tipodeduccion { get => TipoDeduccion; set => TipoDeduccion = value; }
        public float cantidaddeducida { get => CantidadDeducida; set => CantidadDeducida = value; }
        public String descripciondeduccion { get => DescripcionDeduccion; set => DescripcionDeduccion = value; }

        public TipoDeducciones()
        {
        }
    }
}
