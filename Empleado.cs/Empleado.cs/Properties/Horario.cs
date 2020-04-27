using System;
namespace Empleado.cs.Properties
{
    public class Horario
    {
        private int IDHorario;
        private String HoraEntrada;
        private String HoraSalida;
        private int IDTurno;

        public int idhorario { get => IDHorario; set => IDHorario = value; }
        public String horaentrada { get => HoraEntrada; set => HoraEntrada = value; }
        public String horasalida { get => HoraSalida; set => HoraSalida = value; }
        public int idturno { get => IDTurno; set => IDTurno = value; }

        public Horario()
        {
        }
    }
}
