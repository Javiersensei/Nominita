using System;
namespace Empleado.cs.Properties
{
    public class Cargo
    {
        private int IDCargo;
        private String Nombre;

        public int idcargo { get => IDCargo; set => IDCargo = value; }
        public String nombre { get => Nombre; set => Nombre = value; }

        public Cargo()
        {
        }
    }
}
