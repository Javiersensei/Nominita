using System;
namespace Empleado.cs.Properties
{
    public class Turno
    {
        private int IDTurno;
        private String NombreTurno;

        public int idturno { get => IDTurno; set => IDTurno = value; }
        public String nombreturno { get => NombreTurno; set => NombreTurno = value; }

        public Turno()
        {
        }
    }
}
