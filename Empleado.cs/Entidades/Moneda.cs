using System;
namespace Empleado.cs.Entidades
{
    public class Moneda
    {
        private int IDMoneda;
        private String SignoMoneda;
        private float Cambio;
        private String OrigenMoneda;
        private String NombreMoneda;

        public int idmoneda { get => IDMoneda; set => IDMoneda = value; }
        public String signoMoneda { get => SignoMoneda; set => SignoMoneda = value; }
        public float cambio { get => Cambio; set => Cambio = value; }
        public String origenMoneda { get => OrigenMoneda; set => OrigenMoneda = value; }
        public String nombreMoneda { get => NombreMoneda; set => NombreMoneda = value; }

        public Moneda()
        {
        }
    }
}
