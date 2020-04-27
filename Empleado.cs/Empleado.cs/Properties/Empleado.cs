using System;
namespace Empleado.cs.Properties
{
    public class Empleado
    {
        private int idEmpleados;
        private String NombreEmpleado;
        private String ApellidoEmpleado;
        private String CedulaEmpleado;
        private String INSSEmpleado;
        private String NivelEstudioEmpleado;
        private DateTime FechaContratacionEmpleado;
        private DateTime FechaDeBajaEmpleado;
        private String SeguroEmpleado;
        private String DireccionEmpleado;
        private String MotivoBajaEmpleado;
        private double SalarioEmpleado;
        private String Estado;
        private int IDArea;
        private int IDContrato;
        private int IDSucursal;
        private int IDCargo;
        private int IDPago;
        private int IDMoneda;

        public int idempleados { get => idEmpleados; set => idEmpleados = value; }
        public String nombreempleado { get => NombreEmpleado; set => NombreEmpleado = value; }
        public String apellidoempleado { get => ApellidoEmpleado; set => ApellidoEmpleado = value; }
        public String cedulaempleado { get => CedulaEmpleado; set => CedulaEmpleado = value; }
        public String INSSempleado { get => INSSEmpleado; set => INSSEmpleado = value; }
        public String nivelestudioempleado { get => NivelEstudioEmpleado; set => NivelEstudioEmpleado = value; }
        public DateTime fechacontratacionempleado { get => FechaContratacionEmpleado; set => FechaContratacionEmpleado = value; }
        public DateTime fechadebajaempleado { get => FechaDeBajaEmpleado; set => FechaDeBajaEmpleado = value; }
        public String seguroempleado { get => SeguroEmpleado; set => SeguroEmpleado = value; }
        public String direccionempleado { get => DireccionEmpleado; set => DireccionEmpleado = value; }
        public String motivobajaempleado { get => MotivoBajaEmpleado; set => MotivoBajaEmpleado = value; }
        public double salarioempleado { get => SalarioEmpleado; set => SalarioEmpleado = value; }
        public String estado { get => Estado; set => Estado = value; }
        public int idarea { get => IDArea; set => IDArea = value; }
        public int idcontrato { get => IDContrato; set => IDContrato = value; }
        public int idsucursal { get => IDSucursal; set => IDSucursal = value; }
        public int idcargo { get => IDCargo; set => IDCargo = value; }
        public int idpago { get => IDPago; set => IDPago = value; }
        public int idmoneda { get => IDMoneda; set => IDMoneda = value; }

    }
}

