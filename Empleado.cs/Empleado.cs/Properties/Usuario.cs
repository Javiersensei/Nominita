using System;
namespace Empleado.cs.Properties
{
    public class Usuario
    {
        private int idUsuario;
        private String usuario;
        private String pwd;
        private DateTime fechaCreacion;
        private DateTime ultima_fecha_Ingreso;
        private int activo;
        private int idEmpleados;

        public int idusuario { get => idUsuario; set => idUsuario = value; }
        public String UsuariO { get => usuario; set => usuario = value; }
        public String PWD { get => pwd; set => pwd = value; }
        public DateTime fechacreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime ultimafechaingreso { get => ultima_fecha_Ingreso; set => ultimafechaingreso = value; }
        public int Activo { get => activo; set => activo = value; }
        public int idempleados { get => idEmpleados; set => idEmpleados = value; }

        public Usuario()
        {
        }
    }
}
