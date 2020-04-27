using System;
namespace Empleado.cs.Properties
{
    public class Rol
    {
        private int idRol;
        private String nombre;

        public int idrol { get => idRol; set => idRol = value; }
        public String Nombre { get => nombre; set => nombre = value; }

        public Rol()
        {
        }
    }
}
