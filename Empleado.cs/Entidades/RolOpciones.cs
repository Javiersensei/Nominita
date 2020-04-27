using System;
namespace Empleado.cs.Properties
{
    public class RolOpciones
    {
        private int idRol_opciones;
        private String habilitado;
        private int idRol;
        private int idOpciones;
        private DateTime fechaCreacion;

        public int idrolopciones { get => idRol_opciones; set => idRol_opciones = value; }
        public String Habilitado { get => habilitado; set => habilitado = value; }
        public int idrol { get => idRol; set => idRol = value; }
        public int idopciones { get => idOpciones; set => idOpciones = value; }
        public DateTime fechacreacion { get => fechaCreacion; set => fechaCreacion = value; }



        public RolOpciones()
        {
        }
    }
}
