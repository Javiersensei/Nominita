using System;
namespace Empleado.cs.Properties
{
    public class UsuarioRol
    {
        private int idUsuario_Rol;
        private DateTime fechaCreacion;
        private int idUsuario;
        private int IdRol;

        public int idusuario_rol { get => idUsuario_Rol; set => idUsuario_Rol = value; }
        public DateTime fechacreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int idusuario { get => idUsuario; set => idUsuario = value; }
        public int idrol { get => IdRol; set => IdRol = value; }

        public UsuarioRol()
        {
        }
    }
}
