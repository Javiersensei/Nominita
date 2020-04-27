using System;
namespace Empleado.cs.Properties
{
    public class Sucursal
    {
        private int IDSucursal;
        private String NombreSucursal;
        private String NumeroRUC;

        public int idsucursal { get => IDSucursal; set => IDSucursal = value; }
        public String nombresucursal { get => NombreSucursal; set => NombreSucursal = value; }
        public String numeroRUC { get => NumeroRUC; set => NumeroRUC = value; }
        public Sucursal()
        {
        }
    }
}
