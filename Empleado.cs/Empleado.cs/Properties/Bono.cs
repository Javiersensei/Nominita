using System;
namespace Empleado.cs.Properties
{
    public class Bono
    {
        private int idBono;
        private int idEmpleados;
        private int idTipoBono;
        private DateTime FechaBono;

        public int idbono { get => idBono; set => idBono = value; }
        public int idempleados { get => idEmpleados; set => idEmpleados = value; }
        public int idtipobono { get => idTipoBono; set => idTipoBono = value; }
        public DateTime fechabono { get => FechaBono; set => FechaBono = value; }

        public Bono()
        {
        }
    }
}
