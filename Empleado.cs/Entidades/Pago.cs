using System;
namespace Empleado.cs.Properties
{
    public class Pago
    {
        private int IDPago;
        private String TipoPago;

        public int idpago { get => IDPago; set => IDPago = value; }
        public String tipopago { get => TipoPago; set => TipoPago = value; }

        public Pago()
        {
        }
    }
}
