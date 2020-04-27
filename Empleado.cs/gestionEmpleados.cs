using System;
using System.Collections.Generic;
using Empleado.cs.Datos;
using Empleado.cs.Utilidades;
using Gtk;

namespace Empleado.cs
{
    public partial class gestionEmpleados : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();
        public gestionEmpleados() : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(String), typeof(String));
        //Método para llenar treeview
        public void llenarTreeview()
        {
            Empleado.cs.Datos.DTMoneda dta = new Empleado.cs.Datos.DTMoneda();
            List<Entidades.Moneda> lista = new List<Entidades.Moneda>();
            lista = dta.ListarMoneda();

            foreach (Entidades.Moneda a in lista)
            {
                ls.AppendValues(a.idmoneda.ToString(), a.signoMoneda, a.cambio.ToString(), a.origenMoneda, a.nombreMoneda);
            }

            //Crear el modelo de datos
            tvMoneda.Model = ls;

            tvMoneda.AppendColumn("ID", new CellRendererText(), "text", 0);
            tvMoneda.AppendColumn("Signo", new CellRendererText(), "text", 1);
            tvMoneda.AppendColumn("Cambio", new CellRendererText(), "text", 2);
            tvMoneda.AppendColumn("Origen", new CellRendererText(), "text", 3);
            tvMoneda.AppendColumn("Nombre", new CellRendererText(), "text", 4);
        }

        public void RecargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvMoneda.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvMoneda.RemoveColumn(tvc);
            }
            ls.Clear();
        }
        protected void OnTvMonedaRowActivated(object o, RowActivatedArgs args)
        {
        }
    }
}

