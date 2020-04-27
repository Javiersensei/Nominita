using System;
namespace Empleado.cs.Properties
{
    public class Empresa
    {
        private String NumeroRUC;
        public String Nombre;
        public String Telefono;
        public String Direccion;

        public String numeroRUC { get => NumeroRUC; set => NumeroRUC = value; }
        public String nombre { get => Nombre; set => Nombre = value; }
        public String telefono { get => Telefono; set => Telefono = value; }
        public String direccion { get => Direccion; set => Direccion = value; }
        public Empresa()
        {
        }
    }
}
