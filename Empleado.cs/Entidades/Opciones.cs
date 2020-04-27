using System;
namespace Empleado.cs.Properties
{
    public class Opciones
    {
        private int idOpciones;
        private String nombre;
        private String formulario;

        public int idopciones { get => idOpciones; set => idOpciones = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Formulario { get => formulario; set => formulario = value; }


        public Opciones()
        {
        }
    }
}
