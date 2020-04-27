using System;
namespace Empleado.cs.Properties
{
    public class Contrato
    {
        private int IDContrato;
        private String DescripcionContrato;
        private int IDTipoContrato;
        private int IDHorario;

        public int idcontrato { get => IDContrato; set => IDContrato = value; }
        public String descripcioncontrato { get => DescripcionContrato; set => DescripcionContrato = value; }
        public int idtipocontrato { get => IDTipoContrato; set => IDTipoContrato = value; }
        public int idhorario { get => IDHorario; set => IDHorario = value; }

        public Contrato()
        {
        }
    }
}
