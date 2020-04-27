using System;
namespace Empleado.cs.Properties
{
    public class Area
    {
        private int IDArea;
        private String Nombre;
        private int IDDepartamento;

        public int idarea { get => IDArea; set => IDArea = value; }
        public String nombre { get => Nombre; set => Nombre = value; }
        public int iddepartamento { get => IDDepartamento; set => IDDepartamento = value; }

        public Area()
        {
        }
    }
}
