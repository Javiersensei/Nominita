using System;
namespace Empleado.cs.Properties
{
    public class TipoBonos
    {
        private int idTipoBono;
        private String tipoBono;
        private float IngresoExtra;
        private String DescripcionBono;

        public int idtipobono { get => idTipoBono; set => idTipoBono = value; }
        public String tipobono { get => tipoBono; set => tipoBono = value; }
        public float ingresoextra { get => IngresoExtra; set => IngresoExtra = value; }
        public String descripcionbono { get => DescripcionBono; set => DescripcionBono = value; }
        public TipoBonos()
        {

        }
    }
}
