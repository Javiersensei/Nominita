﻿using System;
namespace Empleado.cs.Properties
{
    public class TipoContrato
    {
        private int IDTipoContrato;
        private String DescripcionTipoContrato;

        public int idtipocontrato { get => IDTipoContrato; set => IDTipoContrato = value; }
        public String descripciontipocontrato { get => descripciontipocontrato; set => descripciontipocontrato = value; }

        public TipoContrato()
        {
        }
    }
}
